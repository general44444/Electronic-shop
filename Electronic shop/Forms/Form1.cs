using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_shop
{
    
    public partial class Form1 : Form
    {
        bool MouseDown = false;
        Point LastLocation;
        public Form1()
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkstate.Checked == true)
            {
                labelShowHide.Text = "Hide password";
                pichide.Visible = false;
                picShow.Visible = true;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                labelShowHide.Text = "Show password";
                pichide.Visible = true;
                picShow.Visible = false;
                txtPassword.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Enter user name");
                
            }

            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Enter user password");
            }

            DAL.PL ob = new DAL.PL();
            DataTable dt = new DataTable();
            dt = ob.Login_Verify(txtName.Text, txtPassword.Text);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][3].ToString() == "Admin")
                {
                    Home frm = new Home();        
                    frm.ShowDialog();
                }
                else if (dt.Rows[0][3].ToString() == "Trader")
                {
                    Home frm = new Home();
                    frm.label1.Text = "your type " + dt.Rows[0][3];                   
                    frm.ManageData.Visible = false;
                    frm.ShowDialog();
                }
                else if (dt.Rows[0][3].ToString() == "Client")
                {
                    Home frm = new Home();
                    frm.label1.Text = "your type " + dt.Rows[0][3];       
                    frm.AddProduct.Visible = false;
                    frm.ManageData.Visible = false;
                    frm.ShowDialog();
                }
            }
            else
            {
                
                MessageBox.Show("your name or your password is not correct");
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
           
            register.ShowDialog();
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
    }
}
