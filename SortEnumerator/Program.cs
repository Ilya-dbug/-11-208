using SortEnumerator;

var text = "Hello World I am a program";

WordsInText s = new WordsInText(text);

foreach(var word in s)
{
    Console.WriteLine(word);
}
Console.WriteLine();



