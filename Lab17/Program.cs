using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<int> person1 = new Bank<int>();
            person1.readParam(1, 125000, "John Johnson");
            person1.writeParam();
            Bank<string> person2 = new Bank<string>();
            person2.readParam("000002", 555000, "Tom Richardson");
            person2.writeParam();
            Console.ReadKey();
        }
    }
    class Bank<T>
    {
        private T Number { get; set; }
        private decimal Balance { get; set; }
        private string Name { get; set; }
        public void readParam(T number, decimal balance, string name)
        {
            Number = number;
            Balance = balance;
            Name = name;
        }
        public void writeParam()
        {
            Console.WriteLine(Number);
            Console.WriteLine(Balance);
            Console.WriteLine(Name);
        }
    }
}
