namespace ListOpdrachten
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> birds = new List<string> { "uil", "kraai", "hond", "papagaai" };
            List<string> birds2 = new List<string> { "meeuw", "duif" };

            birds.AddRange(birds2);
            birds.Remove("hond");

            for (int i = 0; i < birds.Count; i++)
            {
                Console.WriteLine(birds[i]);
            }
        }
    }
}