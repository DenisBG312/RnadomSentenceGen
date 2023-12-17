namespace RnadomSentenceGen;

class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information

        string[] names = { "Denis", "Julien", "Borko", "Behatov", "Daniel", "Sasho", "Viktor" };
        string[] places = { "Sofia", "Varna", "Burgas", "Ruse", "Plovdiv", "Nesebar", "Veliko Tarnovo" };
        string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
        string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
        string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
        string[] details = { "near the river", "at home", "in the park" };

        List<string> sentences = new List<string>();

        Random random = new Random();
        Console.WriteLine("##################################################");
        Console.WriteLine("Welcome to the random sentence genrator!");
        Console.WriteLine("When you click [y] the program will start giving you random sentences.");
        Console.WriteLine(
            "When you click [n], the program will give you every sentence on new line that you have generated.");
        Console.WriteLine("##################################################");
        Console.WriteLine("Do you want to generate a random sentence?: [y] / [n]");
        string input = Console.ReadLine();
        while (input != "n")
        {
            string randomName = RandomPick(names);
            string randomPlace = RandomPick(places);
            string randomVerb = RandomPick(verbs);
            string randomNoun = RandomPick(nouns);
            string randomAdverb = RandomPick(adverbs);
            string randomDetail = RandomPick(details);


            string who = $"{randomName} from {randomPlace}";
            string action = $"{randomAdverb} {randomVerb} {randomNoun}";
            string sentence = $"{who} {action} {randomDetail}";
            Console.WriteLine($"Your generated sentence is: {sentence}");
            sentences.Add(sentence);
            Console.WriteLine("Do you want to generate a new sentence?: [y] / [n]");
            input = Console.ReadLine();
            if (input == "n")
            {
                break;
            }
        }

        if (input == "n")
        {
            Console.WriteLine("You chose to end the program.");
            if (sentences.Count <= 0)
            {
                Console.WriteLine("You haven't generated any sentence!");
            }
            else
            {
                Console.WriteLine("You generated the following sentences:");
                foreach (string sentence in sentences)
                {
                    Console.WriteLine(sentence);
                }
            }
        }

        static string RandomPick(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}