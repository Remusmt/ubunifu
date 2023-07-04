using CommandLine;
using Humanizer;
using Ubunifu.CommandLineOptions;

using static Ubunifu.ConsoleHelper;
namespace Ubunifu;
public static class CommandLineParserHelper {
    public static void ResultParser<T>(this ParserResult<object> result) {
        result.WithParsed<ControllerOptions>(opt => {
            SetConsoleSuccessColor();
            Console.WriteLine("Controller model name {0}", opt.ModelName);
            SetConsoleDefaultColor();
        }).WithParsed<DtoOptions>(opt => {
            SetConsoleSuccessColor();
            Console.WriteLine("DTO model name {0}", opt.ModelName);
            Console.WriteLine("DTO types {0}", opt.Types);
            Console.WriteLine("DTO name {0}", opt.Name);
            SetConsoleDefaultColor();
        }).WithParsed<HandlerOptions>(opt => {
            SetConsoleSuccessColor();
            Console.WriteLine("Handler model name {0}", opt.ModelName);
            Console.WriteLine("Handler types {0}", opt.Types);
            Console.WriteLine("Handler name {0}", opt.Name);
            SetConsoleDefaultColor();
        }).WithParsed<RepositoryOptions>(opt => {
            SetConsoleSuccessColor();
            Console.WriteLine("Repository model name {0}", opt.ModelName);
            Console.WriteLine("Repository types {0}", opt.Types);
            Console.WriteLine("Repository name {0}", opt.Name);
            SetConsoleDefaultColor();
        }).WithNotParsed(errors => {
            foreach(Error error in errors) {
                SetConsoleErrorColor();
                Console.WriteLine(error.Tag.Humanize());
                SetConsoleDefaultColor();
            }
        });
    }
}