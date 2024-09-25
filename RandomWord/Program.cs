namespace RandomWord;

internal class Program
{
    public static void Main(string[] args)
    {
        var word = "testingtesting";

        var mask = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        
        var outcome = string.Join("", word.ToCharArray().Select(x => mask.Contains(x) ? '_' : x));
        
        Console.WriteLine(outcome);

        // for (var i = 0; i < 100; i++)
        // {
        //     Console.WriteLine(new WordsService().GetRandomWord());
        // }
    }
}