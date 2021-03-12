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
    public partial class Admin : Form
    {
        bool MouseDown = false;
        Point LastLocation;
        DAL.PL ob = new DAL.PL();

        Register frm = new Register();
        public Admin()
        {
            InitializeComponent();
            DataTable tbl = new DataTable();
           
            tbl = ob.selectAll();
            guna2DataGridView1.DataSource = tbl;

            frm.comboType.Items.Add("Admin");

           
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
        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            

            
            tbl = ob.SearchUser(SearchInput.Text);
            guna2DataGridView1.DataSource = tbl;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frm.txtUser.Clear();
            frm.txtFname.Clear();
            frm.txtLName.Clear();
            frm.txtEmail.Clear();
            frm.txtPassword.Clear();
            frm.txtPassword1.Clear();
            frm.txtPhone.Clear();
            frm.comboType.SelectedItem = null;

            if (frm.btnUpdate.Visible == true)
            {
                frm.btnRegister.Visible = true;
                frm.btnUpdate.Visible = false;
            }
            else
            {
                frm.btnRegister.Visible = true;
                frm.btnUpdate.Visible = false;
            }
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if(frm.btnUpdate.Visible== true)
            {
                frm.btnRegister.Visible = false;
                frm.btnUpdate.Visible = true;
            }
            else
            {
                frm.btnRegister.Visible = false;
                frm.btnUpdate.Visible = true;
            }
            frm.id = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            

            frm.txtUser.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtFname.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtLName.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtEmail.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtPassword.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txtPassword1.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();           
            frm.comboType.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.txtPhone.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_MouseEnter(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = ob.selectAll();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ob.DeleteUser(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
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
