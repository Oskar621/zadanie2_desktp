using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2_desktp
{
    
    public partial class Form1 : Form
    {
        public Image pic1 = Image.FromFile(@"C:\\Users\\student\\Desktop\\asd\\1.png");
        public Image pic2 = Image.FromFile(@"C:\\Users\\student\\Desktop\\asd\\2.png");
        public Image pic3 = Image.FromFile(@"C:\\Users\\student\\Desktop\\asd\\3.png");
        public Image pic4 = Image.FromFile(@"C:\\Users\\student\\Desktop\\asd\\4.png");
        public Image pic5 = Image.FromFile(@"C:\\Users\\student\\Desktop\\asd\\5.png");
        public Image pic6 = Image.FromFile(@"C:\\Users\\student\\Desktop\\asd\\6.png");
        public Form1()
        {
            InitializeComponent();
        }

        public void Picture_generator()
        {
            Random random_number_gen = new Random();
            int random_number = random_number_gen.Next(1, 7);

            switch (random_number)
            {
                case 1:
                    verification_picture.Image = pic1;
                    break;
                case 2:
                    verification_picture.Image = pic2;
                    break;
                case 3:
                    verification_picture.Image = pic3;
                    break;
                case 4:
                    verification_picture.Image = pic4;
                    break;
                case 5:
                    verification_picture.Image = pic5;
                    break;
                case 6:
                    verification_picture.Image = pic6;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void picture_random_gen_label(object sender, EventArgs e)
        {
            Picture_generator();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Handle the default function
            Picture_generator();
        }
    }
}
