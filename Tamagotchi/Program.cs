

Tamagotchi TamagotchiPet = new Tamagotchi();

bool end = true;

TamagotchiPet.NameIt();

while (end)
{
    PlayGame();
}
Dead();

void PlayGame()
{
    if (TamagotchiPet.Alive == true)
    {
        TamagotchiPet.Stats();

        Actions();

        TamagotchiPet.Tick();
        TamagotchiPet.AngerManagement();
        TamagotchiPet.GetAlive();
    }
    else
    {
        end = false;
    }
}

void Actions()
{
    String Choice = Console.ReadLine();
    Choice = Choice.ToLower();

    if (Choice == "hi" || Choice == "hello" || Choice == TamagotchiPet.Name || Choice == $"hi {TamagotchiPet.Name}" || Choice == $"hello {TamagotchiPet.Name}")
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
    else if (Choice == "name")
    {
        TamagotchiPet.NameIt();
    }
}

void Dead()
{
    Console.Clear();
    Console.WriteLine("it's Dead...");
    Console.ReadLine();
}