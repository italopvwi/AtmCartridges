var amounts = new List<int> { 30, 50, 60, 80, 140, 230, 370, 610, 980 };

foreach (var amount in amounts)
{
    Console.WriteLine($"Finding combinations for: {amount} EUR");
    
    foreach (var combination in CalculateCombinations(amount))
    {
        Console.WriteLine($"- {combination}");
    }
}

Console.WriteLine("Press any key to leave close the program.");
Console.ReadKey();
return;


static IEnumerable<string> CalculateCombinations(int amount)
{
    var max100S = amount / 100;
    var max50S = amount / 50;
    var max10S = amount / 10;

    for (var num100S = 0; num100S <= max100S; num100S++)
    {
        for (var num50S = 0; num50S <= max50S; num50S++)
        {
            for (var num10S = 0; num10S <= max10S; num10S++)
            {
                var hundredQuantity = (num100S * 100);
                var fiftyQuantity = (num50S * 50);
                var tenQuantity = (num10S * 10);
                
                if (hundredQuantity + fiftyQuantity + tenQuantity != amount)
                {
                    continue;
                }

                var hundredText = hundredQuantity > 0 ? $"{num100S} x 100 EUR + " : string.Empty;
                var fiftyText = fiftyQuantity > 0 ? $"{num50S} x 50 EUR + " : string.Empty;
                var tenText = tenQuantity > 0 ? $"{num10S} x 10 EUR" : string.Empty;

                yield return $"{hundredText}{fiftyText}{tenText}".Trim(' ').Trim('+').Trim(' ');
            }
        }
    }
}

