using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace MypersonClass
{
    public partial class MainForm : Form
    {
        //private bool nonNumberEntered = false;
        public MainForm()
        {
            InitializeComponent();
            Name.Text = "введите имя";
            Name.ForeColor = Color.Gray;
            Surname.Text = "введите фамилию";
            Surname.ForeColor = Color.Gray;

        }

        private void Name_Enter(object sender, EventArgs e)
        {
            if (Name.Text == "введите имя")
            {
                Name.Text = "";
                Name.ForeColor = Color.Black;
            }
        }
        private void Name_Leave(object sender, EventArgs e)
        {
            if (Name.Text == "")
            {
                Name.Text = "введите имя";
                Name.ForeColor = Color.Gray;
            }
        }
        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "введите фамилию")
            {
                Surname.Text = "";
                Surname.ForeColor = Color.Black;
            }
        }
        private void Surname_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "введите фамилию";
                Surname.ForeColor = Color.Gray;
            }
        }

        //private void Name_TextChanged(object sender, EventArgs e)
        //{
        //    if (((TextBox)sender).Text.Length == 1)
        //        ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
        //    ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);


        //}

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                 "Вы уверенны, что хотите закрыть форму?",
                                 "Закрытие",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }


        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < 'а' || l > 'я') && l != '\b')
            {
                e.Handled = true;
                
            }

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label1.Visible = true;

            }
            else
            {
                label1.Visible = false;
            }

            if (l >= 'a' || l <= 'z')
            {
                label3.Visible = true;
              
            }

            if (l < 'a' || l > 'z')
            {
                label3.Visible = false;
            }


        }


        private void DisplayRecord_Click(object sender, EventArgs e)
        {
            if ((Name.Text == "введите имя") || (Surname.Text == "введите фамилию"))
            {
                MessageBox.Show(
                "Поля с именем и фамилией не могут быть пустыми ",
                "Ошибка",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                Person Employee = new Person();
                DateTime DOB = dateTimePicker1.Value;
                Employee.FirstName = Name.Text;
                Employee.LastName = Surname.Text;
                int age = Employee.Age(DOB);
                if ((age < 18 && age > 0) || (age > 65))
                {
                    MessageBox.Show(
                    "Введите свою дату рождения. Дата рождения сотрудника не может быть меньше 18 и больше 65.",
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                    dateTimePicker1.Value = DateTime.Now;
                }
                else if ((age == 0) || (age < 0))
                {
                    MessageBox.Show(
                    "Введите настоящую дату рождения",
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    TextInfo text = CultureInfo.CurrentCulture.TextInfo;
                    MessageBox.Show(
                   "Новый сотрудник: " + text.ToTitleCase(Employee.LastName) + " " + text.ToTitleCase(Employee.FirstName) + " " + age + " лет.",
                   "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    Name.Text = "";
                    Surname.Text = "";
                    Name.Text = "введите имя";
                    Name.ForeColor = Color.Gray;
                    Surname.Text = "введите фамилию";
                    Surname.ForeColor = Color.Gray;
                    dateTimePicker1.Value = DateTime.Now;
                }

            }



        }


    }
}
