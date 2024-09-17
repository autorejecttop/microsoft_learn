// // // // // // // // string message = "What is the value <span>between the tags</span>";

// // // // // // // // const string openSpan = "<span>";
// // // // // // // // const string closeSpan = "</span>";

// // // // // // // // int openingPosition = message.IndexOf(openSpan);
// // // // // // // // int closingPosition = message.IndexOf(closeSpan);

// // // // // // // // openingPosition += openSpan.Length;
// // // // // // // // int length = closingPosition - openingPosition;
// // // // // // // // Console.WriteLine(message.Substring(openingPosition, length));

// // // // // // // string message = "hello there!";

// // // // // // // int first_h = message.IndexOf('h');
// // // // // // // int last_h = message.LastIndexOf('h');

// // // // // // // System.Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}");

// // // // // // string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// // // // // // int openingPosition = message.LastIndexOf('(');

// // // // // // openingPosition += 1;
// // // // // // int closingPosition = message.LastIndexOf(')');
// // // // // // int length = closingPosition - openingPosition;
// // // // // // Console.WriteLine(message.Substring(openingPosition, length));

// // // // // string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// // // // // while (true)
// // // // // {
// // // // //     int openingPosition = message.IndexOf('(');
// // // // //     if (openingPosition == -1) break;

// // // // //     openingPosition += 1;
// // // // //     int closingPosition = message.IndexOf(')');
// // // // //     int length = closingPosition - openingPosition;
// // // // //     Console.WriteLine(message.Substring(openingPosition, length));

// // // // //     message = message.Substring(closingPosition + 1);
// // // // // }

// // // // string message = "Help (find) the {opening symbols}";
// // // // Console.WriteLine($"Searching THIS message: {message}");
// // // // char[] openSymbols = ['[', '{', '('];
// // // // int startPosition = 5;
// // // // int openingPosition = message.IndexOfAny(openSymbols);
// // // // Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// // // // openingPosition = message.IndexOfAny(openSymbols, startPosition);
// // // // Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

// // // string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // // char[] openSymbols = ['[', '{', '('];

// // // int closingPosition = 0;

// // // while (true)
// // // {
// // //     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
// // //     if (openingPosition == -1)
// // //         break;

// // //     string currentSymbol = message.Substring(openingPosition, 1);

// // //     char matchingSymbol = ' ';

// // //     switch (currentSymbol)
// // //     {
// // //         case "[":
// // //             matchingSymbol = ']';
// // //             break;
// // //         case "{":
// // //             matchingSymbol = '}';
// // //             break;
// // //         case "(":
// // //             matchingSymbol = ')';
// // //             break;
// // //     }

// // //     openingPosition += 1;
// // //     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

// // //     int length = closingPosition - openingPosition;
// // //     Console.WriteLine(message.Substring(openingPosition, length));
// // // }

// // string data = "12345John Smith          5000  3  ";
// // string updatedData = data.Remove(5, 20);
// // Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int quantityOpeningPosition = input.IndexOf("<span>");
int quantityClosingPosition = input.IndexOf("</span>");

quantityOpeningPosition += "<span>".Length;

int quantityLength = quantityClosingPosition - quantityOpeningPosition;
quantity = input.Substring(quantityOpeningPosition, quantityLength);

int outputOpeningPosition = input.IndexOf("<div>");
int outputClosingPosition = input.IndexOf("</div>");

outputOpeningPosition += "<div>".Length;

int outputLength = outputClosingPosition - outputOpeningPosition;

output = input.Substring(outputOpeningPosition, outputLength).Replace("&trade;", "&reg;");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");