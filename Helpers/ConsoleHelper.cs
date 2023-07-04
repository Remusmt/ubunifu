namespace Ubunifu;
public static class ConsoleHelper {
    public static void SetConsoleDefaultColor() {
        Console.ForegroundColor = ConsoleColor.White;
    }
 
    public static void SetConsoleSuccessColor() {
        Console.ForegroundColor = ConsoleColor.Green;
    }   

    public static void SetConsoleErrorColor() {
        Console.ForegroundColor = ConsoleColor.Red;
    }
}