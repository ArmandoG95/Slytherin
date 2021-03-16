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
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private Circle enemy = new Circle();

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
            // the key down event will trigger the change state from the Input class
            Input.changeState(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            // the key up event will trigger the change state from the Input class
            Input.changeState(e.KeyCode, false);
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            // this is where we will see the snake and its parts moving

            Graphics canvas = e.Graphics; // create a new graphics class called canvas

            if (Settings.GameOver == false)
            {
                // if the game is not over then we do the following

                Brush snakeColour; // create a new brush called snake colour

                // run a loop to check the snake parts
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        // colour the head of the snake black
                        snakeColour = Brushes.Black;
                    }
                    else
                    {
                        // the rest of the body can be green
                        snakeColour = Brushes.Green;
                    }
                    //draw snake body and head
                    canvas.FillEllipse(snakeColour,
                                        new Rectangle(
                                            Snake[i].X * Settings.Width,
                                            Snake[i].Y * Settings.Height,
                                            Settings.Width, Settings.Height
                                            ));

                    // draw food
                    canvas.FillEllipse(Brushes.Red,
                                        new Rectangle(
                                            food.X * Settings.Width,
                                            food.Y * Settings.Height,
                                            Settings.Width, Settings.Height
                                            ));
                    // draw Enemy //////
                    canvas.FillEllipse(Brushes.Blue,
                                     new Rectangle(
                                         enemy.X * Settings.Width,
                                         enemy.Y * Settings.Height,
                                         Settings.Width, Settings.Height
                                         ));
                }
            }
            else
            {
                // this part will run when the game is over
                // it will show the game over text and make the label 3 visible on the screen

                string gameOver = "Game Over \n" + "Final Score is " + Settings.Score + "\n Press enter to Restart \n";
                lblTextoFinal.Text = gameOver;
                lblTextoFinal.Visible = true;
            }
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
            // the main loop for the snake head and parts
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                // if the snake head is active 
                if (i == 0)
                {
                    // move rest of the body according to which way the head is moving
                    switch (Settings.direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                    }

                    // restrict the snake from leaving the canvas
                    int maxXpos = pbFondo.Size.Width / Settings.Width;
                    int maxYpos = pbFondo.Size.Height / Settings.Height;

                    if (
                        Snake[i].X < 0 || Snake[i].Y < 0 ||
                        Snake[i].X > maxXpos || Snake[i].Y > maxYpos
                        )
                    {
                        // end the game is snake either reaches edge of the canvas

                        die();
                    }

                    // detect collision with the body
                    // this loop will check if the snake had an collision with other body parts
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            // if so we run the die function
                            die();
                        }
                    }

                    // detect collision between snake head and food
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        //if so we run the eat function
                        eat();
                    }

                }
                else
                {
                    // if there are no collisions then we continue moving the snake and its parts
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }
        private void generateFood()

        {
            int maxXpos = pbFondo.Size.Width / Settings.Width;
            int maxYpos = pbFondo.Size.Height / Settings.Height;
            Random rnd = new Random();
            food = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };

        }

        private void moveEnemy()
        {

         
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
            // change the game over Boolean to true
            Settings.GameOver = true;
        }

        private void updateScreen(object sender, EventArgs e)
        {


            if (Settings.GameOver == true)
            {


                // si el juego ha terminado y el jugador presiona enter
                // ejecutamos la función de inicio del juego

                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                // si el juego no ha terminado, se ejecutarán los siguientes comandos

                // debajo de las acciones se probarán las teclas presionadas por el jugador
                // y mueva el en consecuencia

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

                movePlayer(); // ejecutar la función mover jugador
            }

            pbFondo.Invalidate(); // actualiza el cuadro de imagen y actualiza los gráficos en él

        }
    }
}
