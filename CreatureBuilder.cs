DisplayTextAsIfTyping("Hello! Welcome to Lundro's Fantastic Creature Builder.");
DisplayTextAsIfTyping("Here, you can build your very own creature for Dungeons & Dragons!");
DisplayTextAsIfTyping("Would you like to begin? Press [Y] for Yes or [N] for No. \nYou can also press [M] to access the Menu at any time.");

ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
char choice = char.ToUpper(keyInfo.KeyChar);

switch (choice)
{
    case 'Y': 
        DisplayTextAsIfTyping("Great! Let's get started then.");
        StartGame();
        break;

    case 'N':
        DisplayTextAsIfTyping("No? Okay. :(");
        DisplayTextAsIfTyping("I guess it's farewell then.");
        ExitGame();
        break;

    default: 
        Console.WriteLine("Sorry, I don't understand your response.");
        break;
}

void StartGame()
{
    DisplayTextAsIfTyping("Let's start off with the basics. What kind of creature would you like to create?");
    Console.WriteLine("1. Aberration\t2. Beast\t3. Celestial\t4. Construct\t5. Dragon\t6. Elemental\t7. Fey");
    Console.WriteLine("8. Fiend\t\t9. Giant\t10. Humanoid\t11. Monstrosity\t12. Ooze\t13. Plant\t\t14. Undead");

    int userInput = Convert.ToInt32(Console.ReadLine());
    switch (userInput)
    {
        case 1:


        default: Console.WriteLine("Please enter a valid response.");
            break;
    }
}

static void DisplayTextAsIfTyping(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(10); // Adjust the number to increase or decrease the speed at which the text displays. A speed of 5 is incredibly fast, 50 is cinematic typewriter speed, and 100 is grandma-level slow.
    }

    Console.WriteLine("\n");
}

static void ExitGame()
{
    DisplayTextAsIfTyping("Closing all doors...");
    DisplayTextAsIfTyping("Wiping down the tables...");
    DisplayTextAsIfTyping("Swatting the kobolds...");
    Thread.Sleep(3000);
    Environment.Exit(0);
}
//Console.WriteLine("What is your creature's name?");
//string creatureName = Console.ReadLine();
//Console.WriteLine($"\nYour creature's name is {creatureName}. Interesting!");
//Console.WriteLine("\nWhat size is it?");
//string creatureSize = Console.ReadLine();
//Console.WriteLine($"\nA {creatureSize}-sized {creatureName}.");
//Console.WriteLine("\nWhat is your creature's type? For example, you can type things like \"Undead\" or \"Dragon.\"");
//string creatureType = Console.ReadLine();
//string creatureSubtype = null;

//while (true)
//{
//    Console.WriteLine("\nDoes your creature have a subtype, yes or no?");
//    string creatureHasSubtype = Console.ReadLine();

//    if (creatureHasSubtype == null)
//        continue;

//    if (creatureHasSubtype.ToLower() == "no")
//    {
//        Console.WriteLine("\nNo subtype, okay. Moving on...");
//        break;
//    }

//    if (creatureHasSubtype.ToLower() == "yes")
//    {
//        Console.WriteLine("\nWhat is its subtype?");
//        creatureSubtype = Console.ReadLine();
//        Console.WriteLine($"\nOoh, a {creatureSubtype}. Threatening.");
//        break;
//    }

//    if (creatureHasSubtype.ToLower() != "no" && creatureHasSubtype.ToLower() != "yes")
//    {
//        Console.WriteLine("Please answer with yes or no.");
//        continue;
//    }

//}

//Console.WriteLine("\nWhat is the alignment of your creature (if any)?");
//string creatureAlignment = Console.ReadLine();
//Console.WriteLine($"\nIts alignment is {creatureAlignment}.");
//Console.WriteLine("\nCreating your creature...");
//Console.WriteLine("\n...");
//Console.WriteLine("\n...");
//Console.WriteLine("\n...");

//Thread.Sleep(3000);
//Console.Beep(20000, 2);

//if (creatureSubtype != null)
//{
//    Console.WriteLine($"\nYou have created some basic details for your creature! Here's what it looks like so far:\n\n{creatureName}\n{creatureSize}, {creatureType} ({creatureSubtype}), {creatureAlignment}");
//}
//else
//{
//    Console.WriteLine($"\nYou have created some basic details for your creature! Here's what it looks like so far:\n\n{creatureName}\n{creatureSize}, {creatureType}, {creatureAlignment}");
//}

//Console.WriteLine("\nWould you like to continue adding details? Press [Y] for Yes, [N] for No, or [R] to Return to the beginning and start over.");
//char inputContinue = 'Y';
//char inputExit = 'N';

//if (inputContinue == 'Y')
//{
//    Console.ReadKey(true);
//}

////////////////////////////

//int armorClass;
//bool isWearingArmor = false;
//int hitPoints;
//int speed;
//int proficiencyBonus;

////////////////////////////

//int strength;
//int strengthBonus;
//int dexterity;
//int dexterityBonus;
//int constitution;
//int constitutionBonus;
//int wisdom;
//int wisdomBonus;
//int charisma;
//int charismaBonus;

////////////////////////////

//int savingThrow1;
//int savingThrow2;
//int savingThrow3;
//int skill1;
//int skill2;
//int skill3;
//int skill4;
//string damageResistance1;
//string damageResistance2;
//string damageResistance3;
//string damageImmunity1;
//string damageImmunity2;
//string conditionImmunity1;
//string conditionImmunity2;
//string conditionImmunity3;
//string conditionImmunity4;
//string conditionImmunity5;
//string conditionImmunity6;
//string sense1;
//int sense1Range;
//int passivePerception;
//string language1;
//string language2;
//string language3;
//string language4;
//int challengeRating;
//int challengeRatingXP;

////////////////////////////

//string creatureDescription = Console.ReadLine();
