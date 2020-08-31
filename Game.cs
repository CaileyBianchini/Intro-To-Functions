using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {

        //private bool gameOver;
        bool _gameOver = false;
        //Run the game
        public void Run()
        {
            Start();
            while (_gameOver == false)
            {
                Update();
            }
            End();    
          

        }

        //Performed once when the game begins
        //used for intizalizing varibles and to perform start up tasks that should be performed once
        public void Start()
        {
            Console.WriteLine("Welcome to Topia!!!!");
            Console.Write("> ");
            Console.ReadKey();
        }

        //Repeated until the game ends
        //used for all game logic that will repeat
        //updates images
        public void Update()
        {
            char input = ' ';
            Console.Clear();
            Console.WriteLine("\nLoading . . .");
            Console.Write("> ");
            input = Console.ReadKey().KeyChar;
            if(input == 'q')
            {
                _gameOver = true;
            }
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThank you for playing my game!");
        }
    }
}
