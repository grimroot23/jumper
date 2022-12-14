using System;

namespace Jumper
{
    class parachute
    {
        private string lifeLine_num_1 = @"  ___  ";
        private string lifeLine_num_2 = @" /___\ ";
        private string lifeLine_num_3 = @" \   / ";
        private string lifeLine_num_4 = @"  \ /  ";
        private string lifeLine_num_5 = @"   0   ";
        private string body_torso = @"  /|\  ";
        private string body_bottom = @"  / \  ";

        public string lifeLine_num_01
        {
            get{return lifeLine_num_1;}
            set{lifeLine_num_1=value;}
        }
        public string lifeLine_num_02
        {
            get{return lifeLine_num_2;}
            set{lifeLine_num_2=value;}
        }
        public string lifeLine_num_03
        {
            get{return lifeLine_num_3;}
            set{lifeLine_num_3=value;}
        }
        public string lifeLine_num_04
        {
            get{return lifeLine_num_4;}
            set{lifeLine_num_4=value;}
        }
        public string lifeLine_num_05
        {
            get{return lifeLine_num_5;}
            set{lifeLine_num_5=value;}
        }
        public string torso
        {
            get{return body_torso;}
            set{body_torso=value;}
        }
        public string bottom
        {
            get{return body_bottom;}
            set{body_bottom=value;}
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            void showJumper(bool x, int guessesLeft)
            {
                parachute cutter = new parachute();
                string[] lives = {
                    cutter.lifeLine_num_01, 
                    cutter.lifeLine_num_02, 
                    cutter.lifeLine_num_03, 
                    cutter.lifeLine_num_04, 
                    cutter.lifeLine_num_05
                    };

                for (int i = 0;  i < lives.Length; i++)
                {
                    if (x != true)
                    {
                            if (guessesLeft == 4)
                            {
                                lives[0] = " ";
                            }
                            else if (guessesLeft == 3)
                            {
                                lives[1] = " ";
                            }
                            else if (guessesLeft == 2)
                            {
                                lives[2] = " ";
                            }
                            else if (guessesLeft == 1)
                            {
                                lives[3] = " ";
                            }
                            else if (guessesLeft == 0)
                            {
                                lives[4] = " ";
                            }
                        Console.WriteLine(lives[i]);
                    }
                    else
                    {
                        Console.WriteLine(lives[i]);
                    }   
                }
                Console.WriteLine(cutter.torso);
                Console.WriteLine(cutter.bottom);     
   
            }
            
            Console.WriteLine("Welcome to Jumper");

            string secretWord;
            string guess;
            bool rightWrong = true;
            int guessesLeft = 5;

            Console.WriteLine("Type the secret word:");
            secretWord = Console.ReadLine();
            int secWordLen = secretWord.Length;

            while (guessesLeft > 0)
            {
                Console.Write("Guess a letter of the secret word: ");
                guess = Console.ReadLine();


                for (int i = 0;  i < secWordLen; i++)
                {
                    if (guess == Convert.ToString(secretWord[i]))
                    {
                        Console.WriteLine($"Your guess '{secretWord[i]}' is correct.");
                        rightWrong = true;   
                    }
                    else
                    {
                        rightWrong = false;
                    }
                }
                
                showJumper(rightWrong, guessesLeft);

                if (rightWrong == false)
                {
                    guessesLeft--;
                }
            }
            
            
            
        }
    }
        
}
