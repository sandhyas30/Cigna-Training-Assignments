using System;

namespace Assignment
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message):base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];

            Console.WriteLine("Enter the array elements:");


            try
            {
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    if (arr[i] < 0)
                    {
                        throw new NegativeNumberException("Negative numbers are not allowed.");
                    }
                }

               
            }

            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            catch (Exception x)
            {
                Console.WriteLine($"Error:{x.Message}");
            }
            
            finally
            {
                Console.WriteLine("Elements are stored successfully.");
            }
         

        }
    }
}
