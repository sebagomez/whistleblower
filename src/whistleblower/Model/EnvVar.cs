namespace whistleblower.Pages;

public class EnvVar
{
    public string Name { get; private set; }
    public string Value { get; private set; }

    public EnvVar(string name, string value)
    {
        Name = name;
        Value = value;
    }
}