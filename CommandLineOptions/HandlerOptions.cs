using CommandLine;

namespace Ubunifu.CommandLineOptions;

[Verb(name: "handler", isDefault: false, aliases: new string[] { "h" })]
public class HandlerOptions: BaseOptions {
    [Option(shortName: 't', longName: "type", Required = true, HelpText = "List types of handlers you want to generate")]
    public HandlerTypes Types { get; set; }
}
