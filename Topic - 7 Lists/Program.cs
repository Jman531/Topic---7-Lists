using System.Xml;

namespace Topic___7_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> names = new List<string>() { "Arthur Dent", "Marvin"};
            List<double> prices = new List<double>();

            string nameAdd, nameRemove;

            names.Add("Trillian");
            names.Add("Ford Perfect");

            Console.WriteLine(names.Count);

            Console.WriteLine(names[0]);

            Console.WriteLine(names.Count - 1);

            names[0] = "Arthur";

            Console.WriteLine(names[2]);

            foreach (string name in names)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            for (int i = 0; i <= names.Count - 1; i++)
            {
                names[i] = names[i].ToUpper();
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Hey there! What new name do you want to add to the list: ");
                nameAdd = Console.ReadLine();
                names.Add(nameAdd);
                names.Sort();
            }

            for (int i = 0; i <= names.Count() - 1; i++)
            {
                names[i] = names[i].ToUpper();
            }

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.Write("What name do you want to remove from the list: ");
            nameRemove = Console.ReadLine();

            Console.WriteLine();

            if (names.Remove(nameRemove.ToUpper()))
                Console.WriteLine("Removed succesfully");
            else if (!names.Remove(nameRemove.ToUpper()))
            {
                Console.WriteLine("Name unsucefully removed... Adding name to the list instead");
                names.Add(nameRemove);
            }

            names.Sort();

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("There are " + names.Count() + " names in the list!");

            Console.WriteLine();

            Console.WriteLine("The list will now be cleared!!!");

            names.Clear();

            Console.WriteLine();

            Console.WriteLine("There are now " + names.Count() + " names in the list...");
        }
    }
}
