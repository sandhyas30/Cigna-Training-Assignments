    namespace Assignment
    {

        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Product p1 = new Product();

                Console.WriteLine("Enter person Id :  ");
                p1.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter person Name :  ");
                p1.Name = Console.ReadLine();

                Console.WriteLine("Enter person Price :  ");
                p1.Price = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter person Quantity :  ");
                p1.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine($"Hi {p1.Name}, Good morning...!");
                Console.WriteLine($"[Details:] Id : {p1.Id}, Name: {p1.Name}, Price: {p1.Price}, Quantity: {p1.Quantity}");

                Console.ReadLine();
            }
        }
    }

