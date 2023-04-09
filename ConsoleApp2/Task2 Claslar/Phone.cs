using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Task2_Claslar
{
    internal class Phone : Product
    {
        public int RAM;
        public string Color;
        public double Balance;

        public Phone(string brandName, string model, double price, double cost, int count, int ram, string color = "Black") : base(brandName, model, price, cost, count)
        {
            RAM = ram;
            Color = color;
            Balance = 0;
        }

        public void Call(int seconds)
        {

            double callCost = seconds * 0.1;
            if (Balance >= callCost)
            {
                Balance -= callCost;
                Console.WriteLine($"zeng edildi, xerciniz: {callCost}. Qalan Balansiniz: {Balance}");
            }
            else
            {
                Console.WriteLine("Balansiniz yeterli deyil.");
            }
        }
        public void Paymoney(int money)
        {
            Balance += money;
            Console.WriteLine($"Balansiniz Artirildi, Yeni balansiniz: {Balance}");

        }
    }
}
