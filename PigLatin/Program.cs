namespace PigLatin
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Minnie's English to PigLatin translator!");
            bool goAgain = true;
            while (goAgain == true)
            {

                Console.Write("Please enter the word you would like to translate: ");
                string word = Console.ReadLine().ToLower();
                
                //checking if string is empty
                while (word == String.Empty)
                {
                    Console.WriteLine("You must enter a word or sentence. Please try again.");
                    word = Console.ReadLine();
                    continue;
                }
                
                string[] words = word.Split(' ');

                foreach (string word2 in words)
                {
                    int vowelPosition = -1;
                    foreach (char letter in word2)
                    {
                        vowelPosition++;
                        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                        {
                            break;
                        }
                    }

                    //creating strings for the translator
                    string vowelWordEnder = "way";
                    string beforeLetter = "";
                    string afterLetters = "";
                    string consWordEnder = "ay";
                    
                    
                    if (vowelPosition == 0)
                    {

                        vowelWordEnder = word2 + vowelWordEnder;
                        Console.WriteLine(vowelWordEnder);
                    }
                    else
                    {
                        beforeLetter = word2.Substring(0, vowelPosition);
                        afterLetters = word2.Substring(vowelPosition);
                        string consWord = afterLetters + beforeLetter + consWordEnder;
                        Console.WriteLine(consWord);


                    }
                }



                goAgain = AskToContinue();
            }

        }
        // go again method
        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to again? Y/N.");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, that was an invalid response, please input a valid response.");
                return AskToContinue();
            }
        }
    }
}