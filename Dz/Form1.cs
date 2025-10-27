using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private List<string> slovi = new List<string>
        {
            "ПК", "клава", "моник", "прога",
            "шакал", "лысый"
        };

        private int pravilno = 0;
        private int nepravilno = 0;

        public Form1()
        {
            InitializeComponent();
            labelSlova.Text = slovi[random.Next(slovi.Count)];
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxInput.Text.ToLower() == labelSlova.Text.ToLower())
                    pravilno++;
                else
                    nepravilno++;

                labelStata.Text = $"Правильных: {pravilno}  Неправильных: {nepravilno}";

                labelSlova.Text = slovi[random.Next(slovi.Count)];
                textBoxInput.Clear();
            }
        }
    }
}