using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagy_gallery
{
    public partial class Form1 : Form
    {
        int currentIndex = 1;
        public Form1()
        {
            InitializeComponent();
            ShowImage();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if(currentIndex < 0 ) {
                currentIndex = imgaes.Length - 1;
            }
            ShowImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if(currentIndex >+imgaes.Length)
            {
                currentIndex = 0;
            }
            ShowImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ShowImage()
        {
            pictureBox1.Image = (System.Drawing.Image)imgaes[currentIndex];
        }
        private readonly object[] imgaes =
        {
            Properties.Resources.Ypv8jAkPDs8,
            Properties.Resources.kot,
            Properties.Resources.giga,
            Properties.Resources.audi
        };
    }
}
