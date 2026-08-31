public class Tamagotchi()
{
    private int Hunger = 0;
    private int Boredom = 0;
    private List<string> Words = [];
    private bool Alive; 
    public string Name;
    static public double seconds;

    public void Tick()
    {
        seconds = GameTime.TotalSeconds % 3;
        
        if (seconds > 2.9)
        {
            Hunger ++;
            Boredom ++;
        }
    }
    
    public void stats()
    {
        
    }
}

