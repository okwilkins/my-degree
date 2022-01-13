// This file is derived from: https://github.com/ArjanCodes/betterpython/blob/main/9%20-%20solid/single-responsibility-before.py

namespace SingleResponsibility {
    public class Order {
        public List<string> Items { get; set; }
        public List<string> Quantities { get; set; }
        public List<string> Prices { get; set; }
        public string Status { get; set; }

        public Order() {
            List<string> Items = new List<string>();
            List<string> Quantities = new List<string>();
            List<string> Prices = new List<string>();
            string Status = "open";
        }

    }

    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Program is running!");
        }
    }
}
