/*
      Title: Ground Rocket Software
    Creator: Harley McPhee
Description: The purpose of this software is to connect to an xbee via serial port, the xbee should recieve information
from an arduino hooked up to an xbee and multiple sensors.
The sensors data this program should expect are
Pressure
Altitude
GPS cordinates
Velocity
Acceleration
The program will also allow the xbee to transmit information to the arduino such as a signal to manually deploy the parachute
and also to manually change the sea level air pressure value
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace RocketGroundControl
{
    public partial class RocketGroundControl : Form
    {
        const int START_BYTE_POS      = 0;
        const int TRANSCIEVERD_ID_POS = 1;
        const int ROCKET_STAGE_POS    = 2;
        const int COMMAND_ID_POS      = 3;
        const int TIME_POS            = 4;
        
        public SerialPort xbeePort; 
        public string[] dataRecievedArray;
        public double[] accelOffset = {0, 0, 0};
        public bool connected = false;
        public bool unlockrocket = false;
        public bool simulationOn = false;
        public double maxAltitude = 0;
        public bool setAccelOffset = false;
        delegate void SetTextCallback();
        public bool writeOn = false;
        public Chart chart = new Chart();

        public double counter = 0;

        public int count = 0;
        public int timeOutCounter = 1;
        public int lastTimeRecieved = 0;
        public int oldTimeRecieved = 0;
        public StreamWriter file;
        
        public RocketGroundControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console. 
            foreach (string port in ports)
            {
                comPortCB.Items.Add(port);
            }

        }
        private void portDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /*
             * data templates
             BMP SENSOR  0xFF:N:1:PP:N:TIME:PRESSURE:TEMPERATURE:ALTITUDE
             */
            try
            {
                string data = xbeePort.ReadLine();
                
                do
                {
                    if (writeOn)
                        file.Write(data);
                    dataRecievedArray = data.Split(':'); // Split up each piece of data into an array
                    if (dataRecievedArray[START_BYTE_POS] == "255")
                    {
                        if (dataRecievedArray[COMMAND_ID_POS] == "PP" && dataRecievedArray[8] == "254\r") // Checks if we recieved BMP sensor info format BMP:ONLINE:PRESSURE:TEMPERATURE:ALTITUDE9
                        {
                          //  Console.WriteLine(dataRecievedArray[7]);
                            setRocketStatus();
                            setTextBMP();
                        }
                        else if (dataRecievedArray[COMMAND_ID_POS] == "GG")
                        {
                            setTextGPS();

                        }
                        else if (dataRecievedArray[COMMAND_ID_POS] == "AA" && dataRecievedArray[8] == "254\r")
                        {
                            setTextAccel();
                        }
                        else if (dataRecievedArray[COMMAND_ID_POS] == "CC" && dataRecievedArray[9] == "254\r")
                        {
                            //Console.WriteLine(dataRecievedArray[7]);
                            setTextCustomData();
                        }
                    }
                    data = xbeePort.ReadLine();
                } while(data != "");
            }
            catch (Exception el)
            {
               // MessageBox.Show(el.InnerException.ToString());
            }
        }
        private void setRocketStatus()
        {
            if (this.rocketstatuslbl.InvokeRequired) // Must invoke UI thread to change UI elements since portDataRecieved is on a separate thread
            {
                SetTextCallback d = new SetTextCallback(setRocketStatus);
                this.Invoke(d, new object[] { });
            }
            else
            {
                switch (dataRecievedArray[ROCKET_STAGE_POS])
                {
                    case "00":
                        rocketstatuslbl.Text = "LOCKED GROUND STAGE";
                        break;
                    case "11":
                        rocketstatuslbl.Text = "GROUND STAGE";
                        break;
                    case "22":
                        rocketstatuslbl.Text = "THRUST STAGE";
                        break;
                    case "33":
                        rocketstatuslbl.Text = "DECELERATION STAGE";
                        break;
                    case "44":
                        rocketstatuslbl.Text = "DESCENT DROGUE CHUTE STAGE";
                        break;
                    case "55":
                        rocketstatuslbl.Text = "DESCENT MAIN CHUTE STAGE";
                        break;
                }
                timeOutCounter = 0;
                oldTimeRecieved = lastTimeRecieved;
                lastTimeRecieved = Convert.ToInt32(dataRecievedArray[TIME_POS]);
            }
        }
        private void setTextCustomData()
        {
            if (this.filtaltlbl.InvokeRequired) // Must invoke UI thread to change UI elements since portDataRecieved is on a separate thread
            {
                SetTextCallback d = new SetTextCallback(setTextCustomData);
                this.Invoke(d, new object[] { });
            }
            else
            {
                try
                { 
                    filtaltlbl.Text = dataRecievedArray[5];
                    calcvelocitylbl.Text = dataRecievedArray[6];
                    maxAltitudelbl.Text = dataRecievedArray[8];
                    iterationlbl.Text = "Rocket Loop Iteration Rate: " + string.Format("{0:00.00}", ( Convert.ToDouble(dataRecievedArray[7]))) + " ms";
                    chart.addPoint(3, Double.Parse(dataRecievedArray[4])/ 1000, Double.Parse(dataRecievedArray[5]));
                    
                }
                catch { }
            }
        }
        private void setTextAccel()
        {
            if (this.accelerometerlbl.InvokeRequired) // Must invoke UI thread to change UI elements since portDataRecieved is on a separate thread
            {
                SetTextCallback d = new SetTextCallback(setTextAccel);
                this.Invoke(d, new object[] { });
            }
            else
            {
                try
                {
                    
                    accelerometerlbl.Text = "Online";
                    accelerationXlbl.Text = "X: " +  (Convert.ToDouble(dataRecievedArray[5]) - accelOffset[0]);
                    accelerationYlbl.Text = "Y: " +  (Convert.ToDouble(dataRecievedArray[6]) - accelOffset[1]);
                    accelerationZlbl.Text = "Z: " +  (Convert.ToDouble(dataRecievedArray[7]) - accelOffset[2]);

                    if (setAccelOffset)
                    {
                        accelOffset[0] = Convert.ToDouble(dataRecievedArray[5]);
                        accelOffset[1] = Convert.ToDouble(dataRecievedArray[6]);
                        accelOffset[2] = Convert.ToDouble(dataRecievedArray[7]);
                        setAccelOffset = false;
                    }
                    accelerometerlbl.ForeColor = Color.Lime;

                    chart.addPoint(4, Double.Parse(dataRecievedArray[4]) / 1000, Double.Parse(dataRecievedArray[5]));
                    chart.addPoint(5, Double.Parse(dataRecievedArray[4]) / 1000, Double.Parse(dataRecievedArray[6]));
                    chart.addPoint(6, Double.Parse(dataRecievedArray[4]) / 1000, Double.Parse(dataRecievedArray[7]));
                }
                catch { }
            }
        }
        private void setTextGPS()
        {
           try
            {
            if (this.gpslbl.InvokeRequired) // Must invoke UI thread to change UI elements since portDataRecieved is on a separate thread
            {
                SetTextCallback d = new SetTextCallback(setTextGPS);
                this.Invoke(d, new object[] { });
            }
            else
            { 

                    if (dataRecievedArray[1] == "OFFLINE\r")
                    {
                        gpslbl.Text = "Offline";
                        gpslbl.ForeColor = Color.Red;
                    }
                    else
                    {
                        gpslbl.Text = "Online";
                        gpsLatlbl.Text = "Lati: " + dataRecievedArray[7];
                        gpsLonglbl.Text = "Long: " + dataRecievedArray[8];
                        satNumlbl.Text = "Sat Num: " + dataRecievedArray[9];
                        gpsAltlbl.Text = "GPS Alt: " + dataRecievedArray[10];
                        gpslbl.ForeColor = Color.Lime;
                    }
                }
                
            }catch { }

        }
        private void setTextBMP()
        {
            try
            {
                if (this.barometriclbl.InvokeRequired) // Must invoke UI thread to change UI elements since portDataRecieved is on a separate thread
                {
                    SetTextCallback d = new SetTextCallback(setTextBMP);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    barometriclbl.Text = "Online";
                    barometriclbl.ForeColor = Color.Lime;

                    airpressurelbl.Text = dataRecievedArray[5];
                    altitudelbl.Text = dataRecievedArray[7];

                    chart.addPoint(0, Double.Parse(dataRecievedArray[4]) / 1000, Double.Parse(dataRecievedArray[5]));
                    chart.addPoint(1, Double.Parse(dataRecievedArray[4]) / 1000, Double.Parse(dataRecievedArray[6]));
                    chart.addPoint(2, Double.Parse(dataRecievedArray[4]) / 1000, Double.Parse(dataRecievedArray[7]));
                } 
            }
                catch {}
        }
        private void combutton_Click(object sender, EventArgs e)
        {
            if (!connected) // Check if connection exists
            {
                try
                {
                    string selected = (string)comPortCB.SelectedItem;
                    xbeePort = new SerialPort(selected, (int)baudratenum.Value);
                    xbeePort.DtrEnable = false;
                    xbeePort.RtsEnable = false;
   
                    xbeePort.Open();
                    connected = true;
                    combutton.Text = "Disconnect";
                    comPortCB.Enabled = false;
                    parachuteCheckBox.Enabled = true;
                    parachuteTextBox.Enabled = true;
                    deployButton.Enabled = true;
                    pressureSend.Enabled = true;
                    pressureTextBox.Enabled = true;
                    xbeePort.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
                }
                catch
                {
                    MessageBox.Show("Invalid COM xbeePort.");
                }
                
            }
            else
            {
                try
                {
                    xbeePort.DataReceived -= new SerialDataReceivedEventHandler(portDataReceived);
                    xbeePort.Close();
                    combutton.Text = "Connect";
                    connected = false;
                    comPortCB.Enabled = true;
                    parachuteCheckBox.Enabled = false;
                    parachuteTextBox.Enabled = false;
                    deployButton.Enabled = false;
                    pressureSend.Enabled = false;
                    pressureTextBox.Enabled = false;
                }
                catch (Exception el)
                {
                    MessageBox.Show(el.InnerException.ToString());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            xbeePort.Write("pressure:" + pressureTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parachuteCheckBox.Checked && parachuteTextBox.Text == "manual")
            {
                xbeePort.Write("LaunchPar");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chart.Show();
        }

        private void unlockrocketbtn_Click(object sender, EventArgs e)
        {
            if (!unlockrocket)
            {
                byte[] bytesToSend = new byte[16] { 0xFF, 0x3A, 0x47, 0x3A, 0x30, 0x30, 0x3A, 0x55, 0x55, 0x3A, 0x30, 0x3A, 0x53, 0x31, 0x3A, 0xFE };
                xbeePort.Write(bytesToSend, 0, 16);
                unlockrocketbtn.Text = "Lock Rocket";
                unlockrocket = true;
            }
            else
            {
                byte[] bytesToSend = new byte[16] { 0xFF, 0x3A, 0x47, 0x3A, 0x30, 0x30, 0x3A, 0x4C, 0x4C, 0x3A, 0x30, 0x3A, 0x53, 0x30, 0x3A, 0xFE };
                xbeePort.Write(bytesToSend, 0, 16);
                unlockrocketbtn.Text = "Unlock Rocket";
                unlockrocket = false;
            }
            //xbeePort.WriteLine("255:G:00:UU:0:S1:254");
           
        }

        private void update_Tick(object sender, EventArgs e)
        {
            if (timeOutCounter == 0)
            {
                timelbl.Text = "Packet recieved rate: " + (lastTimeRecieved - oldTimeRecieved).ToString() + " ms";
                timelbl.ForeColor = Color.Lime;
            }
            else if (timeOutCounter > 4)
            {
                timelbl.Text = "No signal for " + ((timeOutCounter + 1) * 1000).ToString() + " ms";
                timelbl.ForeColor = Color.Red;
            }
            timeOutCounter++;
        }

        private void simulatelbl_Click(object sender, EventArgs e)
        {
            if (!simulationOn)
            {
                byte[] bytesToSend = new byte[16] { 0xFF, 0x3A, 0x47, 0x3A, 0x30, 0x30, 0x3A, 0x53, 0x4D, 0x3A, 0x30, 0x3A, 0x53, 0x31, 0x3A, 0xFE };
                xbeePort.Write(bytesToSend, 0, 16);
                simulatelbl.Text = "Turn Simulation off";
                simulationOn = true;
                
            }
            else
            {
                byte[] bytesToSend = new byte[16] { 0xFF, 0x3A, 0x47, 0x3A, 0x30, 0x30, 0x3A, 0x53, 0x4D, 0x3A, 0x30, 0x3A, 0x53, 0x30, 0x3A, 0xFE };
                xbeePort.Write(bytesToSend, 0, 16);
                simulatelbl.Text = "Turn Simulation on";
                simulationOn = false;
            }
        }

        private void storebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (writeOn)
                {
                    writeOn = false;
                    storebutton.Text = "Store Data";
                    file.Close();
                }
                else
                {
                    storebutton.Text = "Stop Storing Data";
                    writeOn = true;
                    file = new StreamWriter(filetxt.Text + ".txt");
                }
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void recievedRateTxt_Click(object sender, EventArgs e)
        {
            try
            {
                int rate = (int)ratenum.Value;
                byte[] intBytes = BitConverter.GetBytes(rate);
                byte[] bytesToSend = new byte[16] { 0xFF, 0x3A, 0x47, 0x3A, 0x30, 0x30, 0x3A, 0x43, 0x52, 0x3A, 0x30, 0x3A, intBytes[1], intBytes[0], 0x3A, 0xFE };
                xbeePort.Write(bytesToSend, 0, 16);
            }
            catch { }
         
        }

        private void setAccelOffsetBtn_Click(object sender, EventArgs e)
        {
            setAccelOffset = true;
        }

    }
}
