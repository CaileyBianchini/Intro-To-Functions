using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
       


        string _playerName;
        
        void RequestName()
        {
            char input = ' ';
            while (input != '1')
            {
                Console.Clear();
                if (_playerName != "")
                {
                    return;
                }

                Console.WriteLine("Welcome to Topia! What is your name?");
                _playerName = Console.ReadLine();
                Console.WriteLine("Hello " + _playerName);
                Console.WriteLine("Are you sure you want your name to be: " + _playerName);
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                input = GetInput("Yes", "No", "");
                if(input == '2')
                {
                    Console.WriteLine("Yeah that name was pretty terrible wasn't it?");
                }
            }
            _gameOver = true;
        }

        char GetInput(string option1, string option2, string quiry)
        {


            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine(quiry);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. View Stats");

                Console.WriteLine("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == '3')
                {
                    ViewStats();
                }
            }
            return input;
        }

        //private bool gameOver;
        bool _gameOver = false;
        //Run the game
        public void Run()
        {
            Start();
            while (_gameOver == false)
            {
                Update();
                Explore();
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

        void Explore()
        {
            char input = ' ';
            input = GetInput("Go Left", "Go Right", "You came to a fork in the road.");
            if (input == '1')
            {
                Console.WriteLine("As you were walking you heard a snap. You turn around and see a person aprroaching you with a crossbow. " +
                    "You take a step back and all of the sudden you are wipped in the air. You got trapped in a net!");
                Console.WriteLine("- Y O U  D I E D -");
                _gameOver = true;
                
            }
            if (input == '2')
            {
                Console.WriteLine("You wonder down the road for awhile and when dawn breaks you find yourself at a village.");
            }

        }
        
        public void asdfghj() //didn't see name
        {
            RequestName();
            ViewStats();
        }

        void ViewStats()
        {
            Console.WriteLine("- Menu -");
            //invatory
            //look at stats
            Console.WriteLine(_playerName);
            Console.WriteLine("Press any key to continue.");
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
