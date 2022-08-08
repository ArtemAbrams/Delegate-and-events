namespace ConsoleApp;

class Word
{
    public string Source { get; }
    public string Target { get; set; }
    public Word(string source, string target)
    {
        Source = source;
        Target = target;
    }
}
class Dictionary
{
    Word[] words;
    public Dictionary()
    {
        words = new Word[]
        {
            new Word("red", "красный"),
            new Word("blue", "синий"),
            new Word("green", "зеленый")
        };
    }

    public string this[string word]
    {
        get
        {
            switch(word)
            {
              case "red": return words[0].Target;
                  break;
              case  "blue": return words[1].Target;
                  break;
              case "green": return words[2].Target; 
                  break;
              default: throw new Exception("Wrong");
            }
        }
        set
        {
            switch (word)
            {
                case "red":
                    words[0].Target = value;
                    break;
                case "blue":
                    words[1].Target = value;
                    break;
                case "green":
                    words[2].Target = value;
                    break;
                default:
                    throw new Exception("Wrong"); 
            }
            
        }
    }
}