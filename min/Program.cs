using System.Linq;

namespace min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
           
           do
           {
                Console.WriteLine("Hello, min menn .");
                Console.WriteLine("P_ print numbers :");
                Console.WriteLine("A- add a numbers :");
                Console.WriteLine("M- display mean of the numbers :");
                Console.WriteLine("S_ display the  smallest numbers :");
                Console.WriteLine("L- display the largest numbers :");
                Console.WriteLine("Q- Quit .");
                Console.WriteLine("enter your choice :");
              ///////
              char num1=Convert.ToChar(Console.ReadLine().ToUpper());
                switch (num1)
                /////
                { 
                case  'P':
                            if(number.Count == 0 ) 
                        {
                            Console.WriteLine("[");
                            Console.WriteLine(string.Join("", number));
                            Console.WriteLine("]");


                        }
                        else
                        {
                            Console.WriteLine("[] the list is empty ...");

                        }
                            break;
                //////    
                case 'A':
                    Console.WriteLine("Enter an integer to add the list : ");


                    if (number.Count != 77777777)
                    {
                        Console.WriteLine($"  {number} added ");
                    }
                    else
                    {
                    Console.WriteLine(" in valed input .");
                    }
                    break;
                        ////
                    case 'M':

                    if( number.Count == 0)
                    {
                        Console.WriteLine("unable to calculate the mean :");
                    }
                    else
                    {
                        double total, sum, count;
                        sum= number.Sum();
                        count= number.Count();
                        total=sum/count;
                        Console.WriteLine("the mean of :" + total);
                    }
                    break;
                //////
                case 'S':

                    Console.WriteLine(" the smallest numbers :");
                    
                    if (number.Count == 0)
                    {
                        Console.WriteLine("");
                    }
                    else  
                    { 
                    int smallest=number.Min();
                        Console.WriteLine("display the  smallest numbers" + smallest);
                    }
                    break;



                case 'L':

                    Console.WriteLine("the large numbers");

                    if (number.Count == 0)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        int larglest = number.Max();
                        Console.WriteLine("display the  large numbers" + larglest);
                    }
                    break;
                //////
               
                case 'Q':   
                    
                    Console.WriteLine("good bay");
                    break;


                    default: Console.WriteLine("unknown selection , pleas try agin .");
                    break;
            }
           } while;
           


        }
    }
}
