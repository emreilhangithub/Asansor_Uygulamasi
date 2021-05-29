using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansor_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (lblKat.Text == "6")
            {
                if (picAsansor.Top > btnKat6.Top)
                {
                    picAsansor.Top = picAsansor.Top - 1;
                    lbl6.BackColor = Color.Green;                   
                }
                if (picAsansor.Top < btnKat6.Top)
                {
                    picAsansor.Top = picAsansor.Top + 1;
                }
            }

            if (lblKat.Text == "5")
            {
                if (picAsansor.Top > btnKat5.Top)
                {
                    picAsansor.Top = picAsansor.Top - 1;
                    lbl5.BackColor = Color.Green;                    
                }
                if (picAsansor.Top < btnKat5.Top)
                {
                    picAsansor.Top = picAsansor.Top + 1;
                    lbl5.BackColor = Color.Green;                    
                }
            }

            if (lblKat.Text == "4")
            {
                if (picAsansor.Top > btnKat4.Top)
                {
                    picAsansor.Top = picAsansor.Top - 1;
                    lbl4.BackColor = Color.Green;                   
                }
                if (picAsansor.Top < btnKat4.Top)
                {
                    picAsansor.Top = picAsansor.Top + 1;
                    lbl4.BackColor = Color.Green;                    
                }
            }

            if (lblKat.Text == "3")
            {
                if (picAsansor.Top > btnKat3.Top)
                {
                    picAsansor.Top = picAsansor.Top - 1;
                    lbl3.BackColor = Color.Green;                    
                }
                if (picAsansor.Top < btnKat3.Top)
                {
                    picAsansor.Top = picAsansor.Top + 1;
                    lbl3.BackColor = Color.Green;                   
                }
            }

            if (lblKat.Text == "2")
            {
                if(picAsansor.Top>btnKat2.Top)
                {
                    picAsansor.Top = picAsansor.Top - 1;
                    lbl2.BackColor = Color.Green;                    
                }
                if (picAsansor.Top < btnKat2.Top)
                {
                    picAsansor.Top = picAsansor.Top + 1;
                    lbl2.BackColor = Color.Green;                    
                }
            }

            if (lblKat.Text == "1")
            {
                if (picAsansor.Top > btnKat1.Top)
                {
                    picAsansor.Top = picAsansor.Top - 1;
                    lbl1.BackColor = Color.Green;                    
                }
                if (picAsansor.Top < btnKat1.Top)
                {
                    picAsansor.Top = picAsansor.Top + 1;
                    lbl1.BackColor = Color.Green;                    
                }
            }

            if (lblKat.Text == "0")
            {
                if (picAsansor.Top > btnKat0.Top)
                {
                    picAsansor.Top = picAsansor.Top - 1;                    
                }
                if (picAsansor.Top < btnKat0.Top)
                {
                    picAsansor.Top = picAsansor.Top + 1;
                    lbl0.BackColor = Color.Green;                    
                }
            }

        }       

        private void btnKat6_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblKat.Text = "6";
            btnKat6.Enabled = false;
            btnKat5.Enabled = true;
            btnKat5.Enabled = true;
            btnKat4.Enabled = true;
            btnKat3.Enabled = true;
            btnKat2.Enabled = true;
            btnKat1.Enabled = true;
            btnKat0.Enabled = true;
            lbl5.BackColor = Color.Yellow;
            lbl4.BackColor = Color.Yellow;
            lbl3.BackColor = Color.Yellow;
            lbl2.BackColor = Color.Yellow;
            lbl1.BackColor = Color.Yellow;
            lbl0.BackColor = Color.Yellow;
         }

        private void btnKat5_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            lblKat.Text = "5";
            btnKat6.Enabled = true;
            btnKat5.Enabled = false;
            btnKat5.Enabled = true;
            btnKat4.Enabled = true;
            btnKat3.Enabled = true;
            btnKat2.Enabled = true;
            btnKat1.Enabled = true;
            btnKat0.Enabled = true;
            lbl6.BackColor = Color.Yellow;
            lbl4.BackColor = Color.Yellow;
            lbl3.BackColor = Color.Yellow;
            lbl2.BackColor = Color.Yellow;
            lbl1.BackColor = Color.Yellow;
            lbl0.BackColor = Color.Yellow;
        }

        private void btnKat4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblKat.Text = "4";
            btnKat6.Enabled = true;
            btnKat5.Enabled = true;
            btnKat5.Enabled = true;
            btnKat4.Enabled = false;
            btnKat3.Enabled = true;
            btnKat2.Enabled = true;
            btnKat1.Enabled = true;
            btnKat0.Enabled = true;
            lbl6.BackColor = Color.Yellow;
            lbl5.BackColor = Color.Yellow;
            lbl3.BackColor = Color.Yellow;
            lbl2.BackColor = Color.Yellow;
            lbl1.BackColor = Color.Yellow;
            lbl0.BackColor = Color.Yellow;
        }

        private void btnKat3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblKat.Text = "3";
            btnKat6.Enabled = true;
            btnKat5.Enabled = true;
            btnKat5.Enabled = true;
            btnKat4.Enabled = true;
            btnKat3.Enabled = false;
            btnKat2.Enabled = true;
            btnKat1.Enabled = true;
            btnKat0.Enabled = true;
            lbl6.BackColor = Color.Yellow;
            lbl5.BackColor = Color.Yellow;
            lbl4.BackColor = Color.Yellow;
            lbl2.BackColor = Color.Yellow;
            lbl1.BackColor = Color.Yellow;
            lbl0.BackColor = Color.Yellow;
        }

        private void btnKat2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblKat.Text = "2";
            btnKat6.Enabled = true;
            btnKat5.Enabled = true;
            btnKat5.Enabled = true;
            btnKat4.Enabled = true;
            btnKat3.Enabled = true;
            btnKat2.Enabled = false;
            btnKat1.Enabled = true;
            btnKat0.Enabled = true;
            lbl5.BackColor = Color.Yellow;
            lbl5.BackColor = Color.Yellow;
            lbl4.BackColor = Color.Yellow;
            lbl3.BackColor = Color.Yellow;
            lbl1.BackColor = Color.Yellow;
            lbl0.BackColor = Color.Yellow;
        }

        private void btnKat1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblKat.Text = "1";
            btnKat6.Enabled = true;
            btnKat5.Enabled = true;
            btnKat5.Enabled = true;
            btnKat4.Enabled = true;
            btnKat3.Enabled = true;
            btnKat2.Enabled = true;
            btnKat1.Enabled = false;
            btnKat0.Enabled = true;
            lbl6.BackColor = Color.Yellow;
            lbl5.BackColor = Color.Yellow;
            lbl4.BackColor = Color.Yellow;
            lbl3.BackColor = Color.Yellow;
            lbl2.BackColor = Color.Yellow;
            lbl0.BackColor = Color.Yellow;
        }

        private void btnKat0_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblKat.Text = "0";
            btnKat6.Enabled = true;
            btnKat5.Enabled = true;
            btnKat5.Enabled = true;
            btnKat4.Enabled = true;
            btnKat3.Enabled = true;
            btnKat2.Enabled = true;
            btnKat1.Enabled = true;
            btnKat0.Enabled = false;
            lbl6.BackColor = Color.Yellow;
            lbl5.BackColor = Color.Yellow;
            lbl4.BackColor = Color.Yellow;
            lbl3.BackColor = Color.Yellow;
            lbl2.BackColor = Color.Yellow;
            lbl1.BackColor = Color.Yellow;            
        }
    }
}
