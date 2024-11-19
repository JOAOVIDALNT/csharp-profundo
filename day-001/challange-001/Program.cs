

static int CountBits(int n = 4)
{
    decimal dec = Convert.ToDecimal(n);

    var array = decimal.GetBits(dec);

    var count = 0;

    foreach (var bit in array)
    {
        if (bit == 1)
            count++;
    }

    return count;
}

Console.WriteLine(CountBits());