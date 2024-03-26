using Animaux;

class Program
{
    static void Main(string[] args)
    {
        Animal monChat = new Animal("Chopper");
        monChat.Move();
        monChat.Sleep();
        Console.WriteLine(monChat.Name);
    }
}