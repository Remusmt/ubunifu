using CommandLine;
using Humanizer;
using Ubunifu.CommandLineOptions;

using static Ubunifu.ConsoleHelper;
namespace Ubunifu;
public static class CommandLineParserHelper {
    public static void ResultParser<T>(this ParserResult<object> result) {
        result.WithParsed<ControllerOptions>(opt => {
            WriteSuccessMessage($"Controller model name {opt.ModelName}");
        }).WithParsed<DtoOptions>(opt => {
            var (generated, name, content) = new DTOGenerator(opt).Generate();
        }).WithParsed<HandlerOptions>(opt => {
            WriteSuccessMessage($"Handler model name {opt.ModelName}");
            WriteSuccessMessage($"Handler types {opt.Types}");
            WriteSuccessMessage($"Handler name {opt.Name}");
        }).WithParsed<RepositoryOptions>(opt => {
            WriteSuccessMessage($"Repository model name {opt.ModelName}");
            WriteSuccessMessage($"Repository types {opt.Types}");
            WriteSuccessMessage($"Repository name {opt.Name}");
        }).WithParsed<DbContextOptions>(opt => {
            WriteSuccessMessage($"Repository model name {opt.ModelName}");
            WriteSuccessMessage($"Repository name {opt.Name}");
        }).WithNotParsed(errors => {
            foreach(Error error in errors) {
                WriteErrorMessage(error.Tag.Humanize());
            }
        });
    }
}