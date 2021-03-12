using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Electronic_shop
{
    public partial class Register : Form
    {
        bool MouseDown = false;
        Point LastLocation;
        public string id;
        Regex reg;
        int sayac;
        public Register()
        {
            InitializeComponent();
        }
        //Shadow//
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            sayac = 0;
            if (check_F(txtFname.Text))
            {
                sayac++;
            }
            if (check_L(txtLName.Text))
            {
                sayac++;
            }
            if (check_Phone(txtPhone.Text))
            {
                sayac++;
            }
            if (check_email(txtEmail.Text))
            {
                sayac++;
            }
            if (sayac == 4)
            {
                DAL.PL ob = new DAL.PL();
                if (txtPassword.Text == txtPassword1.Text)
                {
                    if (txtUser.Text == "" || txtFname.Text == "" || txtLName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtUser.Text == "" || txtPhone.Text == "")
                        return;
                    else
                    {
                        ob.UserCreate(txtUser.Text, txtFname.Text, txtLName.Text, txtEmail.Text, txtPassword.Text, comboType.Text, txtPhone.Text);
                        MessageBox.Show("successfully......");
                        this.Close();
                        Application.OpenForms[0].Show();
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }
            
        }
            
        public bool check_F(string text)
        {
            reg = new Regex("^[A-Za-z]+$");
            if (!reg.IsMatch(text))
            {
                txtFname.Clear();
                txtFname.PlaceholderText = "is not correct";
                txtFname.PlaceholderForeColor = Color.Red;
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public bool check_L(string text)
        {
            reg = new Regex("^[A-Za-z]+$");
            if (!reg.IsMatch(text))
            {
                txtLName.Clear();
                txtLName.PlaceholderText = "is not correct";
                txtLName.PlaceholderForeColor = Color.Red;
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool check_email(string text)
        {
            reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!reg.IsMatch(txtEmail.Text))
            {
                txtEmail.Clear();
                txtEmail.PlaceholderText = "is not correct";
                txtEmail.PlaceholderForeColor = Color.Red;
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool check_Phone(string text)
        {
            reg = new Regex(@"^\d{11,15}$");
            if (!reg.IsMatch(txtPhone.Text))
            {
                txtPhone.Clear();
                txtPhone.PlaceholderText = "is not correct";
                txtPhone.PlaceholderForeColor = Color.Red;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                DAL.PL ob = new DAL.PL();
                if (txtPassword.Text == txtPassword1.Text)
                {
                    if (txtUser.Text == "" || txtFname.Text == "" || txtLName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtUser.Text == "" || txtPhone.Text == "")
                        return;
                    else
                    {
                        ob.UpdateUser(Convert.ToInt32(id), txtUser.Text, txtFname.Text, txtLName.Text, txtEmail.Text, txtPassword.Text, comboType.Text, txtPhone.Text);
                        MessageBox.Show("update successfully......");
                        this.Close();
                        Application.OpenForms[0].Show();
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
            Cursor = Cursors.Hand;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            Cursor = Cursors.Default;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                int NewX = (Location.X - LastLocation.X) + e.X;
                int NewY = (Location.Y - LastLocation.Y) + e.Y;
                Location = new Point(NewX, NewY);
            }
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_email(txtEmail.Text);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
