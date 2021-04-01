using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) //Every 1000 => 1ms we need to update the time!
        {
            label1.Text = DateTime.Now.ToString("hh:mm");
            label2.Text = DateTime.Now.ToString("ss");
            label3.Text = DateTime.Now.ToString("MMM dd yyyy");
            label4.Text = DateTime.Now.ToString("dddd");                                    //       .    <= X                     
            label2.Location = new Point(label1.Location.X + label1.Width - 20, label2.Location.Y); //|___|    |__._|  <= Width - 20   
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Color[] green = new Color[] { Color.GreenYellow, Color.Lime, Color.FromArgb(128, 255, 128), Color.FromArgb(192, 255, 192) };
            Color[] pink = new Color[] { Color.Magenta,  Color.Fuchsia, Color.FromArgb(255, 128, 128), Color.FromArgb(255, 192, 192) };
            Color[] blue = new Color[] { Color.Blue, Color.MediumBlue, Color.FromArgb(128, 128, 255), Color.FromArgb(192, 192, 255) };
            Color[] yellow = new Color[] { Color.Gold, Color.Yellow, Color.FromArgb(255, 255, 128), Color.FromArgb(255, 255, 192) };
        
                if(count == 1)
                {
                    label1.ForeColor = pink[0];
                    label2.ForeColor = pink[1];
                    label3.ForeColor = pink[2];
                    label4.ForeColor = pink[3];         
                }
                else if(count == 2)
                {
                    label1.ForeColor = blue[0];
                    label2.ForeColor = blue[1];
                    label3.ForeColor = blue[2];
                    label4.ForeColor = blue[3];
                }
                else if(count == 3)
                {
                    label1.ForeColor = yellow[0];  //nagyon zold
                    label2.ForeColor = yellow[1];   //kiváló zöld
                    label3.ForeColor = yellow[2];   //halvanyabb
                    label4.ForeColor = yellow[3]; //leghalvanyabb
                }
                else
                {
                    count = 0;
                    if (count == 0)
                    {
                        label1.ForeColor = green[0];  //nagyon zold
                        label2.ForeColor = green[1];   //kiváló zöld
                        label3.ForeColor = green[2];   //halvanyabb
                        label4.ForeColor = green[3]; //leghalvanyabb
                    }
                }
                count++;

            //switch (r.Next(1,5))
            //{
            //    case 1:
            //        for (int i = 0; i < pink.Length; i++)
            //        {
            //            label1.ForeColor = pink[0];
            //            label2.ForeColor = pink[1];
            //            label3.ForeColor = pink[2];
            //            label4.ForeColor = pink[3];
            //        }
            //        break;

            //    case 2:
            //        for (int i = 0; i < blue.Length; i++)
            //        {
            //            label1.ForeColor = blue[0];
            //            label2.ForeColor = blue[1];
            //            label3.ForeColor = blue[2];
            //            label4.ForeColor = blue[3];
            //        }
            //        break;

            //    case 3:
            //        for (int i = 0; i < green.Length; i++)
            //        {
            //            label1.ForeColor = green[0];  //nagyon zold
            //            label2.ForeColor = green[1];   //kiváló zöld
            //            label3.ForeColor = green[2];   //halvanyabb
            //            label4.ForeColor = green[3]; //leghalvanyabb
            //        }
            //        break;

            //    case 4:
            //        for (int i = 0; i < yellow.Length; i++)
            //        {
            //            label1.ForeColor = yellow[0];  //nagyon zold
            //            label2.ForeColor = yellow[1];   //kiváló zöld
            //            label3.ForeColor = yellow[2];   //halvanyabb
            //            label4.ForeColor = yellow[3]; //leghalvanyabb
            //        }
            //        break;
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
