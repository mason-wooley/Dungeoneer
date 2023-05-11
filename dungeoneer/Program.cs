using System;
using SFML.Graphics;
using SFML.Window;

namespace Dungeoneer
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.run();
        }
    }

    class Game
    {
        const int WIDTH = 640;
        const int HEIGHT = 480;
        const string TITLE = "Dungeoneer";
        private RenderWindow window;
        private VideoMode mode = new VideoMode(WIDTH, HEIGHT);

        public Game()
        {
            this.window = new RenderWindow(this.mode, TITLE);

            this.window.SetVerticalSyncEnabled(true);
            this.window.Closed += (sender, args) =>
            {
                this.window.Close();
            };
        }

        public void run()
        {
            while (this.window.IsOpen)
            {
                this.handleEvents();
                this.update();
                this.draw();
            }
        }

        private void handleEvents()
        {
            this.window.DispatchEvents();
        }

        private void update()
        {

        }

        private void draw()
        {
            this.window.Clear(Color.Blue);
            this.window.Display();
        }
    }
}