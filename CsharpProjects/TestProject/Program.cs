// // Console.WriteLine("Signed integral types:");

// // Console.WriteLine($"sbyte\t: {sbyte.MinValue} to {sbyte.MaxValue}");
// // Console.WriteLine($"short\t: {short.MinValue} to {short.MaxValue}");
// // Console.WriteLine($"int\t: {int.MinValue} to {int.MaxValue}");
// // Console.WriteLine($"long\t: {long.MinValue} to {long.MaxValue}");

// // Console.WriteLine();
// // System.Console.WriteLine("Unsigned integral types:");

// // Console.WriteLine($"byte\t: {byte.MinValue} to {byte.MaxValue}");
// // Console.WriteLine($"ushort\t: {ushort.MinValue} to {ushort.MaxValue}");
// // Console.WriteLine($"uint\t: {uint.MinValue} to {uint.MaxValue}");
// // Console.WriteLine($"ulong\t: {ulong.MinValue} to {ulong.MaxValue}");

// // Console.WriteLine();
// // Console.WriteLine("Floating point types:");
// // Console.WriteLine($"float\t: {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// // Console.WriteLine($"double\t: {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// // Console.WriteLine($"decimal\t: {decimal.MinValue} to {decimal.MaxValue} (with ~28-29 digits of precision)");

// int[] data = new int[3];
// string shortenedString = "Hello World!";
// Console.WriteLine(shortenedString);

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");