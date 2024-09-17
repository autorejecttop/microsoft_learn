// // // // string[] pallets = ["B14", "A11", "B12", "A13"];

// // // // Console.WriteLine("Sorted...");
// // // // Array.Sort(pallets);
// // // // foreach (string pallet in pallets)
// // // //     Console.WriteLine($"-- {pallet}");

// // // // Console.WriteLine();
// // // // Console.WriteLine("Reversed...");
// // // // Array.Reverse(pallets);
// // // // foreach (string pallet in pallets)
// // // //     Console.WriteLine($"-- {pallet}");

// // // string[] pallets = ["B14", "A11", "B12", "A13"];
// // // Console.WriteLine();

// // // Array.Clear(pallets, 0, 2);
// // // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// // // foreach (string pallet in pallets)
// // //     Console.WriteLine($"-- {pallet}"); ;

// // // Console.WriteLine();
// // // Array.Resize(ref pallets, 6);
// // // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// // // pallets[4] = "C01";
// // // pallets[5] = "C02";

// // // foreach (string pallet in pallets)
// // //     Console.WriteLine($"-- {pallet}");

// // // Console.WriteLine();
// // // Array.Resize(ref pallets, 3);
// // // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// // // foreach (string pallet in pallets)
// // //     Console.WriteLine($"-- {pallet}");

// // string value = "abc123";
// // char[] valueArray = value.ToCharArray();
// // Array.Reverse(valueArray);
// // // string result = new string(valueArray);
// // string result = string.Join(",", valueArray);
// // Console.WriteLine(result);

// // string[] items = result.Split(",");
// // foreach (string item in items)
// //     Console.WriteLine(item);

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] pangramArray = pangram.Split(" ");

// for (int i = 0; i < pangramArray.Length; i++)
// {
//     char[] wordArray = pangramArray[i].ToCharArray();
//     Array.Reverse(wordArray);
//     pangramArray[i] = new string(wordArray);
// }

// Console.WriteLine(string.Join(" ", pangramArray));

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIds = orderStream.Split(",");
Array.Sort(orderIds);

foreach (string orderId in orderIds)
{
    Console.Write(orderId);
    if (orderId.Length != 4)
        Console.Write("\t - Error");
    Console.WriteLine();
}