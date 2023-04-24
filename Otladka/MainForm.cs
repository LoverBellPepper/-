using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Image = System.Net.Mime.MediaTypeNames.Image;

namespace Otladka
{
    public partial class MainForm : Form
    {
        int x = 0;
        int h = 0;
        public MainForm()
        {
            InitializeComponent();
            Picture.Load("C:\\Users\\User\\Desktop\\ImageO\\Rus.gif");
            Name.Text = "Флаг России";
            Name.Font = new Font("Times New Roman", 14, FontStyle.Italic);

        }

        private void ChangeN_Click(object sender, EventArgs e)
        {
            if (Name.Text == "Флаг России")
            {
                Name.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                Name.Text = "Флаг США";
            }
            else
            {
                Name.Font = new Font("Times New Roman", 14, FontStyle.Italic);
                Name.Text = "Флаг России";
            }
                
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (Right.Text == "Сдвинь рисунок вправо")
            {
                Picture1.Visible = true;
              Picture1.Image = Picture.Image;
              Picture.Image = null;
                Right.Text = "Сдвинуть рисунок обратно";
            
            }
            else
            {
                Picture1.Visible = false;
                Picture.Image = Picture1.Image;
                Picture1.Image = null;
                Right.Text = "Сдвинь рисунок вправо";
            }
            
                
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите закрыть форму?",
                "Закрытие",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                Picture.BackColor = Color.Lavender;
                Picture1.BackColor = Color.Lavender;
                this.BackColor = Color.FromArgb(121, 181, 147);
                x = 1;
            }
            else if (x==1)
            {
                this.BackColor = Color.FromArgb(180, 180, 180);
                Picture.BackColor = this.BackColor;
                Picture1.BackColor = this.BackColor;
                x = 0;
            }
           
            
        }

        private void Mosaic_Click(object sender, EventArgs e)
        {
            
            if (Mosaic.Text == "Мозаика")
            {
                
                Picture2.Visible = true;
                Picture3.Visible = true;
                Picture4.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                
                Mosaic.Text = "Вернуть обратно";

                ChangeN.Enabled = false;
                Right.Enabled = false;
                ChangeColor.Enabled = false;
                Change.Enabled = false;

                if (Picture1.Visible == true)
                {
                    Picture2.Image = Picture1.Image;
                    Picture3.Image = Picture1.Image;
                    Picture4.Image = Picture1.Image;
                    pictureBox4.Image = Picture1.Image;
                    pictureBox5.Image = Picture1.Image;
                    pictureBox6.Image = Picture1.Image;
                    pictureBox7.Image = Picture1.Image;
                    pictureBox8.Image = Picture1.Image;
                    pictureBox9.Image = Picture1.Image;
                    pictureBox10.Image = Picture1.Image;
                    pictureBox11.Image = Picture1.Image;
                    pictureBox12.Image = Picture1.Image;
                    pictureBox13.Image = Picture1.Image;
                    pictureBox14.Image = Picture1.Image;
                    pictureBox15.Image = Picture1.Image;
                    pictureBox16.Image = Picture1.Image;
                    pictureBox17.Image = Picture1.Image;
                    pictureBox18.Image = Picture1.Image;
                    pictureBox19.Image = Picture1.Image;
                    Picture1.Image = Picture2.Image;
                    h = 0;

                   
                }
                else
                {
                    Picture1.Visible = true;
                    Picture1.Image = Picture.Image;
                    Picture2.Image = Picture.Image;
                    Picture3.Image = Picture.Image;
                    Picture4.Image = Picture.Image;
                    pictureBox4.Image = Picture.Image;
                    pictureBox5.Image = Picture.Image;
                    pictureBox6.Image = Picture.Image;
                    pictureBox7.Image = Picture.Image;
                    pictureBox8.Image = Picture.Image;
                    pictureBox9.Image = Picture.Image;
                    pictureBox10.Image = Picture.Image;
                    pictureBox11.Image = Picture.Image;
                    pictureBox12.Image = Picture.Image;
                    pictureBox13.Image = Picture.Image;
                    pictureBox14.Image = Picture.Image;
                    pictureBox15.Image = Picture.Image;
                    pictureBox16.Image = Picture.Image;
                    pictureBox17.Image = Picture.Image;
                    pictureBox18.Image = Picture.Image;
                    pictureBox19.Image = Picture.Image;

                    Picture.Image = null;
                    h = 1;
                }
                
                






            }
            else
            {
                Mosaic.Text = "Мозаика";
                if (h==1)
                {
                    Picture.Image = Picture1.Image;
                    Picture1.Visible = false;
                    h = 0;
                }
                
                Picture2.Visible = false;
                Picture3.Visible = false;
                Picture4.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;


                ChangeN.Enabled = true;
                Right.Enabled = true;
                ChangeColor.Enabled = true;
                Change.Enabled = true;
            }
               
            
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (Name.Text == "Флаг России")
            {
                if (Picture.Image == null)
                {
                    Name.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                    Name.Text = "Флаг США";
                    Picture1.Load("C:\\Users\\User\\Desktop\\ImageO\\USA.gif");

                }
                else
                {
                    Name.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                    Name.Text = "Флаг США";
                    Picture.Load("C:\\Users\\User\\Desktop\\ImageO\\USA.gif");
                }
               
            }
            else
            {
                if (Picture.Image == null)
                {
                    Name.Font = new Font("Times New Roman", 14, FontStyle.Italic);
                    Name.Text = "Флаг России";
                    Picture1.Load("C:\\Users\\User\\Desktop\\ImageO\\Rus.gif");

                }
                else
                {
                    Name.Font = new Font("Times New Roman", 14, FontStyle.Italic);
                    Name.Text = "Флаг России";
                    Picture.Load("C:\\Users\\User\\Desktop\\ImageO\\Rus.gif");
                }
                
            }
        }
    }
}
