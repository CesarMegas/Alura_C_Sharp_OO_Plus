namespace MelodyFlow.Models;

internal class Review
{
    public Review(int rate)
    {
        if (rate <= 0) rate = 0;
        if (rate >= 10) rate = 10;
        Rate = rate;
    }

    public int Rate { get; }

    public static Review Parse(string text)
    {
        int rate = int.Parse(text);
        return new Review(rate);
    }
}
