using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        double Everyone_elektro = 0;
        int elektro_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                double D = Math.Sqrt((b * b) - (4 * a * c));

                double x1 = (b * (-1) + D) / (2 * a);
                double x2 = (b * (-1) - D) / (2 * a);

                label4.Text = String.Format("x1 = {0}", x1);
                label5.Text = String.Format("x2 = {0}", x2);
            }
            catch (Exception)
            {
                ;
            }
        }

        private void calc()
        {
            try
            {
                double a = double.Parse(textBox4.Text);
                double b = double.Parse(textBox5.Text);
                double c = double.Parse(textBox6.Text);

                double D = Math.Sqrt((b * b) - (4 * a * c));

                double x1 = (b * (-1) + D) / (2 * a);
                double x2 = (b * (-1) - D) / (2 * a);

                label9.Text = String.Format("x1 = {0}", x1);
                label10.Text = String.Format("x2 = {0}", x2);
            }
            catch (Exception)
            {
                ;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elektro_count++;
            Everyone_elektro += double.Parse(textBox14.Text);


            int x = hScrollBar1.Value;
            int y = vScrollBar1.Value;

            label19.Text = String.Format("Width: {0}", x);
            label20.Text = String.Format("Height: {0}", y);
            label21.Text = String.Format("AREA: {0}", x * y);

            label22.Text = String.Format("Client: {0}", elektro_count);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void calc_cf()
        {
            try
            {
                if (comboBox1.Text == "C")
                {
                    double c = double.Parse(textBox7.Text);
                    textBox8.Text = String.Format("{0}", c * 1.8 + 32);
                    label14.Text = "degrees in F";
                }
                else if (comboBox1.Text == "F")
                {
                    double f = double.Parse(textBox7.Text);
                    textBox8.Text = String.Format("{0}", (f - 32.0) * (5.0 / 9.0));
                    label14.Text = "degrees in C";
                }
            }
            catch (Exception)
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc_cf();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            calc_cf();
        }

        private void calc_metrics()
        {
            try
            {
                double x = double.Parse(textBox9.Text);

                string t1 = comboBox2.Text;
                string t2 = comboBox3.Text;

                double res = 0;

                switch (t1)
                {
                    case "feet":
                        {
                            switch (t2)
                            {
                                case "feet":
                                    {
                                        res = x * 1;
                                    }
                                    break;
                                case "yard":
                                    {
                                        res = x * 0.3333;
                                    }
                                    break;
                                case "inch":
                                    {
                                        res = x * 1.1989;
                                    }
                                    break;
                                case "mile":
                                    {
                                        res = x * 0.0001893;
                                    }
                                    break;
                            }
                        }
                        break;
                    case "yard":
                        {
                            switch (t2)
                            {
                                case "feet":
                                    {
                                        res = x * 3;
                                    }
                                    break;
                                case "yard":
                                    {
                                        res = x * 1;
                                    }
                                    break;
                                case "inch":
                                    {
                                        res = x * 3.5966;
                                    }
                                    break;
                                case "mile":
                                    {
                                        res = x * 0.0005682;
                                    }
                                    break;
                            }
                        }
                        break;
                    case "inch":
                        {
                            switch (t2)
                            {
                                case "feet":
                                    {
                                        res = x * 0.8341;
                                    }
                                    break;
                                case "yard":
                                    {
                                        res = x * 0.278;
                                    }
                                    break;
                                case "inch":
                                    {
                                        res = x * 1;
                                    }
                                    break;
                                case "mile":
                                    {
                                        res = x * 0.0001579;
                                    }
                                    break;
                            }
                        }
                        break;
                    case "mile":
                        {
                            switch (t2)
                            {
                                case "feet":
                                    {
                                        res = x * 5280;
                                    }
                                    break;
                                case "yard":
                                    {
                                        res = x * 1760;
                                    }
                                    break;
                                case "inch":
                                    {
                                        res = x * 6330;
                                    }
                                    break;
                                case "mile":
                                    {
                                        res = x * 1;
                                    }
                                    break;
                            }
                        }
                        break;
                }

                textBox10.Text = String.Format("{0}", res);
            }
            catch (Exception)
            { 
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc_metrics();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc_metrics();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            calc_metrics();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calc_metrics();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int x = hScrollBar1.Value;
            int y = vScrollBar1.Value;

            label19.Text = String.Format("Width: {0}", x);
            label20.Text = String.Format("Height: {0}", y);
            label21.Text = String.Format("AREA: {0}", x*y);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            int x = hScrollBar1.Value;
            int y = vScrollBar1.Value;

            label19.Text = String.Format("Width: {0}", x);
            label20.Text = String.Format("Height: {0}", y);
            label21.Text = String.Format("AREA: {0}", x * y);
        }

        private void label24_Click(object sender, EventArgs e)
        {
             
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {
               textBox14.Text = String.Format("{0}", (0.34 * double.Parse(textBox13.Text)));
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                textBox14.Text = String.Format("{0}", (0.44 * double.Parse(textBox13.Text)));
            }
        }

        private void novKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double diff = double.Parse(textBox12.Text) - double.Parse(textBox11.Text);
                if (diff < 0)
                    return;
                textBox13.Text = String.Format("{0}", diff);
            }
            catch(Exception)
            {
                return;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double diff = double.Parse(textBox12.Text) - double.Parse(textBox11.Text);
                if (diff < 0)
                    return;
                textBox13.Text = String.Format("{0}", diff);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                textBox14.Text = String.Format("{0}", (0.54 * double.Parse(textBox13.Text)));
            }
        }

        private void zaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This App was created by Daniel Bodurov, Trash Developer");
        }

        private void novKlientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            elektro_count++;
            Everyone_elektro += double.Parse(textBox14.Text);

            label22.Text = String.Format("Client: {0}", elektro_count);
        }

        private void izhodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Everyone_elektro += double.Parse(textBox14.Text);
            MessageBox.Show(String.Format("Total Pay of all Clients is: {0}", Everyone_elektro));

            Application.Exit();
        }
    }
}
