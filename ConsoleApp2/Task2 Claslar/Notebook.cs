using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Task2_Claslar
{
    internal class NoteBook:Product
    {
        public string OpSystem;
    public string Processor;
    public bool HasGraphicCard;
    public NoteBook(string brandName, string model, double price, double cost, int count, string opsystem, string processor) : base(brandName, model, price, cost, count)
    {
        OpSystem = opsystem;
        Processor = processor;
       
        

    }
        public NoteBook(string brandName, string model, double price, double cost, int count,  bool hasgrapiccard=(true)) : base(brandName, model, price, cost, count)
        {

            HasGraphicCard = hasgrapiccard;
            
        }
    }
}
