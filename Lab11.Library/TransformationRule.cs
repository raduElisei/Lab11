namespace Lab11.Library;

public abstract class TransformationRule : ITransformationRule
{
    public abstract string Transform(string input);
}