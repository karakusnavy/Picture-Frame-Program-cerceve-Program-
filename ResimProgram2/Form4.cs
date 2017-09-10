using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace ResimProgram2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            string secilen;
            label9.Text = Properties.Settings.Default.ileri;
            var arkaResim = Image.FromFile(Properties.Settings.Default.arkaplan);
            secilen = label9.Text;
            string onresim = Properties.Settings.Default.cerceve1;
            if (label9.Text == "1")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve1);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "2")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve2);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "3")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve3);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "4")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve4);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "5")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve5);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "6")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve6);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "7")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve7);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "8")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve8);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "9")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve9);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "10")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve10);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "11")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve11);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "12")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve12);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "13")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve13);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "14")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve14);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }
            else if (label9.Text == "15")
            {
                var eklenecekResim = Image.FromFile(Properties.Settings.Default.cerceve15);
                Graphics grafik = Graphics.FromImage(arkaResim);
                grafik.DrawImage(eklenecekResim, 0, 0, arkaResim.Width, arkaResim.Height); //25,50 değeri Point yani konum, 100,500 değeri ise Size yani boyut
                pictureBox3.Image = arkaResim;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                picRenk1.BackColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                picRenk2.BackColor = colorDialog2.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = false;
            fontDialog1.ShowEffects = true;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text = fontDialog1.Font.Name;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = "% " + trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(*.jpg)|*.jpg";
            sf.ShowDialog();
            Bitmap bmp = new Bitmap(pictureBox3.Image, 550, 550);
            pictureBox3.Image = bmp;
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;

            if (!String.IsNullOrEmpty(sf.FileName))
            {
                Graphics g = Graphics.FromImage(pictureBox3.Image);
                Brush b = new LinearGradientBrush(new Point(1, 1), new Point(100, 100), Color.FromArgb(trackBar1.Value, colorDialog1.Color), Color.FromArgb(trackBar1.Value, colorDialog2.Color));
                Point point = new Point((int)numericUpDown2.Value, (int)(numericUpDown1.Value));
                g.DrawString(textBox2.Text, fontDialog1.Font, b, point);
                pictureBox3.Image.Save(sf.FileName, ImageFormat.Jpeg);

            }

            SQLiteConnection conn = new SQLiteConnection("Data Source=karakus.sqlite;Version=3;");
            conn.Open();
            string sql1 = "insert into alanlar (adres,tarih,aciklama) values ('" + sf.FileName + "','"+DateTime.Now+"','"+textBox3.Text+"')";
            SQLiteCommand command1 = new SQLiteCommand(sql1, conn);
            command1.ExecuteNonQuery();
            MessageBox.Show("Veritabanına Eklendi ve kaydedildi. (Resmi Kaydettiğiniz Yerden Silmeyiniz)");
        }
  
 
    }
}
