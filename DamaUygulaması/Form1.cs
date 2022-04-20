using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Image Image { get; private set; }
        Button[,] buttons = new Button[8, 8];
        int i, j;
        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0;
            int left = 0;
            for (i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Tag = i + "," + j;
                    buttons[i, j].KeyDown += Button1_Click;
                    buttons[i, j].KeyUp += Button2_Click;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
                var label1 = new Label();
                label1.Text = "vezir";
                label1.BackColor = Color.Red;
                label1.Controls.Add(buttons[2, 2]);
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] indexes = btn.Tag.ToString().Split(',');
            //MessageBox.Show(indexes[0] + "," + indexes[1]);

            int a = Int32.Parse(indexes[0]);
            int b = Int32.Parse(indexes[1]);
            var tas2 = new PictureBox();
            tas2.Image = Image.FromFile($@"C:\Users\taste\Desktop\repos\C# Uygulamaları\DamaUygulaması\DamaUygulaması\bin\Debug\tass2.png");
            buttons[a, b].Controls.Add(tas2);
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] indexes = btn.Tag.ToString().Split(',');
            //MessageBox.Show(indexes[0] + "," + indexes[1]);

            int a = Int32.Parse(indexes[0]);
            int b = Int32.Parse(indexes[1]);
            var tas = new PictureBox();
            tas.Image = Image.FromFile($@"C:\Users\taste\Desktop\repos\C# Uygulamaları\DamaUygulaması\DamaUygulaması\bin\Debug\tass1.png");
            buttons[a, b].Controls.Add(tas);
        }

    }
}




//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace DamaUygulaması
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        public Image Image { get; private set; }
//        Button[,] Num = new Button[8, 8];
//        int i, j;
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            for (int i = 0; i < 4; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    Num[i, j] = new Button();
//                    Num[i, j].Text = "Btn" + i + j;
//                    Num[i, j].Tag = i + "," + j;
//                    Num[i, j].Location = new Point(i * 80, j * 40);
//                    Num[i, j].Click += Button1_Click;
//                    this.Controls.Add(Num[i, j]);
//                }
//            }
//        }

//        private void Button1_Click(object sender, EventArgs e)
//        {
//            Button btn = sender as Button;
//            string[] indexes = btn.Tag.ToString().Split(',');
//            //in indexes[0] you've got the i index and in indexes[1] the j index
//            MessageBox.Show(indexes[0]+","+indexes[1]);
//        }
//    }
//}