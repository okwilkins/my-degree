//  This file is derived from: https://github.com/ArjanCodes/betterpython/blob/main/9%20-%20solid/interface-segregation-after.py

namespace InterfaceSegregationAfter {
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
    }

    public interface IPaymentProcessor {
        public void Pay(Order order);
    }

    public interface IPaymentProcessorSMS : IPaymentProcessor {
        public void AuthSMS(string code);
        
    }

    public class DebitPaymentProcessor : IPaymentProcessorSMS {

        private string SecurityCode { get; }
        private bool Verified { set; get; }

        public DebitPaymentProcessor(string securityCode) {
            this.SecurityCode = securityCode;
            this.Verified = false;
        }

        public void AuthSMS(string code) {
            Console.WriteLine($"Verifying SMS code {code}");
            this.Verified = true;
        }

        public void Pay(Order order) {
            if (!this.Verified) {
                throw new Exception("Not authorized");
            }
            Console.WriteLine("Processing debit payment type");
            Console.WriteLine($"Verifying security code: {this.SecurityCode}");
            order.Status = "paid";
        }
    }

    public class CreditPaymentProcessor : IPaymentProcessor {
        private string SecurityCode { get; }

        public CreditPaymentProcessor(string securityCode) {
            this.SecurityCode = securityCode;
        }

        public void Pay(Order order) {
            Console.WriteLine("Processing credit payment type");
            Console.WriteLine($"Verifying security code: {this.SecurityCode}");
            order.Status = "paid";
        }
    }

    public class PaypalPaymentProcessor : IPaymentProcessorSMS {
        private string EmailAddress { get; }
        private bool Verified { set; get; }

        public PaypalPaymentProcessor(string emailAddress) {
            this.EmailAddress = emailAddress;
            this.Verified = false;
        }
        public void AuthSMS(string code) {
            Console.WriteLine($"Verifying SMS code {code}");
            this.Verified = true;
        }
        public void Pay(Order order) {
            if (!this.Verified) {
                throw new Exception("Not authorized");
            }
            Console.WriteLine("Processing paypal payment type");
            Console.WriteLine($"Verifying email address: {this.EmailAddress}");
            order.Status = "paid";
        }
    }

    public class Program {
        public static void Run() {
            Order order = new Order();
            order.AddItem("Keyboard", 1, 50);
            order.AddItem("SSD", 1, 150);
            order.AddItem("USB cable", 2, 5);

            Console.WriteLine(order.TotalPrice());
            IPaymentProcessorSMS processor = new DebitPaymentProcessor("2349875");
            processor.AuthSMS("465839");
            processor.Pay(order);
        }
    }
}
