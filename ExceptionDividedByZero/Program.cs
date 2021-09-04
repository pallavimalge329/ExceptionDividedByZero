using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ExceptionDividedByZero
{
    class Program
    {
        public void Divide()
        {
            int x, y, z = 0;
            Console.WriteLine("Enter two numbers");


            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
            }



            catch (DivideByZeroException dze)
            {
                Console.WriteLine("Cannot divide by zero");
            }

            catch (FormatException fe)
            {
                Console.WriteLine("please check the values and try again");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(z);
            }
        }

            static void Main(string[] args)
            {
                Console.WriteLine("Handling System Exception ");
                DivideByZeroException obj = new DivideByZeroException();
                obj.Divide();
                Console.ReadKey();


            }
        }
    }


