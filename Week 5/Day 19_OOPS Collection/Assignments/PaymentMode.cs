

namespace Assignment
{

    interface IPayment
    {
        void Pay(double amount);
        
    }


    class CreditCardPayment : IPayment
    {
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }

        public CreditCardPayment(string cardNumber, string cardHolder)
        {
            CardNumber = cardNumber;
            CardHolder = cardHolder;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid Rs.{amount} using Credit Card ({CardHolder},Card No.: {CardNumber})");
        }
    }

    class UPIPayment : IPayment
    {
        public string UpiId { get; set; }

        public UPIPayment(string upiId)
        {
            UpiId = upiId;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid Rs.{amount} using UPI Payment (UPI ID : {UpiId})");
        }
    }

    class PayPal : IPayment
    {
        public string Email { get; set; }

        public PayPal(string email)
        {
            Email = email;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid Rs.{amount} using Paypal (Email: {Email})");
        }

    }
                class Program
                {
                    static void Main(string[] args)
                    {

                        IPayment CreditCardPayment = new CreditCardPayment("1234-5678-9012-3456", "Abcdefgh");
                        CreditCardPayment.Pay(58000);

                        IPayment UPIPayment = new UPIPayment("abcd9812@axl");
                        UPIPayment.Pay(2000);

                        IPayment PayPal = new PayPal("abcd@gmail.com");
                        PayPal.Pay(10000);


                        Console.WriteLine("All the payments are made successfully.");
                        Console.ReadLine();
                    }
                }
            }  
