using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Electronic_shop.Forms
{
    public partial class AddProduct : Form
    {
        bool MouseDown = false;
        Point LastLocation;
        OpenFileDialog op = new OpenFileDialog();
        Home home = new Home();
        public AddProduct()
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

        ///////////////////////create Panel
        //public void p(string name, string description, double price, string type/*,byte[] image*/)
        //{
        //    Panel panel = new Panel();
        //    panel.Size = new Size(150, 150);
        //    panel.Location = new Point(40, 40);
        //    Label[] label = new Label[3];
        //    label[0].Text = "Name: " + name;
        //    label[0].Left = 20;
        //    label[0].Top = 20;

        //    label[1].Text = "price= " + price;
        //    label[1].Left = 20;
        //    label[1].Top = 40;

        //    label[2].Text = "type: " + type;
        //    label[2].Left = 20;
        //    label[2].Top = 60;

        //    TextBox textBox = new TextBox();
        //    textBox.TextAlign = HorizontalAlignment.Center;
        //    textBox.Size = new Size(230, 80);
        //    textBox.Multiline = true;
        //    textBox.Text = description;
        //    textBox.Location = new Point(20, 80);

        //    object[] ob = new object[] { label, textBox };
        //    panel.Controls.AddRange((Control[])ob);
        //    home.Controls.Add(panel1);
        //    //PictureBox pic = new PictureBox();
        //    //File.WriteAllBytes("d:\\image", image);
        //    //pic.Image = Image.FromFile("d:\\image");
        //}
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DAL.PL ob = new DAL.PL();
            try
            {
                ob.Add_Product(txtName.Text, txtDesc.Text, Convert.ToDouble(txtPrice.Text), comboType.Text, File.ReadAllBytes(op.FileName));
                MessageBox.Show("added succsessfully");
                //p(txtName.Text, txtDesc.Text, Convert.ToDouble(txtPrice.Text), comboType.Text);
            }
            catch
            {
                return;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            op.Filter = "İmages files|*.jpg;*.png;*.gif";
            op.InitialDirectory = "c:\\";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picİtem.Image = Image.FromFile(op.FileName);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
