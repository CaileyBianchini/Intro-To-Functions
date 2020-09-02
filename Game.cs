using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {

        //I am so sorry
        //this code is a mess and I apologize - Cailey




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
            if (input == 'q')
            {
                _gameOver = true;
            }
            string Name = "Bob";
            RequestName(ref Name);
            Explore();
        }


        string _playerName = "";
        
        void RequestName(ref string Name)
        {
            char input = ' ';
            
            //Console.Clear();
            //if (_playerName != "")
            //{
            //    return;
            //}

            Console.WriteLine("Name?");
            Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name);
            Console.WriteLine("Want to keep the name " + Name + "?");
            //Console.WriteLine("1. Yes");
            //Console.WriteLine("2. No");
            //Console.WriteLine("> ");
            //input = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            input = GetInput("Yes", "No", "");
            if(input == '1')
            {
                return;
            }
            if(input == '2')
            {
                Console.WriteLine("Yeah that name was pretty terrible wasn't it?");
                Console.WriteLine("Name?");
                Name = Console.ReadLine();
            }
           
            
        }

        void Explore()
        {
            string petName = "Panther";
            string petRace = "";
            char input = ' ';
            input = GetInput("Go Left", "Go Right", "You came to a fork in the road.");
            if (input == '1')
            {
                Console.WriteLine("As you were walking you heard a snap. You turn around and see a person aprroaching you with a crossbow. " +
                    "You take a step back and all of the sudden you are wipped in the air. You got trapped in a net!");
                Console.WriteLine("The bandits hold many weapons that are pointing out, all of the sudden you here a rustle and a growl. Out pops out is a panther. It looks at you then looks at the bandits and it attacks them.");
                Console.WriteLine("The panther successfully drives the bandits away. It goes up to the rope keeping the net up and with its claws it cuts it, you fall down." +
                    " It walks up to you and cuddles you. It like you and seems like the panther will follow you.");
                
                RequestName(ref petName);
                petRace = "Intelligent Plather";

                Console.WriteLine("The Panther's name: " + petName);
                Console.WriteLine("The race: " + petRace);

                Console.WriteLine("All of the sudden one of the three bandits came back. 'You killed them!' He's attacking!!");
                int playerhealth = 100;
                int enemyhealth = 50;
                //condensed of if and while
                _gameOver = StartBattle(ref playerhealth, ref enemyhealth);
                Console.WriteLine("You finish the fight and start to wonder down the road for awhile.");
            }
            if (input == '2')
            {
                Console.WriteLine("You wonder down the road for awhile.");
            }

            Console.WriteLine("You finally reached civilization!");


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

                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == '3')
                {
                    ViewStats();
                }
            }
            return input;
        }



       

       
        //public void asdf() //didn't see name
        //{
        //    RequestName();
        //    ViewStats();
        //}

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
        public void Update(ref string Name)
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
            
            RequestName(ref Name);
                Explore();
        }

        //room exploring
        void enterRoom(string roomNumber)
        {
            Console.WriteLine("You are in room " + roomNumber);
            char input = ' ';
            input = GetInput("Go forward", "Go back", "What would you like to do?");
            if(input == '1')
            {
                roomNumber = roomNumber + 1;
            }
            Console.WriteLine("You are leaving room " + roomNumber);

        }



        bool StartBattle(ref int playerhealth, ref int enemyhealth)
        {
            
            char input = ' ';
            while (playerhealth > 0 && enemyhealth > 0)
            {
                input = GetInput("Attack", "Defend", "What will you do?");
                if (input == '1')
                {

                    Console.WriteLine("You attacked and did 10 damage!");
                    enemyhealth = enemyhealth - 10;
                    Console.WriteLine("The enemy delt 5 damage!");
                    playerhealth = playerhealth - 5;

                }
                //block enemies attack
                else if(input == '2')
                {
                    Console.WriteLine("You blocked the enemy attack! Howver it's weapon nicked your arm! You were delt 1 damage!");
                    playerhealth = playerhealth - 1;
                }

                

            }
            //condensed for if and while
            return playerhealth <= 0;
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThank you for playing my game!");
        }
    }
}
