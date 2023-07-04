using CommandLine;

namespace Ubunifu.CommandLineOptions;

[Verb(name: "dto", isDefault: false, aliases: new string[] { "d" })]
public class DtoOptions : BaseOptions {
    [Option(shortName: 't', longName: "type", Required = true, HelpText = "Type or types of the DTOs to be generated. List should be separated by commas.")]
    public DTOTypes Types { get; set; }
}
