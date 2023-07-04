// See https://aka.ms/new-console-template for more information
using CommandLine;
using Ubunifu.CommandLineOptions;

using static Ubunifu.CommandLineParserHelper;

var parser = new Parser(settings => {
    settings.CaseInsensitiveEnumValues = true;
    settings.CaseSensitive = false;
});

var result = parser.ParseArguments<
    ControllerOptions, 
    DtoOptions, 
    HandlerOptions, 
    RepositoryOptions, 
    ServiceOptions, 
    ValidatorOptions>(args);

result.ResultParser<object>();
