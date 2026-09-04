


Tamagotchi TamagotchiPet = new Tamagotchi();

while (true)
{

    TamagotchiPet.Tick();
    TamagotchiPet.Stats();
    String Choice = Console.ReadLine();
    Choice = Choice.ToLower();

    if (Choice == "hi")
    {
        TamagotchiPet.Hi();
    }
   
}


