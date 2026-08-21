namespace i_linq_vowels;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");

        var sentence = Console.ReadLine();

        var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };

        var query = from letter in sentence.ToUpper()
                    where vowels.Contains(letter)
                    select letter;

        var count = query.Count();

        Console.WriteLine("Number of vowels = " + count);
    }
}

/*Enter a sentence:
Hello my name is rabi budahathoki from gatthaghar bhaktapur
Number of vowels = 19*/