using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_CSharp_Röle_Kontrol_Programı
{
    public partial class Form1 : Form
    {
        string[] portlar = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (string port in portlar)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text.ToString();
            serialPort1.Open();
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
          



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                timer1.Stop();
                textBox1.Clear();
                button1.Enabled = true;
                button2.Enabled = false;
               
            }
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                serialPort1.WriteLine("3");             
            }
            else
            {
                serialPort1.WriteLine("4");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                serialPort1.WriteLine("5");
            }
            else
            {
                serialPort1.WriteLine("6");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                serialPort1.WriteLine("7");
            }
            else
            {
                serialPort1.WriteLine("8");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                serialPort1.WriteLine("9");
            }
            else
            {
                serialPort1.WriteLine("10");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                serialPort1.WriteLine("11");
            }
            else
            {
                serialPort1.WriteLine("12");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                serialPort1.WriteLine("13");
            }
            else
            {
                serialPort1.WriteLine("14");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                serialPort1.WriteLine("15");
            }
            else
            {
                serialPort1.WriteLine("16");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                serialPort1.WriteLine("17");
            }
            else
            {
                serialPort1.WriteLine("18");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                serialPort1.WriteLine("19");
            }
            else
            {
                serialPort1.WriteLine("20");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                serialPort1.WriteLine("21");
            }
            else
            {
                serialPort1.WriteLine("22");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                serialPort1.WriteLine("23");
            }
            else
            {
                serialPort1.WriteLine("24");
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            serialPort1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
        }
    }
}