using CommandLine;

namespace Ubunifu.CommandLineOptions;

[Verb(name: "context", isDefault: false, aliases: new string[] { "x" })]
public class DbContextOptions: BaseOptions { }
