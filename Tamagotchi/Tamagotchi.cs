public class Tamagotchi()
{
    private int Hunger = 0;
    private int Boredom = 0;
    private List<string> Words = ["Hello", "Hate", "I really hate you"];
    private bool Alive;
    private int one = 1;
    public string Name;
    static public double seconds;

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
        Console.WriteLine($"Hunger:{Hunger}");
        Console.WriteLine($"Boredom:{Boredom}");
    }
}

