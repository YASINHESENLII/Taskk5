using ConsoleApp2;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp2.Task2_Claslar;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("f90", "bmw", 90000, 1000, 10);
            product.GetInfo();
            product.Sale(3);
            Phone phone = new Phone("f90", "bmw", 90000, 1000, 10, 5);
            phone.Paymoney(5);
            phone.Call(2);


        }




    }
    public class Product
    {
        public string Id;
        public string BrandName;
        public string Model;
        public double Price;
        public double Cost;
        public double Income;
        public int Count;

        public Product(string brandName, string model, double price, double cost, int count)
        {
            
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Income = 0;
            Count = count;
            Id = BrandName.Substring(0, 2) + Model.Substring(0, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Markasi: {BrandName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Qiymeti: {Price}");
            Console.WriteLine($"Xerc: {Cost}");
            Console.WriteLine($"Baslangic Gelir: {Income}");
            Console.WriteLine($"Umumi mehsul sayi: {Count}");
        }

        public void Sale(int soldcount)
        {
            
            if (soldcount > Count)
            {
                Console.WriteLine("Kifayet qeder mehsul yoxdur");
            }

            double totalcost = soldcount * Cost;
            double totalincome = Price * soldcount;

            Income += totalincome - totalcost;
            Count -= soldcount;
            Console.WriteLine($"Qalan mehsul:{Count}");
            Console.WriteLine($"Total Gelir:{Income}");
        }
    }

}

  