/*
 OUTPUT:
   Finding combinations for: 30 EUR
   - 3 x 10 EUR
   Finding combinations for: 50 EUR
   - 5 x 10 EUR
   - 1 x 50 EUR
   Finding combinations for: 60 EUR
   - 6 x 10 EUR
   - 1 x 50 EUR + 1 x 10 EUR
   Finding combinations for: 80 EUR
   - 8 x 10 EUR
   - 1 x 50 EUR + 3 x 10 EUR
   Finding combinations for: 140 EUR
   - 14 x 10 EUR
   - 1 x 50 EUR + 9 x 10 EUR
   - 2 x 50 EUR + 4 x 10 EUR
   - 1 x 100 EUR + 4 x 10 EUR
   Finding combinations for: 230 EUR
   - 23 x 10 EUR
   - 1 x 50 EUR + 18 x 10 EUR
   - 2 x 50 EUR + 13 x 10 EUR
   - 3 x 50 EUR + 8 x 10 EUR
   - 4 x 50 EUR + 3 x 10 EUR
   - 1 x 100 EUR + 13 x 10 EUR
   - 1 x 100 EUR + 1 x 50 EUR + 8 x 10 EUR
   - 1 x 100 EUR + 2 x 50 EUR + 3 x 10 EUR
   - 2 x 100 EUR + 3 x 10 EUR
   Finding combinations for: 370 EUR
   - 37 x 10 EUR
   - 1 x 50 EUR + 32 x 10 EUR
   - 2 x 50 EUR + 27 x 10 EUR
   - 3 x 50 EUR + 22 x 10 EUR
   - 4 x 50 EUR + 17 x 10 EUR
   - 5 x 50 EUR + 12 x 10 EUR
   - 6 x 50 EUR + 7 x 10 EUR
   - 7 x 50 EUR + 2 x 10 EUR
   - 1 x 100 EUR + 27 x 10 EUR
   - 1 x 100 EUR + 1 x 50 EUR + 22 x 10 EUR
   - 1 x 100 EUR + 2 x 50 EUR + 17 x 10 EUR
   - 1 x 100 EUR + 3 x 50 EUR + 12 x 10 EUR
   - 1 x 100 EUR + 4 x 50 EUR + 7 x 10 EUR
   - 1 x 100 EUR + 5 x 50 EUR + 2 x 10 EUR
   - 2 x 100 EUR + 17 x 10 EUR
   - 2 x 100 EUR + 1 x 50 EUR + 12 x 10 EUR
   - 2 x 100 EUR + 2 x 50 EUR + 7 x 10 EUR
   - 2 x 100 EUR + 3 x 50 EUR + 2 x 10 EUR
   - 3 x 100 EUR + 7 x 10 EUR
   - 3 x 100 EUR + 1 x 50 EUR + 2 x 10 EUR
   Finding combinations for: 610 EUR
   - 61 x 10 EUR
   - 1 x 50 EUR + 56 x 10 EUR
   - 2 x 50 EUR + 51 x 10 EUR
   - 3 x 50 EUR + 46 x 10 EUR
   - 4 x 50 EUR + 41 x 10 EUR
   - 5 x 50 EUR + 36 x 10 EUR
   - 6 x 50 EUR + 31 x 10 EUR
   - 7 x 50 EUR + 26 x 10 EUR
   - 8 x 50 EUR + 21 x 10 EUR
   - 9 x 50 EUR + 16 x 10 EUR
   - 10 x 50 EUR + 11 x 10 EUR
   - 11 x 50 EUR + 6 x 10 EUR
   - 12 x 50 EUR + 1 x 10 EUR
   - 1 x 100 EUR + 51 x 10 EUR
   - 1 x 100 EUR + 1 x 50 EUR + 46 x 10 EUR
   - 1 x 100 EUR + 2 x 50 EUR + 41 x 10 EUR
   - 1 x 100 EUR + 3 x 50 EUR + 36 x 10 EUR
   - 1 x 100 EUR + 4 x 50 EUR + 31 x 10 EUR
   - 1 x 100 EUR + 5 x 50 EUR + 26 x 10 EUR
   - 1 x 100 EUR + 6 x 50 EUR + 21 x 10 EUR
   - 1 x 100 EUR + 7 x 50 EUR + 16 x 10 EUR
   - 1 x 100 EUR + 8 x 50 EUR + 11 x 10 EUR
   - 1 x 100 EUR + 9 x 50 EUR + 6 x 10 EUR
   - 1 x 100 EUR + 10 x 50 EUR + 1 x 10 EUR
   - 2 x 100 EUR + 41 x 10 EUR
   - 2 x 100 EUR + 1 x 50 EUR + 36 x 10 EUR
   - 2 x 100 EUR + 2 x 50 EUR + 31 x 10 EUR
   - 2 x 100 EUR + 3 x 50 EUR + 26 x 10 EUR
   - 2 x 100 EUR + 4 x 50 EUR + 21 x 10 EUR
   - 2 x 100 EUR + 5 x 50 EUR + 16 x 10 EUR
   - 2 x 100 EUR + 6 x 50 EUR + 11 x 10 EUR
   - 2 x 100 EUR + 7 x 50 EUR + 6 x 10 EUR
   - 2 x 100 EUR + 8 x 50 EUR + 1 x 10 EUR
   - 3 x 100 EUR + 31 x 10 EUR
   - 3 x 100 EUR + 1 x 50 EUR + 26 x 10 EUR
   - 3 x 100 EUR + 2 x 50 EUR + 21 x 10 EUR
   - 3 x 100 EUR + 3 x 50 EUR + 16 x 10 EUR
   - 3 x 100 EUR + 4 x 50 EUR + 11 x 10 EUR
   - 3 x 100 EUR + 5 x 50 EUR + 6 x 10 EUR
   - 3 x 100 EUR + 6 x 50 EUR + 1 x 10 EUR
   - 4 x 100 EUR + 21 x 10 EUR
   - 4 x 100 EUR + 1 x 50 EUR + 16 x 10 EUR
   - 4 x 100 EUR + 2 x 50 EUR + 11 x 10 EUR
   - 4 x 100 EUR + 3 x 50 EUR + 6 x 10 EUR
   - 4 x 100 EUR + 4 x 50 EUR + 1 x 10 EUR
   - 5 x 100 EUR + 11 x 10 EUR
   - 5 x 100 EUR + 1 x 50 EUR + 6 x 10 EUR
   - 5 x 100 EUR + 2 x 50 EUR + 1 x 10 EUR
   - 6 x 100 EUR + 1 x 10 EUR
   Finding combinations for: 980 EUR
   - 98 x 10 EUR
   - 1 x 50 EUR + 93 x 10 EUR
   - 2 x 50 EUR + 88 x 10 EUR
   - 3 x 50 EUR + 83 x 10 EUR
   - 4 x 50 EUR + 78 x 10 EUR
   - 5 x 50 EUR + 73 x 10 EUR
   - 6 x 50 EUR + 68 x 10 EUR
   - 7 x 50 EUR + 63 x 10 EUR
   - 8 x 50 EUR + 58 x 10 EUR
   - 9 x 50 EUR + 53 x 10 EUR
   - 10 x 50 EUR + 48 x 10 EUR
   - 11 x 50 EUR + 43 x 10 EUR
   - 12 x 50 EUR + 38 x 10 EUR
   - 13 x 50 EUR + 33 x 10 EUR
   - 14 x 50 EUR + 28 x 10 EUR
   - 15 x 50 EUR + 23 x 10 EUR
   - 16 x 50 EUR + 18 x 10 EUR
   - 17 x 50 EUR + 13 x 10 EUR
   - 18 x 50 EUR + 8 x 10 EUR
   - 19 x 50 EUR + 3 x 10 EUR
   - 1 x 100 EUR + 88 x 10 EUR
   - 1 x 100 EUR + 1 x 50 EUR + 83 x 10 EUR
   - 1 x 100 EUR + 2 x 50 EUR + 78 x 10 EUR
   - 1 x 100 EUR + 3 x 50 EUR + 73 x 10 EUR
   - 1 x 100 EUR + 4 x 50 EUR + 68 x 10 EUR
   - 1 x 100 EUR + 5 x 50 EUR + 63 x 10 EUR
   - 1 x 100 EUR + 6 x 50 EUR + 58 x 10 EUR
   - 1 x 100 EUR + 7 x 50 EUR + 53 x 10 EUR
   - 1 x 100 EUR + 8 x 50 EUR + 48 x 10 EUR
   - 1 x 100 EUR + 9 x 50 EUR + 43 x 10 EUR
   - 1 x 100 EUR + 10 x 50 EUR + 38 x 10 EUR
   - 1 x 100 EUR + 11 x 50 EUR + 33 x 10 EUR
   - 1 x 100 EUR + 12 x 50 EUR + 28 x 10 EUR
   - 1 x 100 EUR + 13 x 50 EUR + 23 x 10 EUR
   - 1 x 100 EUR + 14 x 50 EUR + 18 x 10 EUR
   - 1 x 100 EUR + 15 x 50 EUR + 13 x 10 EUR
   - 1 x 100 EUR + 16 x 50 EUR + 8 x 10 EUR
   - 1 x 100 EUR + 17 x 50 EUR + 3 x 10 EUR
   - 2 x 100 EUR + 78 x 10 EUR
   - 2 x 100 EUR + 1 x 50 EUR + 73 x 10 EUR
   - 2 x 100 EUR + 2 x 50 EUR + 68 x 10 EUR
   - 2 x 100 EUR + 3 x 50 EUR + 63 x 10 EUR
   - 2 x 100 EUR + 4 x 50 EUR + 58 x 10 EUR
   - 2 x 100 EUR + 5 x 50 EUR + 53 x 10 EUR
   - 2 x 100 EUR + 6 x 50 EUR + 48 x 10 EUR
   - 2 x 100 EUR + 7 x 50 EUR + 43 x 10 EUR
   - 2 x 100 EUR + 8 x 50 EUR + 38 x 10 EUR
   - 2 x 100 EUR + 9 x 50 EUR + 33 x 10 EUR
   - 2 x 100 EUR + 10 x 50 EUR + 28 x 10 EUR
   - 2 x 100 EUR + 11 x 50 EUR + 23 x 10 EUR
   - 2 x 100 EUR + 12 x 50 EUR + 18 x 10 EUR
   - 2 x 100 EUR + 13 x 50 EUR + 13 x 10 EUR
   - 2 x 100 EUR + 14 x 50 EUR + 8 x 10 EUR
   - 2 x 100 EUR + 15 x 50 EUR + 3 x 10 EUR
   - 3 x 100 EUR + 68 x 10 EUR
   - 3 x 100 EUR + 1 x 50 EUR + 63 x 10 EUR
   - 3 x 100 EUR + 2 x 50 EUR + 58 x 10 EUR
   - 3 x 100 EUR + 3 x 50 EUR + 53 x 10 EUR
   - 3 x 100 EUR + 4 x 50 EUR + 48 x 10 EUR
   - 3 x 100 EUR + 5 x 50 EUR + 43 x 10 EUR
   - 3 x 100 EUR + 6 x 50 EUR + 38 x 10 EUR
   - 3 x 100 EUR + 7 x 50 EUR + 33 x 10 EUR
   - 3 x 100 EUR + 8 x 50 EUR + 28 x 10 EUR
   - 3 x 100 EUR + 9 x 50 EUR + 23 x 10 EUR
   - 3 x 100 EUR + 10 x 50 EUR + 18 x 10 EUR
   - 3 x 100 EUR + 11 x 50 EUR + 13 x 10 EUR
   - 3 x 100 EUR + 12 x 50 EUR + 8 x 10 EUR
   - 3 x 100 EUR + 13 x 50 EUR + 3 x 10 EUR
   - 4 x 100 EUR + 58 x 10 EUR
   - 4 x 100 EUR + 1 x 50 EUR + 53 x 10 EUR
   - 4 x 100 EUR + 2 x 50 EUR + 48 x 10 EUR
   - 4 x 100 EUR + 3 x 50 EUR + 43 x 10 EUR
   - 4 x 100 EUR + 4 x 50 EUR + 38 x 10 EUR
   - 4 x 100 EUR + 5 x 50 EUR + 33 x 10 EUR
   - 4 x 100 EUR + 6 x 50 EUR + 28 x 10 EUR
   - 4 x 100 EUR + 7 x 50 EUR + 23 x 10 EUR
   - 4 x 100 EUR + 8 x 50 EUR + 18 x 10 EUR
   - 4 x 100 EUR + 9 x 50 EUR + 13 x 10 EUR
   - 4 x 100 EUR + 10 x 50 EUR + 8 x 10 EUR
   - 4 x 100 EUR + 11 x 50 EUR + 3 x 10 EUR
   - 5 x 100 EUR + 48 x 10 EUR
   - 5 x 100 EUR + 1 x 50 EUR + 43 x 10 EUR
   - 5 x 100 EUR + 2 x 50 EUR + 38 x 10 EUR
   - 5 x 100 EUR + 3 x 50 EUR + 33 x 10 EUR
   - 5 x 100 EUR + 4 x 50 EUR + 28 x 10 EUR
   - 5 x 100 EUR + 5 x 50 EUR + 23 x 10 EUR
   - 5 x 100 EUR + 6 x 50 EUR + 18 x 10 EUR
   - 5 x 100 EUR + 7 x 50 EUR + 13 x 10 EUR
   - 5 x 100 EUR + 8 x 50 EUR + 8 x 10 EUR
   - 5 x 100 EUR + 9 x 50 EUR + 3 x 10 EUR
   - 6 x 100 EUR + 38 x 10 EUR
   - 6 x 100 EUR + 1 x 50 EUR + 33 x 10 EUR
   - 6 x 100 EUR + 2 x 50 EUR + 28 x 10 EUR
   - 6 x 100 EUR + 3 x 50 EUR + 23 x 10 EUR
   - 6 x 100 EUR + 4 x 50 EUR + 18 x 10 EUR
   - 6 x 100 EUR + 5 x 50 EUR + 13 x 10 EUR
   - 6 x 100 EUR + 6 x 50 EUR + 8 x 10 EUR
   - 6 x 100 EUR + 7 x 50 EUR + 3 x 10 EUR
   - 7 x 100 EUR + 28 x 10 EUR
   - 7 x 100 EUR + 1 x 50 EUR + 23 x 10 EUR
   - 7 x 100 EUR + 2 x 50 EUR + 18 x 10 EUR
   - 7 x 100 EUR + 3 x 50 EUR + 13 x 10 EUR
   - 7 x 100 EUR + 4 x 50 EUR + 8 x 10 EUR
   - 7 x 100 EUR + 5 x 50 EUR + 3 x 10 EUR
   - 8 x 100 EUR + 18 x 10 EUR
   - 8 x 100 EUR + 1 x 50 EUR + 13 x 10 EUR
   - 8 x 100 EUR + 2 x 50 EUR + 8 x 10 EUR
   - 8 x 100 EUR + 3 x 50 EUR + 3 x 10 EUR
   - 9 x 100 EUR + 8 x 10 EUR
   - 9 x 100 EUR + 1 x 50 EUR + 3 x 10 EUR
   Press any key to leave close the program.
 */