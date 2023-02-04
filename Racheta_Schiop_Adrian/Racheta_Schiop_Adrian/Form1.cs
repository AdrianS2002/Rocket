using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racheta_Schiop_Adrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion
        #region .. code for Flickering ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
        bool st, dr, sus, jos,trage,miscare=false;
        int viteza = 8;
        int vitezaa;
        int vieti = 5;
        int scor=0;
      
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(trage && miscare==false)
            {
                glont.Visible = true;
                glont.Top = r.Top;
                glont.Left = r.Left + 20;
                glont.Height = 20;
                glont.Width = 20;
                miscare = true;

            }
            if(glont.Top>=0 && miscare==true)
            {
                glont.Top = glont.Top - 25;

            }
            if(glont.Top<0)
            {
                glont.Visible = false;
                miscare = false;

            }
            //miscarea rachetei
            if(st==true)
            {
                if (r.Left <= 0)
                    r.Left = r.Left + 2;
                else
                    r.Left = r.Left - viteza;
            }
            if (dr == true)
            {
                if (r.Left >= this.Width - r.Width - 3)
                    r.Left = r.Left - 2;
                else
                    r.Left = r.Left + viteza;
            }
            if(sus==true)
            {
                if (r.Top <= 0)
                    r.Top = r.Top + 2;
                else
                    r.Top = r.Top - viteza;
            }
            if(jos==true)
            {
                if (r.Top >= this.Height - r.Height - 40)
                    r.Top = r.Top - 2;
                else
                    r.Top = r.Top + viteza;
            }
            //miscarea asteroidului
            foreach (Control x in this.Controls)
            {
                
                if ((string)x.Tag == "asteroizi")
                {
                    if (r.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        vieti--;
                        lbl_vieti.Text = Convert.ToString(vieti);
                        sus = false;
                        x.Top=0;
                    }
                    if(x.Bounds.IntersectsWith(glont.Bounds) && glont.Visible == true)
                    {
                        glont.Top = x.Top - glont.Height;
                        x.Visible = false;
                        x.Top = this.Height + 100;
                        scor++;
                        lbl_scor.Text = Convert.ToString(scor);
                        if(scor==10)
                        {
                            timer1.Enabled = false;
                            MessageBox.Show("AȚI CÂȘTIGAT!");
                            Application.Exit();
                        }
                    }
                    if (vieti <= 0)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("AȚI PIERDUT!");

                    }

                    if (x.Top <= this.Height)
                    {
                        Random va = new Random();
                        vitezaa = va.Next(5, 15);
                        x.Top = x.Top + vitezaa;
                    }
                    else
                    {
                        Random nr = new Random();
                        int xa = nr.Next(1, 400);
                        int ya = nr.Next(80, 190);
                        int dimo = nr.Next(38, 90);//dim pe orizontala
                        int dimv = nr.Next(25, 90);//dim pe verticala
                        x.Width = dimo;
                        x.Height = dimv;
                        x.Top = -ya;
                        x.Left = xa;
                        x.Visible = true;
                    }
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = true;
            if (e.KeyCode == Keys.Right)
                dr = true;
            if (e.KeyCode == Keys.Up)
                sus = true;
            if (e.KeyCode == Keys.Down)
                jos = true;
            if (e.KeyCode == Keys.Space)
                trage = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = false;
            if (e.KeyCode == Keys.Right)
                dr = false;
            if (e.KeyCode == Keys.Up)
                sus = false;
            if (e.KeyCode == Keys.Down)
                jos = false;
            if (e.KeyCode == Keys.Space)
                trage = false;
        }
    }
}
