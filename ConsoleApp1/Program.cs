internal class Program
{
    private static void Main(string[] args)
    {
        int coockies = 0;
        int plants = 0;
        int pricePlants = 20;
        int factories = 0;
        int priceFactories = 500;
        char c = ' ';

        Console.Title = "Clicker";

        Console.WriteLine("Вы начали игру в кликер");

        while (c != 's')
        {
            c = Console.ReadKey().KeyChar;
            Console.Clear();

            // полсе того как считаем (ReadKey), проверяем чему оно равно

            if (c == ' ')
            {
                coockies = coockies + 1 + plants + (factories * 10);// *10 тк 1 завод = 10 шт
            }

            else if (c == 'p')
            {
                if (coockies >= pricePlants)
                {
                    plants = plants + 1;
                    coockies = coockies - pricePlants;
                    pricePlants = pricePlants * 2;
                }
                else
                {
                    Console.WriteLine($"Не хватает {pricePlants - coockies} печенек на поле");
                }

            }

            else if (c == 'f')
            {
                if (coockies >= priceFactories)
                {
                    factories = factories + 1;
                    coockies = coockies - priceFactories;
                    priceFactories = priceFactories * 2;
                }
                else
                {
                    Console.WriteLine($"Вам не хватает {priceFactories - coockies} печенек на завод");
                }
            }
            else {
                Console.WriteLine("такой команды не существует");
            }

            // сначала с помощью if меняем значения, потом выводим эти значения в консоль
            Console.WriteLine("кол во печенек = " + coockies);
            Console.WriteLine("кол во полей = " + plants);
            Console.WriteLine("кол во заводов = " + factories);

        }
    }
}