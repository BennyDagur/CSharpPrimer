internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input numbers and I'll print out both the smallest and largest numbers");

        List<int> numbers = new List<int>();
        int listNumbers;
        bool inputCheck = true;

        while (inputCheck) { 
            string input = Console.ReadLine();
            if (input.Trim() == "")
            {
                inputCheck = false;
            } else if (!int.TryParse(input, out listNumbers)) {
                Console.WriteLine("That's not a number, try again");
            } else
            {
                listNumbers = int.Parse(input);
                numbers.Add(listNumbers);
            }
        }

        numbers.Sort();

        Console.WriteLine($"{numbers.First()} Is the smallest number and {numbers.Last()} Is the largest");
    }
}