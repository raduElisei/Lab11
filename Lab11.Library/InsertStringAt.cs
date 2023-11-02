namespace Lab11.Library;

public class InsertStringAt : TransformationRule
{
    public InsertStringAt(int index, string text)
    {
        if (index < 0) 
            throw new ArgumentOutOfRangeException(nameof(index));

        if (text is null)
            throw new ArgumentNullException(nameof(text));

        Index = index;
        Text = text;
    }

    public int Index { get; set; }
    public string Text { get; set; }

    public sealed override string Transform(string input)
    {
        if (input is null) 
            throw new ArgumentNullException(nameof(input));

        if (Index >= input.Length)
            throw new ArgumentOutOfRangeException(nameof(Index));

        string result = input.Insert(Index, Text);

        return result;
    }
}
