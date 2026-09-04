


Tamagotchi TamagotchiPet = new Tamagotchi();

while (true)
{
    TamagotchiPet.Stats();

    Actions();

    TamagotchiPet.Tick();
}


void Actions()
{
    String Choice = Console.ReadLine();
    Choice = Choice.ToLower();

    if (Choice == "hi")
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
}