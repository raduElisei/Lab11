namespace Lab11.Library;

public class RemoveAllString : TransformationRule
{
    public string Text { get; set; }
    public RemoveAllString(string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));

        if (string.IsNullOrEmpty(text)) throw new ArgumentNullException();

        Text = text ?? throw new ArgumentException("Value cannot be empty", nameof(text));
    }

    public sealed override string Transform(string input)
    {
        string result = input.Replace(Text, null);
        return result;
    }
}
