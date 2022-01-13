// This file is derived from:
// https://github.com/ArjanCodes/betterpython/blob/main/9%20-%20solid/single-responsibility-before.py
// This is meant to be a bad example that breaks the single-responsibility principle.

namespace SingleResponsibilityBefore {
    public class Order {
        public List<string> Items { get; set; }
        public List<int> Quantities { get; set; }
        public List<double> Prices { get; set; }
        public string Status { get; set; }

        public Order() {
            this.Items = new List<string>();
            this.Quantities = new List<int>();
            this.Prices = new List<double>();
            this.Status = "open";
        }

        public void AddItem(string name, int quantity, double price) {
            this.Items.Add(name);
            this.Quantities.Add(quantity);
            this.Prices.Add(price);
        }

        public double TotalPrice() {
            double total = 0;

            for (int i = 0; i < this.Prices.Count; i++) {
                total += this.Quantities[i] * this.Prices[i];
            }

            return total;
        }

        public void Pay(string paymentType, string securityCode) {
            if (paymentType == "debit") {
                Console.WriteLine("Processing debit payment type");
                Console.WriteLine($"Verifying security code: {securityCode}");
                this.Status = "paid";
            }
            else if (paymentType == "credit") {
                Console.WriteLine("Processing credit payment type");
                Console.WriteLine($"Verifying security code: {securityCode}");
                this.Status = "paid";
            }
            else {
                throw new Exception($"Unknown payment type: {paymentType}");
            }
        }

        public class Program {
            public void Main() {
                Order order = new Order();
                order.AddItem("Keyboard", 1, 50);
                order.AddItem("SSD", 1, 150);
                order.AddItem("USB cable", 2, 5);

                Console.WriteLine(order.TotalPrice());
                order.Pay("debit", "03722846");
            }
        }
    }
}