using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class Vehical
    {
        String Name;
        Int32 NWheels;
        Int32 Price;
        String Company;
        public Vehical(String Name)
        {
            this.Name = Name;
        }
        
        public void setattribute()
        {
            Console.WriteLine("Enter the number of Wheels for :"+this.Name);
            NWheels = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  Price for :" + this.Name);
            Price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Company for :" + this.Name);
            Company = Console.ReadLine();

        }
        public string getName()
        {
            return Name;
        }
        public Int32 getNWheels()
        {
            return NWheels;
        }
        public Int32 getPrice()
        {
            return Price;
        }
        public string getCompany()
        {
            return Company;
        }
        public void display()
        {
            Console.WriteLine("This "+getName() + " Has " + getNWheels() + " Wheels with price of "+getPrice()+" from a Company "+getCompany()+".");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of Vehical");
            String VName = Console.ReadLine();
            Vehical v = new Vehical(VName);
            v.setattribute();
            v.display();
            Console.ReadKey();
        }
    }
}
