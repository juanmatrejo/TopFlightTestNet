//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Exercise 1

using System.Text;

int[] centeredArray1 = new int[] { 1, 2, 3, 4, 5 };
int[] centeredArray2 = new int[] { 3, 2, 1, 4, 5 };
int[] centeredArray3 = new int[] { 3, 2, 1, 4, 1 };
int[] centeredArray4 = new int[] { 1, 2, 3, 4 };
int[] centeredArray5 = new int[] { };
int[] centeredArray6 = new int[] { 10 };

Console.WriteLine("Centered Array");
Console.WriteLine();
Console.WriteLine($@"[ {string.Join(", ", centeredArray1)} ]  =>  {CenteredArray(centeredArray1)}");
Console.WriteLine($@"[ {string.Join(", ", centeredArray2)} ]  =>  {CenteredArray(centeredArray2)}");
Console.WriteLine($@"[ {string.Join(", ", centeredArray3)} ]  =>  {CenteredArray(centeredArray3)}");
Console.WriteLine($@"[ {string.Join(", ", centeredArray4)} ]  =>  {CenteredArray(centeredArray4)}");
Console.WriteLine($@"[ {string.Join(", ", centeredArray5)} ]  =>  {CenteredArray(centeredArray5)}");
Console.WriteLine($@"[ {string.Join(", ", centeredArray6)} ]  =>  {CenteredArray(centeredArray6)}");
Console.WriteLine();
Console.WriteLine();

int CenteredArray(int[] input)
{
    if (input.Length.Equals(0) ||
        (input.Length % 2).Equals(0))
    { return 0; }

    if (input.Length.Equals(1))
    { return 1; }

    int middle = input.Length / 2;
    int minor = input[middle];

    for (int idx = 0; idx < input.Length; idx++)
    {
        if (!middle.Equals(idx) &&
            minor >= input[idx])
        { return 0; }
    }

    return 1;
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Exercise 2

int value1 = 1234;
int value2 = 12005;
int value3 = 1;
int value4 = 1000;
int value5 = 0;
int value6 = -12345;

Console.WriteLine("Reversed Value");
Console.WriteLine();
Console.WriteLine($@"[ {value1} ]  =>  {ReversedValue(value1)}");
Console.WriteLine($@"[ {value2} ]  =>  {ReversedValue(value2)}");
Console.WriteLine($@"[ {value3} ]  =>  {ReversedValue(value3)}");
Console.WriteLine($@"[ {value4} ]  =>  {ReversedValue(value4)}");
Console.WriteLine($@"[ {value5} ]  =>  {ReversedValue(value5)}");
Console.WriteLine($@"[ {value6} ]  =>  {ReversedValue(value6)}");
Console.WriteLine();
Console.WriteLine();

int ReversedValue(int input)
{
    bool isNegative = false;
    if (input < 0)
    {
        isNegative = true;
        input *= -1;
    }

    string value = input.ToString();
    StringBuilder result = new StringBuilder();

    for (int idx = value.Length - 1; idx >= 0; idx--)
    { result.Append(value[idx]); }

    if (isNegative)
    { return int.Parse(result.ToString()) * -1; }
    else
    { return int.Parse(result.ToString()); }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Exercise 3

int[] EvensOdds1 = new int[] { 1 };
int[] EvensOdds2 = new int[] { 1, 2 };
int[] EvensOdds3 = new int[] { 1, 2, 3 };
int[] EvensOdds4 = new int[] { 1, 2, 3, 4 };
int[] EvensOdds5 = new int[] { 3, 3, 4, 4 };
int[] EvensOdds6 = new int[] { 3, 2, 3, 4 };
int[] EvensOdds7 = new int[] { 4, 1, 2, 3 };
int[] EvensOdds8 = new int[] { 1, 1 };
int[] EvensOdds9 = new int[] { };

Console.WriteLine("Sum Even & Odd Numbers");
Console.WriteLine();
Console.WriteLine($@"[ {string.Join(", ", EvensOdds1)} ]  =>  {SumEvensOdds(EvensOdds1)}");
Console.WriteLine($@"[ {string.Join(", ", EvensOdds2)} ]  =>  {SumEvensOdds(EvensOdds2)}");
Console.WriteLine($@"[ {string.Join(", ", EvensOdds3)} ]  =>  {SumEvensOdds(EvensOdds3)}");
Console.WriteLine($@"[ {string.Join(", ", EvensOdds4)} ]  =>  {SumEvensOdds(EvensOdds4)}");
Console.WriteLine($@"[ {string.Join(", ", EvensOdds5)} ]  =>  {SumEvensOdds(EvensOdds5)}");
Console.WriteLine($@"[ {string.Join(", ", EvensOdds6)} ]  =>  {SumEvensOdds(EvensOdds6)}");
Console.WriteLine($@"[ {string.Join(", ", EvensOdds7)} ]  =>  {SumEvensOdds(EvensOdds7)}");
Console.WriteLine($@"[ {string.Join(", ", EvensOdds8)} ]  =>  {SumEvensOdds(EvensOdds8)}");
Console.WriteLine($@"[ {string.Join(", ", EvensOdds9)} ]  =>  {SumEvensOdds(EvensOdds9)}");
Console.WriteLine();
Console.WriteLine();

int SumEvensOdds(int[] input)
{
    int odds = input.Where(x => !(x % 2).Equals(0)).Sum(x => x);
    int evens = input.Where(x => (x % 2).Equals(0)).Sum(x => x);

    return odds - evens;
}
