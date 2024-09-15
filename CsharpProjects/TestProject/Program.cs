// // // // for (int i = 0; i < 10; i++)
// // // // {
// // // //     Console.WriteLine(i);
// // // //     if (i == 7) break;
// // // // }

// // // string[] names = ["Alex", "Eddie", "David", "Michael"];
// // // for (int i = names.Length - 1; i >= 0; i--)
// // // {
// // //     Console.WriteLine(names[i]);
// // // }

// // string[] names = { "Alex", "Eddie", "David", "Michael" };
// // foreach (var name in names)
// // {
// //     // Can't do this:
// //     if (name == "David") name = "Sammy";
// // }

// string[] names = ["Alex", "Eddie", "David", "Michael"];

// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David")
//         names[i] = "Sammy";

// foreach (string name in names)
//     Console.WriteLine(name);

for (int i = 1; i <= 100; i++)
{
    Console.Write(i);

    if (i % 3 == 0 && i % 5 == 0)
        Console.Write(" - FizzBuzz");
    else if (i % 3 == 0)
        Console.Write(" - Fizz");
    else if (i % 5 == 0)
        Console.Write(" - Buzz");

    Console.WriteLine();
}