// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Variables
        Color bg = new Color(0, 161, 224);
        Color frogGreen = new Color(140, 240, 110);
        Color frogPink = new Color(255, 170, 150);
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Get That Frog!");
            Window.SetSize(800, 600);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Resest Background
            Window.ClearBackground(bg);

            //Prepare drawing variables
            float x = Input.GetMouseX();
            float y = Input.GetMouseY();

            // Draw a frog at the mouse position
            DrawFrog(x, y, frogGreen, frogPink);

        }
        void DrawFrog(float x, float y, Color skin, Color cheek)
        {
            // Implementation for drawing the frog
            Draw.LineSize = 0;
            // Draw the body and eyes
            Draw.FillColor = skin;
            Draw.Circle(x - 25, y - 70, 23);
            Draw.Circle(x + 25, y - 70, 23);
            Draw.Capsule(x - 50, y - 40, x + 50, y - 40, 25);

            // draw Feet
            Draw.Square(x - 20, y - 15, 15); // Left foot
            Draw.Square(x + 05, y - 15, 15); // Right foot
            Draw.Rectangle(x - 40, y - 12, 32, 12); // Left leg
            Draw.Rectangle(x + 05, y - 12, 32, 12); // Right leg
            Draw.Circle(x - 40, y - 6, 6); // Left foot detail
            Draw.Circle(x + 39, y - 6, 6); // Right foot detail

            // Draw cheeks
            Draw.FillColor = cheek;
            Draw.Circle(x - 50, y - 40, 20);
            Draw.Circle( x + 50, y - 40, 20);

            // Draw eyes
            Draw.FillColor = Color.White;
            Draw.Circle(x - 25, y - 70, 18);
            Draw.Circle(x + 25, y - 70, 18);
            Draw.FillColor = Color.Black;
            Draw.Circle(x - 25, y - 70, 10);
            Draw.Circle(x + 25, y - 70, 10);

            // Draw mouth
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.Line(x - 15, y - 40, x, y - 25);
            Draw.Line(x, y - 25, x + 15, y - 40);

        }




    }

}
