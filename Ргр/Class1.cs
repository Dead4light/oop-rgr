using System;
using System.Collections.Generic;

public class BigInt
{
    private List<char> digits;

    public BigInt()
    {
        digits = new List<char>();
    }

    public BigInt(string number)
    {
        digits = new List<char>(number);
    }

    public BigInt(BigInt other)
    {
        digits = new List<char>(other.digits);
    }

    ~BigInt()
    {
        digits.Clear();
    }

    public void AddDigit(char digit)
    {
        if (char.IsDigit(digit))
        {
            digits.Add(digit);
        }
        else
        {
            throw new ArgumentException("Invalid digit");
        }
    }

    public override string ToString()
    {
        return new string(digits.ToArray());
    }

    public int Length()
    {
        return digits.Count;
    }

    public void SetDigit(int index, char digit)
    {
        if (index < 0 || index >= digits.Count)
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
        if (!char.IsDigit(digit))
        {
            throw new ArgumentException("Invalid digit");
        }
        digits[index] = digit;
    }
}
