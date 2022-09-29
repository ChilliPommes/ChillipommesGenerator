namespace ChillipommesGenerator.Models
{
    internal interface IGuiOption
    {
        string Name { get; }

        Action OptionSelected { get; set; }
    }
}
