namespace Ubunifu;
public static class ConsoleHelper {
    static void SetConsoleDefaultColor() {
        Console.ForegroundColor = ConsoleColor.White;
    }
 
    static void SetConsoleSuccessColor() {
        Console.ForegroundColor = ConsoleColor.Green;
    }   

    static void SetConsoleErrorColor() {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    public static void WriteErrorMessage(string? message) {
        SetConsoleErrorColor();
        Console.WriteLine(message);
    }

    public static void WriteInfoMessage(string? message) {
        SetConsoleDefaultColor();
        Console.WriteLine(message);
    }

    public static void WriteSuccessMessage(string? message) {
        SetConsoleSuccessColor();
        Console.WriteLine(message);
    }
}