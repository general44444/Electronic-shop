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

        
      
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DAL.PL ob = new DAL.PL();

            byte[] img;
            MemoryStream ms = new MemoryStream();
            picİtem.Image.Save(ms, picİtem.Image.RawFormat);
            img = ms.ToArray();
            try
            {
                ob.Add_Product(txtName.Text, txtDesc.Text, Convert.ToDouble(txtPrice.Text), comboType.Text, img);
                MessageBox.Show("added succsessfully");
                
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
