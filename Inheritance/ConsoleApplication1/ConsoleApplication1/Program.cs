using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Marksheet
    {
        protected int[] subject = new int[6];
        protected double prcnt;
        protected float avg; 
        protected string name;
        public string naam
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void Info()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("\nEnter The Marks of Subject " + (i + 1)+":");
                subject[i] = int.Parse(Console.ReadLine());
            }
        }
    }
    class percentage : Marksheet
    {
        public void average()
        {
            for (int i = 0; i < 6; i++)
            {
                avg += subject[i];   
            }
            prcnt = avg*100 / 600;
            avg = avg / 6;
        }
    }
    class display : percentage
    {
        public void result()
        {
            Console.WriteLine("\n"+name+" Percentage is: ");
            Console.Write(prcnt);
            Console.WriteLine("\nAverage of the Subjects is: ");
            Console.Write(avg + "\n");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SIR SYED SYED UNIVERSITY OF ENGINEERING AND TECHNOLOGY");
            Console.WriteLine("\nEnter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Roll No: ");
            int roll =int.Parse (Console.ReadLine());
            Console.WriteLine("\nEnter Section: ");
            string sec = Console.ReadLine();
            Console.WriteLine("\nEnter Batch: ");
            int batch = int.Parse(Console.ReadLine());
            display marks = new display();
            marks.naam = name;
            Console.WriteLine("\nEnter Department Name: ");
            string depart = Console.ReadLine();
            if (depart == "Architecture Dept." || depart == "Computer Science Dept." || depart == "Arts Dept." || depart == "Commerce Dept.")
            {
                marks.Info();
                marks.average();
                marks.result();
            }
            else
            {
                Console.WriteLine("\nInvalid Dept. Name!! ");
            }
            Console.ReadKey();

        }
    }
}