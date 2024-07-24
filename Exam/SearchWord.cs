namespace SearchWord
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            string str = Console.ReadLine();
            Console.Write("Enter a word to search: ");
            string word = Console.ReadLine();
            int count = 0;
            int index = str.IndexOf(word);
            while (index != -1)
            {
                count++;
                index = str.IndexOf(word, index + word.Length);
            }
            if (count == 0)
            {
                Console.WriteLine("Word not found.");
            }
            else
            {
                Console.WriteLine("Word found {0} times in the string.", count);
            }
        }
    }
}
