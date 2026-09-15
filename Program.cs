Console.WriteLine("Please enter a string");
string input = Console.ReadLine();


for (int i = 0; i < input.Length; i++)
{
    if (!char.IsDigit(input[i]))
    {
        continue;
    }

    string number = string.Empty;
    int j = i;
    for (; j < input.Length && char.IsDigit(input[j]); j++)
    {
        number += input[j];
    }

    bool isValid = number[0] == number[number.Length - 1];

    for(int k = 1; k < number.Length - 1; k++)
    {
        if (number[k] == number[0])
        {
            isValid = false;
            break;
        }
    }

    if (isValid)
    {
        for (int k = 0; k < input.Length; k++)
        {
            if (k >= i && k < j)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.Write(input[k]);
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}

