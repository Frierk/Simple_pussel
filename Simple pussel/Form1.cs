using Simple_pussel.Properties;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Versioning;
using System.Security.Cryptography;

namespace Simple_pussel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //start
        int pictureid1 = 0;
        int pictureid2 = 1;
        int pictureid3 = 2;
        int pictureid4 = 3;
        // pussel bitar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureid1 = pictureid1 + 1;
            if (pictureid1 == 1)
            {
                pictureBox1.Image = Properties.Resources.row_1_column_1;
            }
            if (pictureid1 == 2)
            {
                pictureBox1.Image = Properties.Resources.row_1_column_11;
            }
            if (pictureid1 == 3)
            {
                pictureBox1.Image = Properties.Resources.row_1_column_12;
            }
            if (pictureid1 == 4)
            {
                pictureBox1.Image = Properties.Resources.row_1_column_13;
            }
            if (pictureid1 == 5)
            {
                pictureid1 = 1;
                pictureBox1.Image = Properties.Resources.row_1_column_1;
            }
            if (pictureid1 == pictureid2 && pictureid2 == pictureid3 && pictureid3 == pictureid4)
            {
                label1.Text = "Bra jobbat!";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureid2 = pictureid2 + 1;
            if (pictureid2 == 1)
            {
                pictureBox2.Image = Properties.Resources.row_1_column_2;
            }
            if (pictureid2 == 2)
            {
                pictureBox2.Image = Properties.Resources.row_1_column_21;
            }
            if (pictureid2 == 3)
            {
                pictureBox2.Image = Properties.Resources.row_1_column_22;
            }
            if (pictureid2 == 4)
            {
                pictureBox2.Image = Properties.Resources.row_1_column_23;
            }
            if (pictureid2 == 5)
            {
                pictureid2 = 1;
                pictureBox2.Image = Properties.Resources.row_1_column_2;
            }
            if (pictureid1 == pictureid2 && pictureid2 == pictureid3 && pictureid3 == pictureid4)
            {
                label1.Text = "Bra jobbat!";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureid3 = pictureid3 + 1;
            if (pictureid3 == 1)
            {
                pictureBox3.Image = Properties.Resources.row_2_column_1;
            }
            if (pictureid3 == 2)
            {
                pictureBox3.Image = Properties.Resources.row_2_column_11;
            }
            if (pictureid3 == 3)
            {
                pictureBox3.Image = Properties.Resources.row_2_column_12;
            }
            if (pictureid3 == 4)
            {
                pictureBox3.Image = Properties.Resources.row_2_column_13;
            }
            if (pictureid3 == 5)
            {
                pictureid3 = 1;
                pictureBox3.Image = Properties.Resources.row_2_column_1;
            }
            if (pictureid1 == pictureid2 && pictureid2 == pictureid3 && pictureid3 == pictureid4)
            {
                label1.Text = "Bra jobbat!";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureid4 = pictureid4 + 1;
            if (pictureid4 == 1)
            {
                pictureBox4.Image = Properties.Resources.row_2_column_2;
            }
            if (pictureid4 == 2)
            {
                pictureBox4.Image = Properties.Resources.row_2_column_21;
            }
            if (pictureid4 == 3)
            {
                pictureBox4.Image = Properties.Resources.row_2_column_22;
            }
            if (pictureid4 == 4)
            {
                pictureBox4.Image = Properties.Resources.row_2_column_23;
            }
            if (pictureid4 == 5)
            {
                pictureid4 = 1;
                pictureBox4.Image = Properties.Resources.row_2_column_2;
            }
            if (pictureid1 == pictureid2 && pictureid2 == pictureid3 && pictureid3 == pictureid4)
            {
                label1.Text = "Bra jobbat!";
            }
            else
            {
                label1.Text = "";
            }
        }
        // stop skylten
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
        // random knappen
        private void button1_Click(object sender, EventArgs e)
        {
            pictureid1 = RandomNumberGenerator.GetInt32(1, 4);
            pictureid2 = RandomNumberGenerator.GetInt32(1, 4);
            pictureid3 = RandomNumberGenerator.GetInt32(1, 4);
            pictureid4 = RandomNumberGenerator.GetInt32(1, 4);
            if (pictureid1 == 1)
            {
                pictureBox1.Image = Properties.Resources.row_1_column_1;
            }
            if (pictureid1 == 2)
            {
                pictureBox1.Image = Properties.Resources.row_1_column_11;
            }
            if (pictureid1 == 3)
            {
                pictureBox1.Image = Properties.Resources.row_1_column_12;
            }
            if (pictureid1 == 4)
            {
                pictureBox1.Image = Properties.Resources.row_1_column_13;
            }
            if (pictureid2 == 1)
            {
                pictureBox2.Image = Properties.Resources.row_1_column_2;
            }
            if (pictureid2 == 2)
            {
                pictureBox2.Image = Properties.Resources.row_1_column_21;
            }
            if (pictureid2 == 3)
            {
                pictureBox2.Image = Properties.Resources.row_1_column_22;
            }
            if (pictureid2 == 4)
            {
                pictureBox2.Image = Properties.Resources.row_1_column_23;
            }
            if (pictureid3 == 1)
            {
                pictureBox3.Image = Properties.Resources.row_2_column_1;
            }
            if (pictureid3 == 2)
            {
                pictureBox3.Image = Properties.Resources.row_2_column_11;
            }
            if (pictureid3 == 3)
            {
                pictureBox3.Image = Properties.Resources.row_2_column_12;
            }
            if (pictureid3 == 4)
            {
                pictureBox3.Image = Properties.Resources.row_2_column_13;
            }
            if (pictureid4 == 1)
            {
                pictureBox4.Image = Properties.Resources.row_2_column_2;
            }
            if (pictureid4 == 2)
            {
                pictureBox4.Image = Properties.Resources.row_2_column_21;
            }
            if (pictureid4 == 3)
            {
                pictureBox4.Image = Properties.Resources.row_2_column_22;
            }
            if (pictureid4 == 4)
            {
                pictureBox4.Image = Properties.Resources.row_2_column_23;
            }
            if (pictureid4 == 5)
            if (pictureid1 == pictureid2 && pictureid2 == pictureid3 && pictureid3 == pictureid4)
            {
                label1.Text = "Bra jobbat!";
            }
            else
            {
                label1.Text = "";
            }
        } 
    }
}
