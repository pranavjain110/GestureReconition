namespace Lab1_Exam
{
    partial class Form1
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label Ax;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label21;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label labelNetAcceleration;
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.btnDisconnectSerial = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtBytesToRead = new System.Windows.Forms.TextBox();
            this.txtItemsInQueue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAx = new System.Windows.Forms.TextBox();
            this.txtAz = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.trackBarAz = new System.Windows.Forms.TrackBar();
            this.trackBarAx = new System.Windows.Forms.TrackBar();
            this.trackBarAy = new System.Windows.Forms.TrackBar();
            this.txtSerialData = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxAvgX = new System.Windows.Forms.TextBox();
            this.textBoxAvgY = new System.Windows.Forms.TextBox();
            this.textBoxAvgZ = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxSimulateKeys = new System.Windows.Forms.CheckBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.textBoxCurrentGesture = new System.Windows.Forms.TextBox();
            this.buttonXpos = new System.Windows.Forms.Button();
            this.buttonXneg = new System.Windows.Forms.Button();
            this.buttonYpos = new System.Windows.Forms.Button();
            this.buttonYneg = new System.Windows.Forms.Button();
            this.buttonZpos = new System.Windows.Forms.Button();
            this.buttonZneg = new System.Windows.Forms.Button();
            this.textBoxGestureInput = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxGestureName = new System.Windows.Forms.TextBox();
            this.textBoxGestures = new System.Windows.Forms.TextBox();
            this.textBoxDetectedAction = new System.Windows.Forms.TextBox();
            this.comboBoxRawData = new System.Windows.Forms.ComboBox();
            this.checkBoxRawData = new System.Windows.Forms.CheckBox();
            this.textBoxNetAcceleration = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            Ax = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            labelNetAcceleration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 15);
            label1.TabIndex = 6;
            label1.Text = "Serial Bytes to Read";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(12, 81);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 15);
            label3.TabIndex = 10;
            label3.Text = "Items in Queue";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(360, 176);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(25, 18);
            label7.TabIndex = 21;
            label7.Text = "Az";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(361, 106);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(24, 18);
            label6.TabIndex = 20;
            label6.Text = "Ay";
            // 
            // Ax
            // 
            Ax.AutoSize = true;
            Ax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Ax.Location = new System.Drawing.Point(361, 43);
            Ax.Name = "Ax";
            Ax.Size = new System.Drawing.Size(24, 18);
            Ax.TabIndex = 19;
            Ax.Text = "Ax";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(508, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(232, 18);
            label2.TabIndex = 25;
            label2.Text = "Acceleration (1g = 9.80665 m/s^2)";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(439, 207);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(27, 16);
            label8.TabIndex = 28;
            label8.Text = "-6g";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(610, 207);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(15, 16);
            label9.TabIndex = 29;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(775, 207);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(23, 16);
            label10.TabIndex = 30;
            label10.Text = "6g";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(775, 72);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 16);
            label4.TabIndex = 34;
            label4.Text = "6g";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(610, 72);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(15, 16);
            label5.TabIndex = 33;
            label5.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(439, 72);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(27, 16);
            label11.TabIndex = 32;
            label11.Text = "-6g";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(775, 135);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(23, 16);
            label12.TabIndex = 38;
            label12.Text = "6g";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(610, 135);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(15, 16);
            label13.TabIndex = 37;
            label13.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(439, 135);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(27, 16);
            label14.TabIndex = 36;
            label14.Text = "-6g";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(9, 158);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(194, 15);
            label15.TabIndex = 39;
            label15.Text = "Minimum of recent 500 datapoints";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(64, 180);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(24, 18);
            label16.TabIndex = 40;
            label16.Text = "Ax";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(64, 208);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(24, 18);
            label17.TabIndex = 42;
            label17.Text = "Ay";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(64, 236);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(25, 18);
            label18.TabIndex = 44;
            label18.Text = "Az";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(12, 107);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(100, 15);
            label19.TabIndex = 46;
            label19.Text = "Position of Board";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(286, 445);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(161, 15);
            label20.TabIndex = 56;
            label20.Text = "Detected Gesture Sequence";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(12, 258);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(205, 20);
            label21.TabIndex = 65;
            label21.Text = "Enter gestures to recognize";
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOMPorts.TabIndex = 4;
            this.comboBoxCOMPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOMPorts_SelectedIndexChanged);
            // 
            // btnDisconnectSerial
            // 
            this.btnDisconnectSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectSerial.Location = new System.Drawing.Point(147, 10);
            this.btnDisconnectSerial.Name = "btnDisconnectSerial";
            this.btnDisconnectSerial.Size = new System.Drawing.Size(117, 23);
            this.btnDisconnectSerial.TabIndex = 3;
            this.btnDisconnectSerial.Text = "Connect Serial";
            this.btnDisconnectSerial.UseVisualStyleBackColor = true;
            this.btnDisconnectSerial.Click += new System.EventHandler(this.btnDisconnectSerial_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtBytesToRead
            // 
            this.txtBytesToRead.Location = new System.Drawing.Point(147, 50);
            this.txtBytesToRead.Name = "txtBytesToRead";
            this.txtBytesToRead.Size = new System.Drawing.Size(117, 20);
            this.txtBytesToRead.TabIndex = 5;
            // 
            // txtItemsInQueue
            // 
            this.txtItemsInQueue.Location = new System.Drawing.Point(147, 76);
            this.txtItemsInQueue.Name = "txtItemsInQueue";
            this.txtItemsInQueue.Size = new System.Drawing.Size(117, 20);
            this.txtItemsInQueue.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtAx
            // 
            this.txtAx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAx.Location = new System.Drawing.Point(343, 64);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(64, 22);
            this.txtAx.TabIndex = 22;
            // 
            // txtAz
            // 
            this.txtAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAz.Location = new System.Drawing.Point(343, 205);
            this.txtAz.Name = "txtAz";
            this.txtAz.Size = new System.Drawing.Size(64, 22);
            this.txtAz.TabIndex = 18;
            // 
            // txtAy
            // 
            this.txtAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAy.Location = new System.Drawing.Point(343, 127);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(64, 22);
            this.txtAy.TabIndex = 17;
            // 
            // trackBarAz
            // 
            this.trackBarAz.Location = new System.Drawing.Point(442, 178);
            this.trackBarAz.Maximum = 30;
            this.trackBarAz.Minimum = -30;
            this.trackBarAz.Name = "trackBarAz";
            this.trackBarAz.Size = new System.Drawing.Size(348, 45);
            this.trackBarAz.TabIndex = 23;
            this.trackBarAz.TickFrequency = 5;
            // 
            // trackBarAx
            // 
            this.trackBarAx.Location = new System.Drawing.Point(442, 43);
            this.trackBarAx.Maximum = 30;
            this.trackBarAx.Minimum = -30;
            this.trackBarAx.Name = "trackBarAx";
            this.trackBarAx.Size = new System.Drawing.Size(348, 45);
            this.trackBarAx.TabIndex = 31;
            this.trackBarAx.TickFrequency = 5;
            // 
            // trackBarAy
            // 
            this.trackBarAy.Location = new System.Drawing.Point(442, 106);
            this.trackBarAy.Maximum = 30;
            this.trackBarAy.Minimum = -30;
            this.trackBarAy.Name = "trackBarAy";
            this.trackBarAy.Size = new System.Drawing.Size(348, 45);
            this.trackBarAy.TabIndex = 35;
            this.trackBarAy.TickFrequency = 5;
            // 
            // txtSerialData
            // 
            this.txtSerialData.Location = new System.Drawing.Point(289, 284);
            this.txtSerialData.Multiline = true;
            this.txtSerialData.Name = "txtSerialData";
            this.txtSerialData.Size = new System.Drawing.Size(265, 142);
            this.txtSerialData.TabIndex = 8;
            // 
            // textBoxAvgX
            // 
            this.textBoxAvgX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgX.Location = new System.Drawing.Point(146, 176);
            this.textBoxAvgX.Name = "textBoxAvgX";
            this.textBoxAvgX.Size = new System.Drawing.Size(64, 22);
            this.textBoxAvgX.TabIndex = 41;
            // 
            // textBoxAvgY
            // 
            this.textBoxAvgY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgY.Location = new System.Drawing.Point(146, 204);
            this.textBoxAvgY.Name = "textBoxAvgY";
            this.textBoxAvgY.Size = new System.Drawing.Size(64, 22);
            this.textBoxAvgY.TabIndex = 43;
            // 
            // textBoxAvgZ
            // 
            this.textBoxAvgZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgZ.Location = new System.Drawing.Point(146, 232);
            this.textBoxAvgZ.Name = "textBoxAvgZ";
            this.textBoxAvgZ.Size = new System.Drawing.Size(64, 22);
            this.textBoxAvgZ.TabIndex = 45;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(147, 102);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(117, 20);
            this.txtPosition.TabIndex = 47;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBoxSimulateKeys
            // 
            this.checkBoxSimulateKeys.AutoSize = true;
            this.checkBoxSimulateKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSimulateKeys.Location = new System.Drawing.Point(600, 264);
            this.checkBoxSimulateKeys.Name = "checkBoxSimulateKeys";
            this.checkBoxSimulateKeys.Size = new System.Drawing.Size(173, 24);
            this.checkBoxSimulateKeys.TabIndex = 50;
            this.checkBoxSimulateKeys.Text = "Simulate Arrow Keys";
            this.checkBoxSimulateKeys.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.Color.White;
            this.pictureBoxRight.Image = global::Lab1_Exam.Properties.Resources.arrow;
            this.pictureBoxRight.Location = new System.Drawing.Point(721, 363);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(67, 63);
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRight.TabIndex = 51;
            this.pictureBoxRight.TabStop = false;
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.BackColor = System.Drawing.Color.White;
            this.pictureBoxUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUp.Image")));
            this.pictureBoxUp.Location = new System.Drawing.Point(655, 294);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(67, 63);
            this.pictureBoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUp.TabIndex = 52;
            this.pictureBoxUp.TabStop = false;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackColor = System.Drawing.Color.White;
            this.pictureBoxLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeft.Image")));
            this.pictureBoxLeft.Location = new System.Drawing.Point(589, 363);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(67, 63);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeft.TabIndex = 54;
            this.pictureBoxLeft.TabStop = false;
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.BackColor = System.Drawing.Color.White;
            this.pictureBoxDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDown.Image")));
            this.pictureBoxDown.Location = new System.Drawing.Point(655, 432);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(67, 63);
            this.pictureBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDown.TabIndex = 53;
            this.pictureBoxDown.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // textBoxCurrentGesture
            // 
            this.textBoxCurrentGesture.Location = new System.Drawing.Point(453, 444);
            this.textBoxCurrentGesture.Name = "textBoxCurrentGesture";
            this.textBoxCurrentGesture.Size = new System.Drawing.Size(101, 20);
            this.textBoxCurrentGesture.TabIndex = 55;
            // 
            // buttonXpos
            // 
            this.buttonXpos.Location = new System.Drawing.Point(127, 337);
            this.buttonXpos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonXpos.Name = "buttonXpos";
            this.buttonXpos.Size = new System.Drawing.Size(32, 30);
            this.buttonXpos.TabIndex = 57;
            this.buttonXpos.Text = "+X";
            this.buttonXpos.UseVisualStyleBackColor = true;
            this.buttonXpos.Click += new System.EventHandler(this.buttonXpos_Click);
            // 
            // buttonXneg
            // 
            this.buttonXneg.Location = new System.Drawing.Point(126, 373);
            this.buttonXneg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonXneg.Name = "buttonXneg";
            this.buttonXneg.Size = new System.Drawing.Size(32, 30);
            this.buttonXneg.TabIndex = 58;
            this.buttonXneg.Text = "-X";
            this.buttonXneg.UseVisualStyleBackColor = true;
            this.buttonXneg.Click += new System.EventHandler(this.buttonXneg_Click);
            // 
            // buttonYpos
            // 
            this.buttonYpos.Location = new System.Drawing.Point(180, 337);
            this.buttonYpos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonYpos.Name = "buttonYpos";
            this.buttonYpos.Size = new System.Drawing.Size(30, 30);
            this.buttonYpos.TabIndex = 59;
            this.buttonYpos.Text = "+Y";
            this.buttonYpos.UseVisualStyleBackColor = true;
            this.buttonYpos.Click += new System.EventHandler(this.buttonYpos_Click);
            // 
            // buttonYneg
            // 
            this.buttonYneg.Location = new System.Drawing.Point(180, 373);
            this.buttonYneg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonYneg.Name = "buttonYneg";
            this.buttonYneg.Size = new System.Drawing.Size(30, 30);
            this.buttonYneg.TabIndex = 60;
            this.buttonYneg.Text = "-Y";
            this.buttonYneg.UseVisualStyleBackColor = true;
            this.buttonYneg.Click += new System.EventHandler(this.buttonYneg_Click);
            // 
            // buttonZpos
            // 
            this.buttonZpos.Location = new System.Drawing.Point(230, 337);
            this.buttonZpos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZpos.Name = "buttonZpos";
            this.buttonZpos.Size = new System.Drawing.Size(34, 30);
            this.buttonZpos.TabIndex = 61;
            this.buttonZpos.Text = "+Z";
            this.buttonZpos.UseVisualStyleBackColor = true;
            this.buttonZpos.Click += new System.EventHandler(this.buttonZpos_Click);
            // 
            // buttonZneg
            // 
            this.buttonZneg.Location = new System.Drawing.Point(230, 371);
            this.buttonZneg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZneg.Name = "buttonZneg";
            this.buttonZneg.Size = new System.Drawing.Size(34, 32);
            this.buttonZneg.TabIndex = 62;
            this.buttonZneg.Text = "-Z";
            this.buttonZneg.UseVisualStyleBackColor = true;
            this.buttonZneg.Click += new System.EventHandler(this.buttonZneg_Click);
            // 
            // textBoxGestureInput
            // 
            this.textBoxGestureInput.Location = new System.Drawing.Point(144, 312);
            this.textBoxGestureInput.Name = "textBoxGestureInput";
            this.textBoxGestureInput.Size = new System.Drawing.Size(120, 20);
            this.textBoxGestureInput.TabIndex = 63;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(16, 337);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 66);
            this.buttonEnter.TabIndex = 64;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBoxGestureName
            // 
            this.textBoxGestureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGestureName.Location = new System.Drawing.Point(144, 284);
            this.textBoxGestureName.Name = "textBoxGestureName";
            this.textBoxGestureName.Size = new System.Drawing.Size(120, 22);
            this.textBoxGestureName.TabIndex = 68;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.Location = new System.Drawing.Point(13, 285);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(56, 18);
            label22.TabIndex = 67;
            label22.Text = "Name: ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(13, 308);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(78, 18);
            label23.TabIndex = 69;
            label23.Text = "Sequence:";
            // 
            // textBoxGestures
            // 
            this.textBoxGestures.Location = new System.Drawing.Point(16, 408);
            this.textBoxGestures.Multiline = true;
            this.textBoxGestures.Name = "textBoxGestures";
            this.textBoxGestures.Size = new System.Drawing.Size(248, 87);
            this.textBoxGestures.TabIndex = 70;
            // 
            // textBoxDetectedAction
            // 
            this.textBoxDetectedAction.Location = new System.Drawing.Point(453, 475);
            this.textBoxDetectedAction.Name = "textBoxDetectedAction";
            this.textBoxDetectedAction.Size = new System.Drawing.Size(101, 20);
            this.textBoxDetectedAction.TabIndex = 71;
            this.textBoxDetectedAction.TextChanged += new System.EventHandler(this.textBoxDetectedAction_TextChanged);
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.Location = new System.Drawing.Point(286, 480);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(102, 15);
            label24.TabIndex = 72;
            label24.Text = "Detected Gesture";
            // 
            // comboBoxRawData
            // 
            this.comboBoxRawData.FormattingEnabled = true;
            this.comboBoxRawData.Location = new System.Drawing.Point(433, 257);
            this.comboBoxRawData.Name = "comboBoxRawData";
            this.comboBoxRawData.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRawData.TabIndex = 73;
            this.comboBoxRawData.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxRawData
            // 
            this.checkBoxRawData.AutoSize = true;
            this.checkBoxRawData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRawData.Location = new System.Drawing.Point(289, 254);
            this.checkBoxRawData.Name = "checkBoxRawData";
            this.checkBoxRawData.Size = new System.Drawing.Size(99, 24);
            this.checkBoxRawData.TabIndex = 76;
            this.checkBoxRawData.Text = "Raw Data";
            this.checkBoxRawData.UseVisualStyleBackColor = true;
            // 
            // textBoxNetAcceleration
            // 
            this.textBoxNetAcceleration.Location = new System.Drawing.Point(147, 128);
            this.textBoxNetAcceleration.Name = "textBoxNetAcceleration";
            this.textBoxNetAcceleration.Size = new System.Drawing.Size(117, 20);
            this.textBoxNetAcceleration.TabIndex = 78;
            // 
            // labelNetAcceleration
            // 
            labelNetAcceleration.AutoSize = true;
            labelNetAcceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNetAcceleration.Location = new System.Drawing.Point(12, 133);
            labelNetAcceleration.Name = "labelNetAcceleration";
            labelNetAcceleration.Size = new System.Drawing.Size(93, 15);
            labelNetAcceleration.TabIndex = 77;
            labelNetAcceleration.Text = "Net Acceeration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 513);
            this.Controls.Add(this.textBoxNetAcceleration);
            this.Controls.Add(labelNetAcceleration);
            this.Controls.Add(this.checkBoxRawData);
            this.Controls.Add(this.comboBoxRawData);
            this.Controls.Add(label24);
            this.Controls.Add(this.textBoxDetectedAction);
            this.Controls.Add(this.textBoxGestures);
            this.Controls.Add(label23);
            this.Controls.Add(this.textBoxGestureName);
            this.Controls.Add(label22);
            this.Controls.Add(label21);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxGestureInput);
            this.Controls.Add(this.buttonZneg);
            this.Controls.Add(this.buttonZpos);
            this.Controls.Add(this.buttonYneg);
            this.Controls.Add(this.buttonYpos);
            this.Controls.Add(this.buttonXneg);
            this.Controls.Add(this.buttonXpos);
            this.Controls.Add(label20);
            this.Controls.Add(this.textBoxCurrentGesture);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxDown);
            this.Controls.Add(this.pictureBoxUp);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.checkBoxSimulateKeys);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(label19);
            this.Controls.Add(this.textBoxAvgZ);
            this.Controls.Add(label18);
            this.Controls.Add(this.textBoxAvgY);
            this.Controls.Add(label17);
            this.Controls.Add(this.textBoxAvgX);
            this.Controls.Add(label16);
            this.Controls.Add(label15);
            this.Controls.Add(label12);
            this.Controls.Add(label13);
            this.Controls.Add(label14);
            this.Controls.Add(this.trackBarAy);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label11);
            this.Controls.Add(this.trackBarAx);
            this.Controls.Add(label10);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label2);
            this.Controls.Add(this.trackBarAz);
            this.Controls.Add(this.txtAx);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(Ax);
            this.Controls.Add(this.txtAz);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.txtItemsInQueue);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtSerialData);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtBytesToRead);
            this.Controls.Add(this.comboBoxCOMPorts);
            this.Controls.Add(this.btnDisconnectSerial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.Windows.Forms.Button btnDisconnectSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtBytesToRead;
        private System.Windows.Forms.TextBox txtItemsInQueue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtAx;
        private System.Windows.Forms.TextBox txtAz;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TrackBar trackBarAz;
        private System.Windows.Forms.TrackBar trackBarAx;
        private System.Windows.Forms.TrackBar trackBarAy;
        private System.Windows.Forms.TextBox txtSerialData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxAvgX;
        private System.Windows.Forms.TextBox textBoxAvgY;
        private System.Windows.Forms.TextBox textBoxAvgZ;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBoxSimulateKeys;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox textBoxCurrentGesture;
        private System.Windows.Forms.Button buttonXpos;
        private System.Windows.Forms.Button buttonXneg;
        private System.Windows.Forms.Button buttonYpos;
        private System.Windows.Forms.Button buttonYneg;
        private System.Windows.Forms.Button buttonZpos;
        private System.Windows.Forms.Button buttonZneg;
        private System.Windows.Forms.TextBox textBoxGestureInput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxGestureName;
        private System.Windows.Forms.TextBox textBoxGestures;
        private System.Windows.Forms.TextBox textBoxDetectedAction;
        private System.Windows.Forms.ComboBox comboBoxRawData;
        private System.Windows.Forms.CheckBox checkBoxRawData;
        private System.Windows.Forms.TextBox textBoxNetAcceleration;
    }
}

