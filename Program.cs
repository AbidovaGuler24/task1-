using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Notebook notebook = new Notebook("Asus ROG", "Gaming Laptop", 0, 2500.99, 16, 512);
            notebook.Sale();
            notebook.ShowFullData();

        }
    }
    public class Product
    {
       public string Name;
       public string Description;
       public int Count;
       public bool IsStock;
       private double price;
       public double Price
        {
            get
            {
                return price;

            }
            set
            {
                if (value >= 0)
                    price = value;

            }
         }
        public Product(string name, string description, int count, double price)
        {
           

            Name = name;
            Description = description;
            Count = count;
            Price = price;
        }
        public  void Sale()
        {
            if (Count>0)
            {
                
                Console.WriteLine(" satıldı.");
            }
            else
            {
                Console.WriteLine("Məhsul yoxdur!");
            }
        }
    } 
}
