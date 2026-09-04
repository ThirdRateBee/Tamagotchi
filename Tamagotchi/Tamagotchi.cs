public class Tamagotchi()
{
    private int Hunger = 0;
    private int Boredom = 0;
    private List<string> Words = ["Hello", "Hate", "I really hate you"];
    private bool Alive = true;
    public string Name = "";

    public void Tick()
    {

        Hunger++;
        Boredom++;

    }
    public void Feed()
    {
        Hunger = 0;
    }
    public void Hi()
    {
        ReduceBoredom();
        int sss = Random.Shared.Next(0, Words.Count);
        Console.WriteLine(Words[sss]);
    }
    public void Teach()
    {
        Console.WriteLine("What do you want to teach!");
        String Choice = Console.ReadLine();
        Words.Add(Choice);
    }
    public void NameIt()
    {
        Console.WriteLine("What do you want to name it!");
        String Choice = Console.ReadLine();
        Name = Choice;
    }
    public void ReduceBoredom()
    {
        Boredom -= 2;
        if (Boredom < 0)
        {
            Boredom = 0;
        }
    }
    public void Stats()
    {
        if (Name == "")
        {
            Console.WriteLine($"Name: No name");
        }
        else
        {
            Console.WriteLine($"Name:{Name}");
        }
        Console.WriteLine($"Hunger:{Hunger}");
        Console.WriteLine($"Boredom:{Boredom}");
    }
    public void GetAlive()
    {
        if (Hunger > 10)
        {
            Alive = false;
        }
        if (Alive)
        {
            Console.WriteLine("it's alive!");
        }
        else
        {
            Console.WriteLine("it's Dead...");
        }
    }
}

