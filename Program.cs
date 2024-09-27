Console.WriteLine("Hello, World from class Program!");
Greeter greeter = new Greeter();
Console.WriteLine(greeter.getGreeting());
GreeterFile greeterFile = new GreeterFile();
greeterFile.greet();

class Greeter {
    public string getGreeting() {
        return "Hello world from the Greeter class!";
    }
}