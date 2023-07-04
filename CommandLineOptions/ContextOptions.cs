using CommandLine;

namespace Ubunifu.CommandLineOptions;

[Verb(name: "context", isDefault: false, aliases: new string[] { "x" })]
public class DbContextOptions: BaseOptions {
    [Option(shortName: 'm', longName: "model", Required = false)]
    public override string ModelName { get; set; } = "";
 }
