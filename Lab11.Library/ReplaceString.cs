namespace Lab11.Library;

public class ReplaceString : TransformationRule
{
    public ReplaceString(string oldValue, string newValue)
    {
        if (oldValue == null) throw new ArgumentNullException(nameof(oldValue));

        if (string.IsNullOrEmpty(oldValue)) throw new ArgumentNullException();

        OldValue = oldValue ?? throw new ArgumentException("Value cannot be empty", nameof(oldValue));
        NewValue = newValue;
    }

    public string OldValue { get; set; }
    public string NewValue { get; set; }

    public sealed override string Transform(string input)
    {
        string result = input?.Replace(OldValue, NewValue) ?? string.Empty;

        return result;
    }
}
