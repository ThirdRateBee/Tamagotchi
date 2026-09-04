


Tamagotchi TamagotchiPet = new Tamagotchi();

TamagotchiPet.NameIt();

while (true)
{
    TamagotchiPet.Stats();

    Actions();

    TamagotchiPet.Tick();
    TamagotchiPet.AngerManagement();
}


void Actions()
{
    String Choice = Console.ReadLine();
    Choice = Choice.ToLower();

    if (Choice == "hi"|| Choice == "hello" || Choice == TamagotchiPet.Name || Choice == $"hi {TamagotchiPet.Name}" || Choice == $"hello {TamagotchiPet.Name}" )
    {
        TamagotchiPet.Hi();
    }
    else if (Choice == "feed")
    {
        TamagotchiPet.Feed();
    }
    else if (Choice == "teach")
    {
        TamagotchiPet.Teach();
    }
    else if (Choice == "alive")
    {
        TamagotchiPet.GetAlive();
    }
    else if (Choice == "name")
    {
        TamagotchiPet.NameIt();
    }
}