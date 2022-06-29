using System;


namespace Challange_2_24th_June
{
    internal class Program
    {
        
        public static List<int> ListOfRolls = new List<int>();
        public static void Main(string[] args)   
             
        {
            
            // Variables
            string Userinput1;
            int Dicerolled;

            // Making dice Array

            while(true)
            {
                Console.WriteLine("Choose a option");
                Console.WriteLine("A. Would you like to roll die/dice?");
                Console.WriteLine("B. Get averedge sum of dice rolled");
                Console.WriteLine("C. Get the total sum of dice rolled");
                Console.WriteLine("D. Show result list of dice rolled");
                Userinput1 = Console.ReadLine().ToLower();

                // Funtion Code
                switch(Userinput1)
                {
                    case "a" :
                    {
                        Console.WriteLine("Enter the number of dice youd like to roll");
                        Dicerolled = Int32.Parse(Console.ReadLine());
                        Diceroll(Dicerolled);
                        Console.WriteLine(Dicerolled + " " + "dice has been rolled");
            
                            
                        Saveddata();

                        break;
                    }

                    case "b" :
                    {
                        Console.WriteLine("Averedge Sum of dice =  " + SumAveredge());

                        break;


                    }

                    case "c" :
                    {
                        Console.WriteLine("The total of the list is " + SumDice());
                        break;
                    }

                    case "d" :
                    {
                        Console.WriteLine("Here is a list of the dice rolled");

                            // list the rolls in rolls 
                        using (StreamWriter writer = new StreamWriter("DiceRolled.txt"))
                            foreach (int roll in ListOfRolls)
                            {
                                Console.WriteLine(roll);
                                writer.WriteLine(roll); 
                            }

                            // 

                            } 
                            
                            
                            break;

                            
                    }
                }
            }

        public static void Diceroll(int Dicerolled)
    {
        if(Dicerolled == 0 )
        {
            return;
        }
            else
        {
            for (int i = 0; i<= Dicerolled; i++ )
            {
            // Dice rolling function code
            Random DiceResult = new Random();
            int die = DiceResult.Next(1, 7);
            // add to the list 
            ListOfRolls.Add(die);
            }


        }
        
    }

    public static double SumAveredge()
    {
        // List  Averedge Summary 
        double result = (double)ListOfRolls.Sum() / ListOfRolls.Count;
        return result;
    }

            

    public static double SumDice()
    {
        double total = ListOfRolls.Sum();
        return total;
    }
            
    public static void Saveddata()
    {
        // save 
        using (StreamWriter writer = new StreamWriter("DiceRolled.txt"))

        foreach(int roll in ListOfRolls) //creating external file 
        {
            writer.WriteLine(roll);

        }


    }
}}

 


              

   
            
    