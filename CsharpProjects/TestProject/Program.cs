// // // // // // // // string first = "Hello";
// // // // // // // // string second = "World";
// // // // // // // // Console.WriteLine($"{first} {second}!");
// // // // // // // // Console.WriteLine($"{second} {first}!");
// // // // // // // // Console.WriteLine($"{first} {first} {first}!");

// // // // // // // decimal price = 123.45m;
// // // // // // // int discount = 50;
// // // // // // // Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// // // // // // decimal measurement = 123456.78912m;
// // // // // // Console.WriteLine($"Measurement: {measurement:N} units");

// // // // // decimal tax = .36785m;
// // // // // Console.WriteLine($"Tax rate: {tax:P2}");

// // // // decimal price = 67.55m;
// // // // decimal salePrice = 59.99m;

// // // // string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", price - salePrice, price);

// // // // yourDiscount += $"A discount of {(price - salePrice) / price:P2}!";
// // // // Console.WriteLine(yourDiscount);

// // // int invoiceNumber = 1201;
// // // decimal productShares = 25.4568m;
// // // decimal subtotal = 2750m;
// // // decimal taxPercentage = 0.15825m;
// // // decimal total = 3185.19m;

// // // Console.WriteLine($"Invoice Number: {invoiceNumber}");
// // // Console.WriteLine($"   Shares: {productShares:N3} Product");
// // // Console.WriteLine($"     Sub Total: {subtotal:C}");
// // // Console.WriteLine($"           Tax: {taxPercentage:P2}");
// // // Console.WriteLine($"     Total Billed: {total:C}");


// // string input = "Pad this";
// // Console.WriteLine(input.PadLeft(12, '-'));
// // Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// string formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine();
Console.WriteLine($"Currently, you own ${currentShares:N} shares at a return of {currentReturn:P2}");
Console.WriteLine();
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}");
Console.WriteLine();

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
string formattedCurrentReturn = string.Format("{0:P2}", currentReturn);
string formattedCurrentProfit = string.Format("{0:C2}", currentProfit);
string formattedNewReturn = string.Format("{0:P2}", newReturn);
string formattedNewProfit = string.Format("{0:C2}", newProfit);
comparisonMessage += $"{currentProduct.PadRight(17)}{formattedCurrentReturn.PadLeft(10)}{formattedCurrentProfit.PadLeft(17)}\n";
comparisonMessage += $"{newProduct.PadRight(17)}{formattedNewReturn.PadLeft(10)}{formattedNewProfit.PadLeft(17)}";

Console.WriteLine(comparisonMessage);