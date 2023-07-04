using CommandLine;

namespace Ubunifu.CommandLineOptions;
public abstract class BaseOptions {
    [Option(shortName: 'm', 
            longName: "model", 
            Required = true, 
            HelpText = "Name of the model class used for code generation")]
    public virtual string ModelName { get; set; } = "";
    
    [Option(shortName: 'n', longName: "name", HelpText = "Class name of the generated code file")]
    public string? Name { get; set; }

    [Option(shortName: 'p', longName: "path", HelpText = "Destination directory for the generated file")]
    public string? Path { get; set; }

    [Option(shortName: 's', longName: "suffix", HelpText = "Appended to the end of the filename")]
    public string? FileName { get; set; }
}
