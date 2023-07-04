using CommandLine;

namespace Ubunifu.CommandLineOptions;

[Verb(name: "repository", isDefault: false, aliases: new string[] { "r" })]
public class RepositoryOptions: BaseOptions {
    [Option(shortName: 't', longName: "type", Default = RepositoryTypes.Class)]
    public RepositoryTypes Types { get; set; }
}
