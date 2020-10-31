using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Exam
{
    public partial class Form1 : Form
    {
        string position;
        int dataState;
        string result;
        double netAcceleration;
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> dataQueueX = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> dataQueueY = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> dataQueueZ = new ConcurrentQueue<Int32>();

        ConcurrentQueue<Int32> maxX = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> maxY = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> maxZ = new ConcurrentQueue<Int32>();

        ConcurrentQueue<Int32> avgX = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> avgY = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> avgZ = new ConcurrentQueue<Int32>();

        IDictionary<string, string> dictGestures = new Dictionary<string, string>();

        string currentGesture;
        bool flagXpos = false, flagYpos = false, flagZpos = false;
        bool flagXneg = false, flagYneg = false, flagZneg = false;
        bool flagX = false, flagY = false, flagZ = false;


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Contains code that runds when the windows form is loaded
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            updateSerial();
            addRawDataItems();
        }

        private void addRawDataItems()
        {
            comboBoxRawData.Items.Add("Complete Data");
            comboBoxRawData.Items.Add("X");
            comboBoxRawData.Items.Add("Y");
            comboBoxRawData.Items.Add("Z");
            comboBoxRawData.SelectedIndex = 0;
        }

        /// <summary>
        /// Update the serial ports connected in the combo box drop down menu
        /// </summary>
        private void updateSerial()
        {
            comboBoxCOMPorts.Items.Clear();
            comboBoxCOMPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comboBoxCOMPorts.Items.Count == 0)
                comboBoxCOMPorts.Text = "No COM ports!";
            else
                comboBoxCOMPorts.SelectedIndex = 0;
        }

        /// <summary>
        /// Select the comport from the drop down menu
        /// </summary>
        private void comboBoxCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxCOMPorts.SelectedItem.ToString();
        }

        /// <summary>
        /// Button click to connect and disconnect serial port
        /// </summary>
        private void btnDisconnectSerial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.Dispose();
                btnDisconnectSerial.Text = "Connect Serial";
            }
            else
            {
                serialPort1.Open();
                btnDisconnectSerial.Text = "Disconnect Serial";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonXpos_Click(object sender, EventArgs e)
        {
            textBoxGestureInput.Text += "+X";
        }

        private void buttonXneg_Click(object sender, EventArgs e)
        {
            textBoxGestureInput.Text += "-X";

        }

        private void buttonYpos_Click(object sender, EventArgs e)
        {
            textBoxGestureInput.Text += "+Y";

        }

        private void buttonYneg_Click(object sender, EventArgs e)
        {
            textBoxGestureInput.Text += "-Y";

        }

        private void buttonZpos_Click(object sender, EventArgs e)
        {
            textBoxGestureInput.Text += "+Z";

        }

        private void buttonZneg_Click(object sender, EventArgs e)
        {
            textBoxGestureInput.Text += "-Z";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dictGestures.Add(textBoxGestureInput.Text, textBoxGestureName.Text);
            textBoxGestures.AppendText($"{textBoxGestureName.Text}: {textBoxGestureInput.Text}" + Environment.NewLine);
            textBoxGestureInput.Text = "";
            textBoxGestureName.Text = "";
            
        }

        /// <summary>
        /// Read data recieved on the serial port
        /// and enquque it to a concurrent queue
        /// </summary>
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int newByte = 0;
            int bytesToRead;

            bytesToRead = serialPort1.BytesToRead;
            while (bytesToRead != 0)
            {
                newByte = serialPort1.ReadByte();
                //serialDataString = serialDataString + newByte.ToString() + ", ";
                dataQueue.Enqueue(newByte);
                bytesToRead = serialPort1.BytesToRead;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetectedAction_TextChanged(object sender, EventArgs e)
        {
            if(textBoxDetectedAction.Text != "")
                SystemSounds.Beep.Play();
            
        }

        /// <summary>
        ///  Code that runs everytime the timer ticks
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            double accelerationG, approximatedG;
            double approximatedNetA;
            if (serialPort1.IsOpen)
                txtBytesToRead.Text = serialPort1.BytesToRead.ToString();
            txtItemsInQueue.Text = dataQueue.Count.ToString();

            while (dataQueue.Count > 0)
            {
                if (dataQueue.TryDequeue(out int dequeuedElement))
                {
                    if(comboBoxRawData.SelectedItem.ToString() == "Complete Data" && checkBoxRawData.Checked==true)
                        txtSerialData.AppendText(" , " + dequeuedElement.ToString());
                    //Set state variable


                    if (dequeuedElement == 255)
                        dataState = 1;
                    else if (dataState == 1)
                    {
                        if (comboBoxRawData.SelectedItem.ToString() == "X" && checkBoxRawData.Checked == true)
                            txtSerialData.AppendText(" , " + dequeuedElement.ToString());
                        accelerationG = (dequeuedElement - 125) / 25.0;
                        approximatedG = Math.Round(accelerationG, 1);
                        txtAx.Text = approximatedG.ToString() + "g";
                        dataQueueX.Enqueue(dequeuedElement);
                        if (dequeuedElement > 131)
                            position = "+ X";
                        if (dequeuedElement < 118)
                            position = "- X";
                        //RecordData(dequeuedElement, dataState);
                        dataState = 2;
                        trackBarAx.Value = Convert.ToInt32(approximatedG * 5);

                        if (maxX.Count > 500)
                        {
                            maxX.TryDequeue(out int avgElement);
                            maxX.Enqueue(dequeuedElement);
                        }
                        else
                            maxX.Enqueue(dequeuedElement);

                        if (avgX.Count > 20)
                        {
                            avgX.TryDequeue(out int avgElement);
                            avgX.Enqueue(dequeuedElement);
                        }
                        else
                            avgX.Enqueue(dequeuedElement);

                        textBoxAvgX.Text = (Convert.ToDouble(maxX.Max() - 125) / 25.0).ToString();

                        if(dequeuedElement>137 && flagXpos == false && flagX == false)
                        {
                            flagX = true;
                            currentGesture += "+X";
                            flagXpos = true;
                            if (timer3.Enabled == true)
                            {
                                timer3.Stop();
                                timer3.Start();
                            }
                            else
                                timer3.Enabled = true;

                        }
                        //103
                        if (dequeuedElement <95 && flagXneg == false && flagX == false)
                        {
                            flagX = true;
                            currentGesture += "-X";
                            flagXneg = true;
                            if (timer3.Enabled == true)
                            {
                                timer3.Stop();
                                timer3.Start();
                            }
                            else
                                timer3.Enabled = true;

                        }



                    }
                    else if (dataState == 2)
                    {
                        if (comboBoxRawData.SelectedItem.ToString() == "Y" && checkBoxRawData.Checked == true)
                            txtSerialData.AppendText(" , " + dequeuedElement.ToString());
                        accelerationG = (dequeuedElement - 126) / 25.0;
                        approximatedG = Math.Round(accelerationG, 1);
                        txtAy.Text = approximatedG.ToString() + "g";
                        dataQueueY.Enqueue(dequeuedElement);
                        if (dequeuedElement > 132)
                            position = "+ Y";
                        if (dequeuedElement < 118)
                            position = "- Y";

                        //RecordData(dequeuedElement, dataState);
                        dataState = 3;
                        trackBarAy.Value = Convert.ToInt32(approximatedG * 5);

                        if (maxY.Count > 500)
                        {
                            maxY.TryDequeue(out int avgElement);
                            maxY.Enqueue(dequeuedElement);
                        }
                        else
                            maxY.Enqueue(dequeuedElement);

                        if (avgY.Count > 20)
                        {
                            avgY.TryDequeue(out int avgElement);
                            avgY.Enqueue(dequeuedElement);
                        }
                        else
                            avgY.Enqueue(dequeuedElement);

                        textBoxAvgY.Text = (Convert.ToDouble(maxY.Max() - 126) / 25.0).ToString();

                        if (dequeuedElement > 150 && flagYpos == false && flagY == false)
                        {
                            flagY = true;
                            currentGesture += "+Y";
                            flagYpos = true;
                            if(timer3.Enabled==true)
                            {
                                timer3.Stop();
                                timer3.Start();
                            }
                            else                            
                                timer3.Enabled = true;
                        }

                        if (dequeuedElement < 107 && flagYneg == false && flagY == false)
                        {
                            flagY = true;
                            currentGesture += "-Y";
                            flagYneg = true;
                            if (timer3.Enabled == true)
                            {
                                timer3.Stop();
                                timer3.Start();
                            }
                            else
                                timer3.Enabled = true;

                        }

                    }
                    else if (dataState == 3)
                    {
                        if (comboBoxRawData.SelectedItem.ToString() == "Z" && checkBoxRawData.Checked == true)
                            txtSerialData.AppendText(" , " + dequeuedElement.ToString());
                        accelerationG = (dequeuedElement - 130) / 25.0;
                        approximatedG = Math.Round(accelerationG, 1);
                        txtAz.Text = approximatedG.ToString() + "g";
                        dataQueueZ.Enqueue(dequeuedElement);
                        if (dequeuedElement > 140)
                            position = "+ Z";
                        if (dequeuedElement < 110)
                            position = "- Z";

                        //RecordData(dequeuedElement, dataState);
                        dataState = 0;
                        trackBarAz.Value = Convert.ToInt32(approximatedG * 5);

                        if (maxZ.Count > 500)
                        {
                            maxZ.TryDequeue(out int avgElement);
                            maxZ.Enqueue(dequeuedElement);
                        }
                        else
                            maxZ.Enqueue(dequeuedElement);

                        if (avgX.Count > 20)
                        {
                            avgZ.TryDequeue(out int avgElement);
                            avgZ.Enqueue(dequeuedElement);
                        }
                        else
                            avgZ.Enqueue(dequeuedElement);

                        //Display max of last 500 datapoints in g
                        textBoxAvgZ.Text = (Convert.ToDouble(maxZ.Max() - 130) / 25.0).ToString();

                        if (dequeuedElement >175 && flagZpos == false && flagZ == false)
                        {
                            //flagZ = true;
                            currentGesture += "+Z";
                            flagZpos = true;
                            if (timer3.Enabled == true)
                            {
                                timer3.Stop();
                                timer3.Start();
                            }
                            else
                                timer3.Enabled = true;

                        }

                        if (dequeuedElement < 125 && flagZneg == false && flagZ == false)
                        {
                            flagZ = true;
                            currentGesture += "-Z";
                            flagZneg = true;
                            if (timer3.Enabled == true)
                            {
                                timer3.Stop();
                                timer3.Start();
                            }
                            else
                                timer3.Enabled = true;

                        }
                        netAcceleration = Math.Sqrt(Math.Pow(((avgX.Average() - 125) / 25.0),2) + 
                                          Math.Pow(((avgY.Average() - 126) / 25.0),2) + 
                                          Math.Pow(((avgZ.Average() - 130) / 25.0),2));
                        approximatedNetA = Math.Round(netAcceleration, 1);
                        textBoxNetAcceleration.Text = approximatedNetA.ToString();
                    }
                    txtPosition.Text = position;
                    textBoxCurrentGesture.Text = currentGesture;

                    

                    checkGesture();

                }
            }
        }

        private void checkGesture()
        {
            if (dictGestures.TryGetValue(textBoxCurrentGesture.Text, out result))
            {
                textBoxDetectedAction.Text = result;

                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            flagXpos = false;
            flagYpos = false;
            flagZpos = false;
            flagXneg = false;
            flagYneg = false;
            flagZneg = false;
            flagX = false;
            flagY = false;
            flagZ = false;
            currentGesture = "";
            textBoxDetectedAction.Text = "";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkBoxSimulateKeys.Checked == true && serialPort1.IsOpen)
                simulateArrowKeys();
            else
            {
                pictureBoxRight.BackColor = Color.White;
                pictureBoxLeft.BackColor = Color.White;
                pictureBoxUp.BackColor = Color.White;
                pictureBoxDown.BackColor = Color.White;
            }

            
        }


        private void simulateArrowKeys()
        {

            if (position == "- Y")
            {

                SendKeys.SendWait("{LEFT}");
                pictureBoxRight.BackColor = Color.White;
                pictureBoxLeft.BackColor = Color.Lime;
                pictureBoxUp.BackColor = Color.White;
                pictureBoxDown.BackColor = Color.White;
            }
            else if (position == "+ Y")
            {

                SendKeys.SendWait("{RIGHT}");
                pictureBoxRight.BackColor = Color.Lime;
                pictureBoxLeft.BackColor = Color.White;
                pictureBoxUp.BackColor = Color.White;
                pictureBoxDown.BackColor = Color.White;
            }
            else if (position == "+ X")
            {
                SendKeys.SendWait("{DOWN}");
                pictureBoxRight.BackColor = Color.White;
                pictureBoxLeft.BackColor = Color.White;
                pictureBoxUp.BackColor = Color.White;
                pictureBoxDown.BackColor = Color.Lime;

            }
            else if (position == "- X")
            {
                SendKeys.SendWait("{UP}");
                pictureBoxRight.BackColor = Color.White;
                pictureBoxLeft.BackColor = Color.White;
                pictureBoxUp.BackColor = Color.Lime;
                pictureBoxDown.BackColor = Color.White;

            }



        }

    }
}


