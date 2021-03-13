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
        Panel panel = new Panel();

        bool MouseDown = false;
        Point LastLocation;
        DAL.PL ob = new DAL.PL();
        DataTable dt = new DataTable();
        public Home()
        {
            InitializeComponent();

            dt = new DataTable();
            dt = ob.SelectProducts();
            if (dt.Rows.Count > 0)
            {



                int i = 0;
                int LocX = 0;
                int LocY = 50;
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    byte[] img = (byte[])dt.Rows[x][5];
                    MemoryStream ms = new MemoryStream(img);
                    
                   
                    if (i == 3)
                    {
                        LocX = 0;
                        LocY += 370;
                        i = 0;
                    }
                    i++;
                    p(dt.Rows[x][1].ToString(), dt.Rows[x][2].ToString(), dt.Rows[x][3].ToString(), Convert.ToDouble(dt.Rows[x][4]), ms);
                    panel.Location = new Point(LocX, LocY);
                    
                    LocX += 300;
                }
            }

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

        /////////////////////create Panel
        public void p(string name, string description, string type, double price, MemoryStream image)
        {
            

            /////////////////// Labels//////////////
            
            Label label = new Label();
            Label label1 = new Label();
            Label label2 = new Label();
            label.Text = name;
            label.Left = 10;
            label.Top = 10;

            label1.Text =  price +"";
            label1.Left = 10;
            label1.Top = 30;

            label2.Text = type;
            label2.Left = 10;
            label2.Top = 50;
            /////////////////TextBox//////////////
            
            TextBox textBox = new TextBox();
            textBox.Size = new Size(250, 80);
            textBox.Multiline = true;
            textBox.Text = description;
            textBox.Location = new Point(10, 80);
            textBox.BorderStyle = BorderStyle.None;



            ////////////////PictureBox////////////

            PictureBox pic = new PictureBox();
            pic.Size = new Size(250, 150);
            pic.Location = new Point(10, 170);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = Image.FromStream(image);
            


            ////////////////Panel////////////
            panel = new Panel();
            panel.Size = new Size(270, 350);
            panel.Location = new Point(0, 80);
            panel.BackColor = Color.DodgerBlue;
            panel.Font = new Font("tahoma",10);
            panel.ForeColor = Color.White;

            panel.Controls.Add(label);
            panel.Controls.Add(label1);
            panel.Controls.Add(label2);
            panel.Controls.Add(textBox);
            panel.Controls.Add(pic);
            AllProducts.Controls.Add(panel);

        }

    }
}
