using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_shop
{
    public partial class Home : Form
    {
        bool MouseDown = false;
        Point LastLocation;
        public Home()
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
            Close();
        }

        private void ManageData_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            frm.ShowDialog();
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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Forms.AddProduct frm = new Forms.AddProduct();
            frm.ShowDialog();
        }

        private void WishList_Click(object sender, EventArgs e)
        {
           Forms.WishList  frm = new Forms.WishList();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
