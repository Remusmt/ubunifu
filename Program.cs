using CommandLine;
using Humanizer;
using Ubunifu.CommandLineOptions;

using static Ubunifu.ConsoleHelper;
using static Ubunifu.StaticVariables;
namespace Ubunifu;
public class Program {
    public static void Main(string[] args) {
        try
        {
            CurrentDirectory = Environment.CurrentDirectory;
    
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
                ValidatorOptions,
                DbContextOptions>(args);

            result.ResultParser<object>();
        }
        catch (System.Exception ex)
        {
            WriteErrorMessage(ex.Message.Humanize());
        }
    }
}
