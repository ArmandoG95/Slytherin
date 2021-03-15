using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slytherin
{
    public partial class FrmSlytherin : Form
    {
        public FrmSlytherin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSlytherin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {

        }
        private void generateFood()
        {
            int maxXpos = pbCanvas.Size.Width / Settings.Width;
            int maxYpos = pbCanvas.Size.Height / Settings.Height;
            Random rnd = new Random();
            food = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
            
        }
    }
}
