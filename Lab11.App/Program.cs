using Lab11.Library;

namespace Lab11.App;

internal class Program
{
    static void Main(string[] args)
    {
        string input = "Saepe officia ipsa velit earum libero quis. Quo est sint dolor consequatur minus aut non. Dolor magni optio qui saepe magni et qui. Aspernatur dicta animi et dolor ut voluptatem sit.";

        TextTransformationProcessor processor = new TextTransformationProcessor(
            new ReplaceString("ipsum", "ipsum456"),
            new RemoveAllString("dolorem"),
            new InsertStringAt(3, "asdada"));

        string result = processor.ApplyAllTransformationRules(input);
        Console.WriteLine(result);
    }
}