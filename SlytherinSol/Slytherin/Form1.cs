﻿using System;
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
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
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
        private void startGame()
        {
            

            lblTextoFinal.Visible = false;
            new Settings(); 
            Snake.Clear(); 
            Circle head = new Circle { X = 10, Y = 5 }; 
            Snake.Add(head); 

            lblMarcador.Text = Settings.Score.ToString();

            generateFood(); 

        }
        private void generateFood()

        {
            int maxXpos = pbFondo.Size.Width / Settings.Width;
            int maxYpos = pbFondo.Size.Height / Settings.Height;
            Random rnd = new Random();
            food = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
            
        }
        private void eat()
        {
            

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y

            };

            Snake.Add(body); 
            Settings.Score += Settings.Points;
            lblMarcador.Text = Settings.Score.ToString();
            generateFood(); 
        }
    }
}
