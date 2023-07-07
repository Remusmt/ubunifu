using CommandLine;
namespace Ubunifu.CommandLineOptions;
public class BaseOptions
{
    [Option(shortName: 'm', 
            longName: "model", 
            Required = true, 
            HelpText = "Name of the model class used for code generation")]
    public virtual string ModelName { get; set; } = "";

    [Option(shortName: 'p', longName: "project", HelpText = "Name of the project containing the model class")]
    public string? Project { get; set; }

    [Option(shortName: 'n', longName: "name", HelpText = "Class name of the generated code file")]
    public string? Name { get; set; }

    [Option(shortName: 'f', longName: "filename", HelpText = "Name of the generated file. May include path")]
    public string? FileName { get; set; }
}