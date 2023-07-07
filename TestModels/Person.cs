namespace Ubunifu.TestModels;
public class Person {
    public Guid Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public DateTime DoB { get; set; }
    public int Age { get; set; }
}