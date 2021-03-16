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
            new Settings(); 

            tmrTiempoDeJuego.Interval = 1000 / Settings.Speed;
            tmrTiempoDeJuego.Tick += updateScreen;
            tmrTiempoDeJuego.Start();

            startGame();
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
        private void movePlayer()
        { 

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
        private void die()
        {

        }

        private void updateScreen(object sender, EventArgs e)
        {
        

            if (Settings.GameOver == true)
            {

                // if the game over is true and player presses enter
                // we run the start game function

                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                //if the game is not over then the following commands will be executed

                // below the actions will probe the keys being presse by the player
                // and move the accordingly

                if (Input.KeyPress(Keys.Right) && Settings.direction != Directions.Left)
                {
                    Settings.direction = Directions.Right;
                }
                else if (Input.KeyPress(Keys.Left) && Settings.direction != Directions.Right)
                {
                    Settings.direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Up) && Settings.direction != Directions.Down)
                {
                    Settings.direction = Directions.Up;
                }
                else if (Input.KeyPress(Keys.Down) && Settings.direction != Directions.Up)
                {
                    Settings.direction = Directions.Down;
                }

                movePlayer(); // run move player function
            }

            pbFondo.Invalidate(); // refresh the picture box and update the graphics on it

        }
    }
}
