using Ubunifu.CommandLineOptions;

public class DTOGenerator : GeneratorBase
{
    public DTOGenerator(DtoOptions options) : base(options) { }

    public override (bool Generated, string Name, string Content) Generate()
    {
        Init();
        return (true, "Test", Content.ToString());
    }
}