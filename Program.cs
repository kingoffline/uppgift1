Console.WriteLine("Ange en sträng...!");
string input = Console.ReadLine();

List<long> correctNumbers = new List<long>();

for (int i = 0; i < input.Length; i++)
{
    // börja loopen där värde på indexen är ett tal 
    if (char.IsDigit(input[i]))
    {
        // Den här loopen letar framåt i strängen från tecknet efter input[i] så länge nästa talet är ett tal. 
        for (int j = 1 + i; j < input.Length; j++)
        {
            if (!char.IsDigit(input[j]))
            {
                break;
            } 
            // om nuvarande talet är lika med input[i], vi loopar igenom sträng igen och byter färgen på allt
            // där i mellan till rött och resten till grå, samtidigt lägger till korrekta tal i en sträng för att senare
            // ska läggas till correctNumbers listan.
            if (input[i] == input[j])
            {
                string substring = string.Empty;
                for (int k = 0; k < input.Length; k++)
                {
                    if (k >= i && k <= j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        substring += input[k];
                        
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(input[k]);
                }
                correctNumbers.Add(long.Parse(substring));
                Console.WriteLine();
                break;
            }
        }
    }
}

// Skriver ut summan av hittade siffror.
long sum = correctNumbers.Sum();
Console.WriteLine($"Summan är {sum}");
