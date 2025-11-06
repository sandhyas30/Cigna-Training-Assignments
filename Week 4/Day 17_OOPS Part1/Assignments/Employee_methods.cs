using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Basic { get; set; }
        public double GrossSalary { get; set; }
        public double HRA { get; set; }
        public double DA { get; set; }
        public double IT { get; set; }
        public double PF{ get; set; }


        // functions or methods 
        public void GetGrossSalary()
        {
           double HRA = Basic * 0.15 ;
           double DA = Basic * 0.08 ;
           double IT = Basic * 0.10 ;
           double PF = Basic * 0.05 ;
            
           double GrossSalary = Basic + HRA + DA - IT - PF;
            Console.WriteLine("Total Gross Salary --- (Basic + (HRA (15%) + DA (8%) - IT (10%) - PF (5%))    :" + GrossSalary);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"[Employee Details] Id: {Id}, Name : {Name}, Job : {Job}, Basic Salary: {Basic} ");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {

            Employee e1 = new Employee();

            Console.WriteLine("Enter the Employee Id:");
            e1.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name :");
            e1.Name= Console.ReadLine();

            Console.WriteLine("Enter the Employee Job:");
            e1.Job = Console.ReadLine();

            Console.WriteLine("Enter the Employee Basic Salary:");
            e1.Basic = Convert.ToDouble(Console.ReadLine());


            e1.PrintDetails();

            Console.WriteLine();

            e1.GetGrossSalary();
           

            Console.ReadLine();
        }

    }
}
