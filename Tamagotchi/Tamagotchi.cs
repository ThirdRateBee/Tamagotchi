public class Tamagotchi()
{
    private int Hunger = 0;
    private int Boredom = 0;
    private int Anger = 0;
    private List<string> AngryWords = ["No!", "Hate!", "I really hate you"];
    private List<string> Words = ["Hello!", "Nice!", "Ur so kind!"];
    public bool Alive = true;
    public string Name = "";
    
    public void Tick()
    {

        Hunger++;
        Boredom++;

    }
    public void Feed()
    {
        Hunger = 0;
        Anger -= 2;
        if (Anger < 0)
        {
            Anger = 0;
        }
    }
    public void Hi()
    {
        ReduceBoredom();
        if (Name == "loser" || Name == "ugly" || Name == "fat" || Name == "idiot" || Name == "")
        {
            Console.WriteLine($"{Name}: {AngryWords[Random.Shared.Next(AngryWords.Count)]}");  

        }
        else
        {
            Console.WriteLine($"{Name}: {Words[Random.Shared.Next(AngryWords.Count)]}");    
        }
    }
    public void Teach()
    {
        Console.WriteLine("What do you want to teach!");
        String Choice = Console.ReadLine();
        AngryWords.Add(Choice);
    }
    public void NameIt()
    {
        Console.WriteLine("What do you want to name it!");
        String Choice = Console.ReadLine();
        Name = Choice.ToLower();
    }
    public void ReduceBoredom()
    {
        Boredom -= 2;
        if (Boredom < 0)
        {
            Boredom = 0;
        }
    }
    public void AngerManagement()
    {
        if (Name == "loser" || Name == "ugly" || Name == "fat" || Name == "idiot")
        {
            Anger ++;    
        }
    }
    public void Stats()
    {
        Console.WriteLine("-----------------");
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
        Console.WriteLine($"Anger level:{Anger}");
        Console.WriteLine("-----------------");
    }
    public void GetAlive()
    {
        if (Hunger > 9)
        {
            Alive = false;
            if (Hunger > 9)
            {
                Hunger = 10;
            }
        }
    }
}
