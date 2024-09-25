using System.Text.RegularExpressions;

namespace RandomWord;

public class WordsService
{
    public WordsService()
    {
        _words = GetWords();
    }
    
    private static readonly Random Random = new();
    private List<string> _words;

    public string GetRandomWord()
    {
        return _words[Random.Next(_words.Count)];
    }

    private List<string> GetWords()
    {
        return Regex.Split(File.ReadAllText(ProjectDir() + "/Words.txt"), @"\s")
            .Where(x => !Regex.IsMatch(x, "[^a-zA-Z]"))
            .Select(x => x.ToLower())
            .ToList();
    }

    private string ProjectDir()
    {
        return Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ??
            throw new Exception("You fucking broke it");
    }
}