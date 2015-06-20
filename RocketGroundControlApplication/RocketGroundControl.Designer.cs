namespace RocketGroundControl
{
    partial class RocketGroundControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RocketGroundControl));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpslbl = new System.Windows.Forms.Label();
            this.barometriclbl = new System.Windows.Forms.Label();
            this.accelerometerlbl = new System.Windows.Forms.Label();
            this.rocketstatuslbl = new System.Windows.Forms.Label();
            this.deployButton = new System.Windows.Forms.Button();
            this.parachuteTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpsAltlbl = new System.Windows.Forms.Label();
            this.satNumlbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.calcvelocitylbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.filtaltlbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.airpressurelbl = new System.Windows.Forms.Label();
            this.altitudelbl = new System.Windows.Forms.Label();
            this.maxAltitudelbl = new System.Windows.Forms.Label();
            this.gpsLonglbl = new System.Windows.Forms.Label();
            this.gpsLatlbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.velocityZlbl = new System.Windows.Forms.Label();
            this.velocityYlbl = new System.Windows.Forms.Label();
            this.velocityXlbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.accelerationZlbl = new System.Windows.Forms.Label();
            this.accelerationYlbl = new System.Windows.Forms.Label();
            this.accelerationXlbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.combutton = new System.Windows.Forms.Button();
            this.parachuteCheckBox = new System.Windows.Forms.CheckBox();
            this.pressureSend = new System.Windows.Forms.Button();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comPortCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.unlockrocketbtn = new System.Windows.Forms.Button();
            this.timelbl = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.simulatelbl = new System.Windows.Forms.Button();
            this.iterationlbl = new System.Windows.Forms.Label();
            this.storebutton = new System.Windows.Forms.Button();
            this.filetxt = new System.Windows.Forms.TextBox();
            this.ratenum = new System.Windows.Forms.NumericUpDown();
            this.recievedRateTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.baudratenum = new System.Windows.Forms.NumericUpDown();
            this.setAccelOffsetBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.runtimeLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.avionicsCheckbox = new System.Windows.Forms.CheckBox();
            this.noseCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratenum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudratenum)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rocket Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Accelerometer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "GPS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(23, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Barometric:";
            // 
            // gpslbl
            // 
            this.gpslbl.AutoSize = true;
            this.gpslbl.BackColor = System.Drawing.Color.Transparent;
            this.gpslbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpslbl.ForeColor = System.Drawing.Color.Red;
            this.gpslbl.Location = new System.Drawing.Point(193, 109);
            this.gpslbl.Name = "gpslbl";
            this.gpslbl.Size = new System.Drawing.Size(87, 21);
            this.gpslbl.TabIndex = 12;
            this.gpslbl.Text = "Offline";
            // 
            // barometriclbl
            // 
            this.barometriclbl.AutoSize = true;
            this.barometriclbl.BackColor = System.Drawing.Color.Transparent;
            this.barometriclbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barometriclbl.ForeColor = System.Drawing.Color.Red;
            this.barometriclbl.Location = new System.Drawing.Point(193, 86);
            this.barometriclbl.Name = "barometriclbl";
            this.barometriclbl.Size = new System.Drawing.Size(87, 21);
            this.barometriclbl.TabIndex = 11;
            this.barometriclbl.Text = "Offline";
            // 
            // accelerometerlbl
            // 
            this.accelerometerlbl.AutoSize = true;
            this.accelerometerlbl.BackColor = System.Drawing.Color.Transparent;
            this.accelerometerlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerometerlbl.ForeColor = System.Drawing.Color.Red;
            this.accelerometerlbl.Location = new System.Drawing.Point(193, 65);
            this.accelerometerlbl.Name = "accelerometerlbl";
            this.accelerometerlbl.Size = new System.Drawing.Size(87, 21);
            this.accelerometerlbl.TabIndex = 9;
            this.accelerometerlbl.Text = "Offline";
            // 
            // rocketstatuslbl
            // 
            this.rocketstatuslbl.AutoSize = true;
            this.rocketstatuslbl.BackColor = System.Drawing.Color.Transparent;
            this.rocketstatuslbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rocketstatuslbl.ForeColor = System.Drawing.Color.Lime;
            this.rocketstatuslbl.Location = new System.Drawing.Point(193, 18);
            this.rocketstatuslbl.Name = "rocketstatuslbl";
            this.rocketstatuslbl.Size = new System.Drawing.Size(208, 21);
            this.rocketstatuslbl.TabIndex = 7;
            this.rocketstatuslbl.Text = "NO STATUS RECIEVED";
            // 
            // deployButton
            // 
            this.deployButton.Enabled = false;
            this.deployButton.Location = new System.Drawing.Point(112, 469);
            this.deployButton.Name = "deployButton";
            this.deployButton.Size = new System.Drawing.Size(113, 23);
            this.deployButton.TabIndex = 13;
            this.deployButton.Text = "Deploy Drogue";
            this.deployButton.UseVisualStyleBackColor = true;
            this.deployButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // parachuteTextBox
            // 
            this.parachuteTextBox.Enabled = false;
            this.parachuteTextBox.Location = new System.Drawing.Point(27, 471);
            this.parachuteTextBox.Name = "parachuteTextBox";
            this.parachuteTextBox.Size = new System.Drawing.Size(75, 20);
            this.parachuteTextBox.TabIndex = 14;
            this.parachuteTextBox.TextChanged += new System.EventHandler(this.parachuteTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gpsAltlbl);
            this.panel1.Controls.Add(this.satNumlbl);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.calcvelocitylbl);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.filtaltlbl);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.airpressurelbl);
            this.panel1.Controls.Add(this.altitudelbl);
            this.panel1.Controls.Add(this.maxAltitudelbl);
            this.panel1.Controls.Add(this.gpsLonglbl);
            this.panel1.Controls.Add(this.gpsLatlbl);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.velocityZlbl);
            this.panel1.Controls.Add(this.velocityYlbl);
            this.panel1.Controls.Add(this.velocityXlbl);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.accelerationZlbl);
            this.panel1.Controls.Add(this.accelerationYlbl);
            this.panel1.Controls.Add(this.accelerationXlbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(363, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 429);
            this.panel1.TabIndex = 15;
            // 
            // gpsAltlbl
            // 
            this.gpsAltlbl.AutoSize = true;
            this.gpsAltlbl.BackColor = System.Drawing.Color.Transparent;
            this.gpsAltlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpsAltlbl.ForeColor = System.Drawing.Color.Lime;
            this.gpsAltlbl.Location = new System.Drawing.Point(195, 208);
            this.gpsAltlbl.Name = "gpsAltlbl";
            this.gpsAltlbl.Size = new System.Drawing.Size(120, 21);
            this.gpsAltlbl.TabIndex = 35;
            this.gpsAltlbl.Text = "GPS Alt: 0";
            // 
            // satNumlbl
            // 
            this.satNumlbl.AutoSize = true;
            this.satNumlbl.BackColor = System.Drawing.Color.Transparent;
            this.satNumlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satNumlbl.ForeColor = System.Drawing.Color.Lime;
            this.satNumlbl.Location = new System.Drawing.Point(195, 176);
            this.satNumlbl.Name = "satNumlbl";
            this.satNumlbl.Size = new System.Drawing.Size(153, 21);
            this.satNumlbl.TabIndex = 34;
            this.satNumlbl.Text = "Sat Number: 0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(-12, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Calc Velocity(m/s):";
            // 
            // calcvelocitylbl
            // 
            this.calcvelocitylbl.AutoSize = true;
            this.calcvelocitylbl.BackColor = System.Drawing.Color.Transparent;
            this.calcvelocitylbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcvelocitylbl.ForeColor = System.Drawing.Color.Lime;
            this.calcvelocitylbl.Location = new System.Drawing.Point(207, 370);
            this.calcvelocitylbl.Name = "calcvelocitylbl";
            this.calcvelocitylbl.Size = new System.Drawing.Size(21, 21);
            this.calcvelocitylbl.TabIndex = 32;
            this.calcvelocitylbl.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(-1, 309);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(208, 21);
            this.label19.TabIndex = 31;
            this.label19.Text = "Filt Altitude(ft):";
            // 
            // filtaltlbl
            // 
            this.filtaltlbl.AutoSize = true;
            this.filtaltlbl.BackColor = System.Drawing.Color.Transparent;
            this.filtaltlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtaltlbl.ForeColor = System.Drawing.Color.Lime;
            this.filtaltlbl.Location = new System.Drawing.Point(207, 309);
            this.filtaltlbl.Name = "filtaltlbl";
            this.filtaltlbl.Size = new System.Drawing.Size(21, 21);
            this.filtaltlbl.TabIndex = 30;
            this.filtaltlbl.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(-1, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 21);
            this.label15.TabIndex = 29;
            this.label15.Text = "Air pressure(hPa):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(54, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "Altitude(ft):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(10, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Max altitude(ft):";
            // 
            // airpressurelbl
            // 
            this.airpressurelbl.AutoSize = true;
            this.airpressurelbl.BackColor = System.Drawing.Color.Transparent;
            this.airpressurelbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airpressurelbl.ForeColor = System.Drawing.Color.Lime;
            this.airpressurelbl.Location = new System.Drawing.Point(207, 338);
            this.airpressurelbl.Name = "airpressurelbl";
            this.airpressurelbl.Size = new System.Drawing.Size(21, 21);
            this.airpressurelbl.TabIndex = 26;
            this.airpressurelbl.Text = "0";
            // 
            // altitudelbl
            // 
            this.altitudelbl.AutoSize = true;
            this.altitudelbl.BackColor = System.Drawing.Color.Transparent;
            this.altitudelbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudelbl.ForeColor = System.Drawing.Color.Lime;
            this.altitudelbl.Location = new System.Drawing.Point(207, 280);
            this.altitudelbl.Name = "altitudelbl";
            this.altitudelbl.Size = new System.Drawing.Size(21, 21);
            this.altitudelbl.TabIndex = 25;
            this.altitudelbl.Text = "0";
            // 
            // maxAltitudelbl
            // 
            this.maxAltitudelbl.AutoSize = true;
            this.maxAltitudelbl.BackColor = System.Drawing.Color.Transparent;
            this.maxAltitudelbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAltitudelbl.ForeColor = System.Drawing.Color.Lime;
            this.maxAltitudelbl.Location = new System.Drawing.Point(207, 251);
            this.maxAltitudelbl.Name = "maxAltitudelbl";
            this.maxAltitudelbl.Size = new System.Drawing.Size(21, 21);
            this.maxAltitudelbl.TabIndex = 24;
            this.maxAltitudelbl.Text = "0";
            // 
            // gpsLonglbl
            // 
            this.gpsLonglbl.AutoSize = true;
            this.gpsLonglbl.BackColor = System.Drawing.Color.Transparent;
            this.gpsLonglbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpsLonglbl.ForeColor = System.Drawing.Color.Lime;
            this.gpsLonglbl.Location = new System.Drawing.Point(3, 208);
            this.gpsLonglbl.Name = "gpsLonglbl";
            this.gpsLonglbl.Size = new System.Drawing.Size(87, 21);
            this.gpsLonglbl.TabIndex = 18;
            this.gpsLonglbl.Text = "Long: 0";
            // 
            // gpsLatlbl
            // 
            this.gpsLatlbl.AutoSize = true;
            this.gpsLatlbl.BackColor = System.Drawing.Color.Transparent;
            this.gpsLatlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpsLatlbl.ForeColor = System.Drawing.Color.Lime;
            this.gpsLatlbl.Location = new System.Drawing.Point(3, 176);
            this.gpsLatlbl.Name = "gpsLatlbl";
            this.gpsLatlbl.Size = new System.Drawing.Size(87, 21);
            this.gpsLatlbl.TabIndex = 17;
            this.gpsLatlbl.Text = "Lati: 0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(9, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 21);
            this.label16.TabIndex = 16;
            this.label16.Text = "GPS coordinates:";
            // 
            // velocityZlbl
            // 
            this.velocityZlbl.AutoSize = true;
            this.velocityZlbl.BackColor = System.Drawing.Color.Transparent;
            this.velocityZlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityZlbl.ForeColor = System.Drawing.Color.Lime;
            this.velocityZlbl.Location = new System.Drawing.Point(243, 106);
            this.velocityZlbl.Name = "velocityZlbl";
            this.velocityZlbl.Size = new System.Drawing.Size(54, 21);
            this.velocityZlbl.TabIndex = 15;
            this.velocityZlbl.Text = "Z: 0";
            // 
            // velocityYlbl
            // 
            this.velocityYlbl.AutoSize = true;
            this.velocityYlbl.BackColor = System.Drawing.Color.Transparent;
            this.velocityYlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityYlbl.ForeColor = System.Drawing.Color.Lime;
            this.velocityYlbl.Location = new System.Drawing.Point(135, 106);
            this.velocityYlbl.Name = "velocityYlbl";
            this.velocityYlbl.Size = new System.Drawing.Size(54, 21);
            this.velocityYlbl.TabIndex = 14;
            this.velocityYlbl.Text = "Y: 0";
            // 
            // velocityXlbl
            // 
            this.velocityXlbl.AutoSize = true;
            this.velocityXlbl.BackColor = System.Drawing.Color.Transparent;
            this.velocityXlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityXlbl.ForeColor = System.Drawing.Color.Lime;
            this.velocityXlbl.Location = new System.Drawing.Point(30, 106);
            this.velocityXlbl.Name = "velocityXlbl";
            this.velocityXlbl.Size = new System.Drawing.Size(54, 21);
            this.velocityXlbl.TabIndex = 13;
            this.velocityXlbl.Text = "X: 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(9, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 21);
            this.label12.TabIndex = 12;
            this.label12.Text = "Velocity(m/s):";
            // 
            // accelerationZlbl
            // 
            this.accelerationZlbl.AutoSize = true;
            this.accelerationZlbl.BackColor = System.Drawing.Color.Transparent;
            this.accelerationZlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerationZlbl.ForeColor = System.Drawing.Color.Lime;
            this.accelerationZlbl.Location = new System.Drawing.Point(243, 44);
            this.accelerationZlbl.Name = "accelerationZlbl";
            this.accelerationZlbl.Size = new System.Drawing.Size(54, 21);
            this.accelerationZlbl.TabIndex = 11;
            this.accelerationZlbl.Text = "Z: 0";
            // 
            // accelerationYlbl
            // 
            this.accelerationYlbl.AutoSize = true;
            this.accelerationYlbl.BackColor = System.Drawing.Color.Transparent;
            this.accelerationYlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerationYlbl.ForeColor = System.Drawing.Color.Lime;
            this.accelerationYlbl.Location = new System.Drawing.Point(135, 44);
            this.accelerationYlbl.Name = "accelerationYlbl";
            this.accelerationYlbl.Size = new System.Drawing.Size(54, 21);
            this.accelerationYlbl.TabIndex = 10;
            this.accelerationYlbl.Text = "Y: 0";
            // 
            // accelerationXlbl
            // 
            this.accelerationXlbl.AutoSize = true;
            this.accelerationXlbl.BackColor = System.Drawing.Color.Transparent;
            this.accelerationXlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerationXlbl.ForeColor = System.Drawing.Color.Lime;
            this.accelerationXlbl.Location = new System.Drawing.Point(30, 44);
            this.accelerationXlbl.Name = "accelerationXlbl";
            this.accelerationXlbl.Size = new System.Drawing.Size(54, 21);
            this.accelerationXlbl.TabIndex = 9;
            this.accelerationXlbl.Text = "X: 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(9, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Acceleration(m/s^2):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(359, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sensor Data";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(23, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(318, 21);
            this.label17.TabIndex = 17;
            this.label17.Text = "Enter com port and BAUD Rate";
            // 
            // combutton
            // 
            this.combutton.Location = new System.Drawing.Point(197, 199);
            this.combutton.Name = "combutton";
            this.combutton.Size = new System.Drawing.Size(75, 23);
            this.combutton.TabIndex = 19;
            this.combutton.Text = "Connect";
            this.combutton.UseVisualStyleBackColor = true;
            this.combutton.Click += new System.EventHandler(this.combutton_Click);
            // 
            // parachuteCheckBox
            // 
            this.parachuteCheckBox.AutoSize = true;
            this.parachuteCheckBox.Enabled = false;
            this.parachuteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parachuteCheckBox.ForeColor = System.Drawing.Color.Red;
            this.parachuteCheckBox.Location = new System.Drawing.Point(27, 441);
            this.parachuteCheckBox.Name = "parachuteCheckBox";
            this.parachuteCheckBox.Size = new System.Drawing.Size(260, 24);
            this.parachuteCheckBox.TabIndex = 20;
            this.parachuteCheckBox.Text = "Enable manual parachute deploy";
            this.parachuteCheckBox.UseVisualStyleBackColor = true;
            this.parachuteCheckBox.CheckedChanged += new System.EventHandler(this.parachuteCheckBox_CheckedChanged);
            // 
            // pressureSend
            // 
            this.pressureSend.Enabled = false;
            this.pressureSend.Location = new System.Drawing.Point(103, 248);
            this.pressureSend.Name = "pressureSend";
            this.pressureSend.Size = new System.Drawing.Size(75, 23);
            this.pressureSend.TabIndex = 23;
            this.pressureSend.Text = "Send";
            this.pressureSend.UseVisualStyleBackColor = true;
            this.pressureSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Enabled = false;
            this.pressureTextBox.Location = new System.Drawing.Point(22, 249);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(80, 20);
            this.pressureTextBox.TabIndex = 22;
            this.pressureTextBox.Text = "1013.25";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(18, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Enter Sea Level Pressure(hPA)";
            // 
            // comPortCB
            // 
            this.comPortCB.FormattingEnabled = true;
            this.comPortCB.Location = new System.Drawing.Point(22, 201);
            this.comPortCB.Name = "comPortCB";
            this.comPortCB.Size = new System.Drawing.Size(80, 21);
            this.comPortCB.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Graphs of Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // unlockrocketbtn
            // 
            this.unlockrocketbtn.Location = new System.Drawing.Point(22, 384);
            this.unlockrocketbtn.Name = "unlockrocketbtn";
            this.unlockrocketbtn.Size = new System.Drawing.Size(121, 23);
            this.unlockrocketbtn.TabIndex = 26;
            this.unlockrocketbtn.Text = "Unlock Rocket";
            this.unlockrocketbtn.UseVisualStyleBackColor = true;
            this.unlockrocketbtn.Click += new System.EventHandler(this.unlockrocketbtn_Click);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.BackColor = System.Drawing.Color.Transparent;
            this.timelbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.ForeColor = System.Drawing.Color.Lime;
            this.timelbl.Location = new System.Drawing.Point(23, 528);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(98, 21);
            this.timelbl.TabIndex = 27;
            this.timelbl.Text = "Latency:";
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 1000;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // simulatelbl
            // 
            this.simulatelbl.Location = new System.Drawing.Point(22, 413);
            this.simulatelbl.Name = "simulatelbl";
            this.simulatelbl.Size = new System.Drawing.Size(121, 23);
            this.simulatelbl.TabIndex = 28;
            this.simulatelbl.Text = "Turn on Simulation";
            this.simulatelbl.UseVisualStyleBackColor = true;
            this.simulatelbl.Click += new System.EventHandler(this.simulatelbl_Click);
            // 
            // iterationlbl
            // 
            this.iterationlbl.AutoSize = true;
            this.iterationlbl.BackColor = System.Drawing.Color.Transparent;
            this.iterationlbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationlbl.ForeColor = System.Drawing.Color.Lime;
            this.iterationlbl.Location = new System.Drawing.Point(23, 508);
            this.iterationlbl.Name = "iterationlbl";
            this.iterationlbl.Size = new System.Drawing.Size(175, 21);
            this.iterationlbl.TabIndex = 29;
            this.iterationlbl.Text = "Iteration Rate:";
            // 
            // storebutton
            // 
            this.storebutton.Location = new System.Drawing.Point(128, 322);
            this.storebutton.Name = "storebutton";
            this.storebutton.Size = new System.Drawing.Size(121, 23);
            this.storebutton.TabIndex = 30;
            this.storebutton.Text = "Store Recieved Data";
            this.storebutton.UseVisualStyleBackColor = true;
            this.storebutton.Click += new System.EventHandler(this.storebutton_Click);
            // 
            // filetxt
            // 
            this.filetxt.Location = new System.Drawing.Point(22, 324);
            this.filetxt.Name = "filetxt";
            this.filetxt.Size = new System.Drawing.Size(100, 20);
            this.filetxt.TabIndex = 31;
            this.filetxt.Text = "RecievedData";
            // 
            // ratenum
            // 
            this.ratenum.Location = new System.Drawing.Point(22, 296);
            this.ratenum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ratenum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratenum.Name = "ratenum";
            this.ratenum.Size = new System.Drawing.Size(80, 20);
            this.ratenum.TabIndex = 32;
            this.ratenum.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ratenum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // recievedRateTxt
            // 
            this.recievedRateTxt.Location = new System.Drawing.Point(103, 296);
            this.recievedRateTxt.Name = "recievedRateTxt";
            this.recievedRateTxt.Size = new System.Drawing.Size(75, 23);
            this.recievedRateTxt.TabIndex = 33;
            this.recievedRateTxt.Text = "Change";
            this.recievedRateTxt.UseVisualStyleBackColor = true;
            this.recievedRateTxt.Click += new System.EventHandler(this.recievedRateTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(23, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Data Recieved Rate (ms)";
            // 
            // baudratenum
            // 
            this.baudratenum.Location = new System.Drawing.Point(108, 201);
            this.baudratenum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.baudratenum.Minimum = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            this.baudratenum.Name = "baudratenum";
            this.baudratenum.Size = new System.Drawing.Size(80, 20);
            this.baudratenum.TabIndex = 35;
            this.baudratenum.Value = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            // 
            // setAccelOffsetBtn
            // 
            this.setAccelOffsetBtn.Location = new System.Drawing.Point(149, 355);
            this.setAccelOffsetBtn.Name = "setAccelOffsetBtn";
            this.setAccelOffsetBtn.Size = new System.Drawing.Size(121, 23);
            this.setAccelOffsetBtn.TabIndex = 36;
            this.setAccelOffsetBtn.Text = "Set Acceleration Offset";
            this.setAccelOffsetBtn.UseVisualStyleBackColor = true;
            this.setAccelOffsetBtn.Click += new System.EventHandler(this.setAccelOffsetBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Graphs of Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // runtimeLbl
            // 
            this.runtimeLbl.AutoSize = true;
            this.runtimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.runtimeLbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtimeLbl.ForeColor = System.Drawing.Color.Lime;
            this.runtimeLbl.Location = new System.Drawing.Point(451, 508);
            this.runtimeLbl.Name = "runtimeLbl";
            this.runtimeLbl.Size = new System.Drawing.Size(109, 21);
            this.runtimeLbl.TabIndex = 38;
            this.runtimeLbl.Text = "Run Time:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 578);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(725, 82);
            this.listBox1.TabIndex = 39;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Deploy Main";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Rescan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // avionicsCheckbox
            // 
            this.avionicsCheckbox.AutoSize = true;
            this.avionicsCheckbox.ForeColor = System.Drawing.Color.LimeGreen;
            this.avionicsCheckbox.Location = new System.Drawing.Point(22, 555);
            this.avionicsCheckbox.Name = "avionicsCheckbox";
            this.avionicsCheckbox.Size = new System.Drawing.Size(143, 17);
            this.avionicsCheckbox.TabIndex = 42;
            this.avionicsCheckbox.Text = "Display avionics packets";
            this.avionicsCheckbox.UseVisualStyleBackColor = true;
            // 
            // noseCheckbox
            // 
            this.noseCheckbox.AutoSize = true;
            this.noseCheckbox.Checked = true;
            this.noseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noseCheckbox.ForeColor = System.Drawing.Color.LimeGreen;
            this.noseCheckbox.Location = new System.Drawing.Point(171, 555);
            this.noseCheckbox.Name = "noseCheckbox";
            this.noseCheckbox.Size = new System.Drawing.Size(154, 17);
            this.noseCheckbox.TabIndex = 43;
            this.noseCheckbox.Text = "Display nose cone packets";
            this.noseCheckbox.UseVisualStyleBackColor = true;
            // 
            // RocketGroundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(760, 672);
            this.Controls.Add(this.noseCheckbox);
            this.Controls.Add(this.avionicsCheckbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.runtimeLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.setAccelOffsetBtn);
            this.Controls.Add(this.baudratenum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recievedRateTxt);
            this.Controls.Add(this.ratenum);
            this.Controls.Add(this.filetxt);
            this.Controls.Add(this.storebutton);
            this.Controls.Add(this.iterationlbl);
            this.Controls.Add(this.simulatelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.unlockrocketbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comPortCB);
            this.Controls.Add(this.pressureSend);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.parachuteCheckBox);
            this.Controls.Add(this.combutton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parachuteTextBox);
            this.Controls.Add(this.deployButton);
            this.Controls.Add(this.gpslbl);
            this.Controls.Add(this.barometriclbl);
            this.Controls.Add(this.accelerometerlbl);
            this.Controls.Add(this.rocketstatuslbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RocketGroundControl";
            this.Text = "Ground Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratenum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudratenum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gpslbl;
        private System.Windows.Forms.Label barometriclbl;
        private System.Windows.Forms.Label accelerometerlbl;
        private System.Windows.Forms.Label rocketstatuslbl;
        private System.Windows.Forms.Button deployButton;
        private System.Windows.Forms.TextBox parachuteTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label airpressurelbl;
        private System.Windows.Forms.Label altitudelbl;
        private System.Windows.Forms.Label maxAltitudelbl;
        private System.Windows.Forms.Label gpsLonglbl;
        private System.Windows.Forms.Label gpsLatlbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label velocityZlbl;
        private System.Windows.Forms.Label velocityYlbl;
        private System.Windows.Forms.Label velocityXlbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label accelerationZlbl;
        private System.Windows.Forms.Label accelerationYlbl;
        private System.Windows.Forms.Label accelerationXlbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button combutton;
        private System.Windows.Forms.CheckBox parachuteCheckBox;
        private System.Windows.Forms.Button pressureSend;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comPortCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button unlockrocketbtn;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Button simulatelbl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label filtaltlbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label calcvelocitylbl;
        private System.Windows.Forms.Label iterationlbl;
        private System.Windows.Forms.Button storebutton;
        private System.Windows.Forms.TextBox filetxt;
        private System.Windows.Forms.NumericUpDown ratenum;
        private System.Windows.Forms.Button recievedRateTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown baudratenum;
        private System.Windows.Forms.Label satNumlbl;
        private System.Windows.Forms.Label gpsAltlbl;
        private System.Windows.Forms.Button setAccelOffsetBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label runtimeLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox avionicsCheckbox;
        private System.Windows.Forms.CheckBox noseCheckbox;

    }
}

