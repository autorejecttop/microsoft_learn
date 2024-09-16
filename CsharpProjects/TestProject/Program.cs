// // // // // Random dice = new();

// // // // // int heroHealth = 10;
// // // // // int monsterHealth = 10;
// // // // // bool isHeroTurn = true;

// // // // // while (heroHealth > 0 && monsterHealth > 0)
// // // // // {
// // // // //     int damage = dice.Next(1, 11);

// // // // //     if (isHeroTurn)
// // // // //     {
// // // // //         monsterHealth -= damage;
// // // // //         Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
// // // // //     }
// // // // //     else
// // // // //     {
// // // // //         heroHealth -= damage;
// // // // //         Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
// // // // //     }

// // // // //     isHeroTurn = !isHeroTurn;
// // // // // }

// // // // // if (heroHealth <= 0)
// // // // //     Console.WriteLine("Monster wins!");
// // // // // else if (monsterHealth <= 0)
// // // // //     Console.WriteLine("Hero wins!");

// // // // int hero = 10;
// // // // int monster = 10;

// // // // Random dice = new Random();

// // // // do
// // // // {
// // // //     int roll = dice.Next(1, 11);
// // // //     monster -= roll;
// // // //     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

// // // //     if (monster <= 0) continue;

// // // //     roll = dice.Next(1, 11);
// // // //     hero -= roll;
// // // //     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// // // // } while (hero > 0 && monster > 0);

// // // // Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// // // string? readResult;
// // // bool validEntry = false;
// // // Console.WriteLine("Enter a string containing at least three characters:");
// // // do
// // // {
// // //     readResult = Console.ReadLine();
// // //     if (readResult != null)
// // //     {
// // //         if (readResult.Length >= 3)
// // //             validEntry = true;
// // //         else
// // //             Console.WriteLine("Your input is invalid, please try again.");
// // //     }
// // // } while (!validEntry);

// // // int numericValue = 0;
// // // bool validNumber = false;

// // // validNumber = int.TryParse(readResult, out numericValue);

// // string? rawInput;
// // bool isInputValid = false;
// // int numberValue = 0;

// // Console.WriteLine("Enter an integer value between 5 and 10");

// // do
// // {
// //     rawInput = Console.ReadLine();

// //     if (rawInput == null)
// //     {
// //         Console.WriteLine("Sorry, you entered an invalid number, please try again");
// //         continue;
// //     }

// //     isInputValid = int.TryParse(rawInput, out numberValue);

// //     if (!isInputValid)
// //     {
// //         Console.WriteLine("Sorry, you entered an invalid number, please try again");
// //         continue;
// //     }

// //     if (numberValue < 5 || numberValue > 10)
// //     {
// //         Console.WriteLine($"You entered {numberValue}. Please enter a number between 5 and 10.");
// //         continue;
// //     }
// // } while (!isInputValid || numberValue < 5 || numberValue > 10);

// // Console.WriteLine($"Your input value ({numberValue}) has been accepted.");

// string[] roles = ["administrator", "manager", "user"];

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// string? userInput = Console.ReadLine();

// while (userInput == null || !roles.Contains(userInput.Trim().ToLower()))
// {
//     Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//     userInput = Console.ReadLine();
// }

// Console.WriteLine($"Your input value ({userInput}) has been accepted.");

string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    int periodLocation = myString.IndexOf('.');

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1).TrimStart();
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}