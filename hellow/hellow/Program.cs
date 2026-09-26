using System;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)

        {

            /* Random random = new Random();
             bool playagain = true;
             String player;
             string computer;
             string answer;

             while(playagain)
             {
                 player = "";
                 computer = "";
                 answer = "";
                 while (player != "ROCK" && player != "PAPER" && player != "SCISSOR") {
                     Console.WriteLine("Enter ROCK , PAPER , SCISSOR: ");
                     player = Console.ReadLine();
                     player = player.ToUpper();
                 }


                 switch (random.Next(1, 4))
                 {
                     case 1:
                         computer = "ROCK";
                         break;

                     case 2:
                         computer = "PAPER";
                         break;

                     case 3:
                         computer = "SCISSOR";
                         break;
                 }

                 Console.WriteLine("Player: " + player);
                 Console.WriteLine("computer: " + computer); 

                 switch (player)
                 {
                     case "ROCK":
                         if(computer == "ROCK")
                         {
                             Console.WriteLine("it's a draw");
                         }
                         else if(computer == "PAPER"){
                             Console.WriteLine("Computer wins !");
                         }
                         else
                         {
                             Console.WriteLine("Player wins! ");
                         }
                         break;
                     case "PAPER":
                         if (computer == "ROCK")
                         {
                             Console.WriteLine("Player wins! ");
                         }
                         else if (computer == "PAPER")
                         {
                             Console.WriteLine("it's a draw");
                         }
                         else
                         {
                             Console.WriteLine("Computer wins !");

                         }
                         break;
                     case "SCISSOR":
                         if (computer == "ROCK")
                         {
                             Console.WriteLine("Computer wins ! ");
                         }
                         else if (computer == "PAPER")
                         {
                             Console.WriteLine("Player wins! ");
                         }
                         else
                         {
                             Console.WriteLine("it's a draw");
                         }
                         break;
                 }

                 Console.Write("Would u like to paly again .? (Y/N)");
                 answer = Console.ReadLine();
                 answer = answer.ToUpper();

                 if (answer == "Y")
                 {
                     playagain = true;
                 }
                 else
                 {
                     playagain = false;
                 }

             }

             Console.WriteLine("Thanks 4 playing .!");
 */

            /*      String[] cars = { "BMW" , "Mustang" , "Corvette" };

                  foreach(String car in cars )
                  {
                      Console.WriteLine(car);
                  }
            */

            // method = performance of a section opf code , whenever it's called "invoked" . 
            // benifit = let's us reuse code w/o writing it multiple times ,

            /*          String name = "shiwang";

                      singHappyBithday(name);




                      
                  }

                  static void singHappyBithday(String name)
                  {
                      Console.WriteLine("Happy bithday to u !");
                      Console.WriteLine("Happy bithday to u !");
                      Console.WriteLine("Happy bithday to u !" + name);
                      Console.WriteLine("Happy bithday to u !");
                      Console.WriteLine();


                  }
      */
            // return = what we need to return values at the the palce where the method is involked 

            /*   double x;
               double y;
               double result;

               Console.WriteLine("Enter num1 :");
               x = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("Enter num2 :");
               y = Convert.ToDouble(Console.ReadLine());

               result = Multiply( x, y);

               Console.WriteLine(result);


               }

           static double Multiply(double x , double y)
           {
              double z = x * y;
               return z;

           }
           */

            //method overloadding = methods share same name , but diffrent parameters
            // name + parameter = signature 
            // har eak method ka khud ka signature hota hai 
            // basically same name but diffrent parameter



            //params  keyword = a method parameter that takes a vcariable number of arguments .
            //                 teh parameter type must be a single - dimension array 


            // array store data statically means of fixed size

            //foreach loop -> used to iterate but is less flexible
            /* foreach (string car in cars){
              }*/

            // exception : error that occurs during execution 

            //try : try some code that ius considered "Dangerous"
            // catch : catch and handle exception when tehy occur
            // final : always runned regardless of wheather the exception is caught or not


            double x;
            double y;
            double result1;
            double result2;
            Console.WriteLine("Enter your num1 :");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your num2 :");
            y = Convert.ToDouble(Console.ReadLine());


            try
            {

               

                result1 = x * y;

                Console.WriteLine("Result : " + result1);

            }
            catch(FormatException)
            {
                Console.WriteLine("you enterd a wrong input format .");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong !!");
            }
            finally
            {
                Console.WriteLine("Thanks for using my calculator !!");
            }


            // conditional operator = used in condition assignment whweathera condition is t/f
            

            result2 = (x >= y) ? x : y;

            Console.WriteLine(result2);

            // string interpolation : allows us to insert variables into string literals 
            //                       precide a string literal with a $
            //                      {} are the palceholders

            String firstname = "Shiwang";
            String lastname = "Chandra";
            int age = 21;

            Console.WriteLine($"hellow {firstname } {lastname} ");
            Console.WriteLine($"You are {age,11} years old !!");


            // class = a bundle of realted code 
            //         can be used as a bluyeprint to ceates a  object





            Console.ReadKey();

        }

        }

    }


