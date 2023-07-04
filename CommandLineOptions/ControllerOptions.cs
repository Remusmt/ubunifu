using CommandLine;

namespace Ubunifu.CommandLineOptions;

[Verb(name: "controller", isDefault: false, aliases: new string[] { "c" })]
public class ControllerOptions : BaseOptions { }
