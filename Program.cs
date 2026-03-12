namespace EvidentaFlori
{
    class Program
    {
        static void Main()
        {
            Floare f = new Floare("Trandafir", 10, 20);
            Client c = new Client("Ana", 1);
            Comanda com = new Comanda("Ana", "Trandafir", 5);

            Console.WriteLine(f.Info());
            Console.WriteLine(c.Info());
            Console.WriteLine(com.Info());

            Console.ReadKey();
        }
    }
}