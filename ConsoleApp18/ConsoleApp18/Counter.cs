namespace ConsoleApp18;

public class Counter
{
    private int _total;
    private int _threshold;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }

    public void Add(int amount)
    {
        _total += amount;
        if (_total >= _threshold)
        {
            ThresholdReached?.Invoke(this, EventArgs.Empty);
        }
    }

    public event EventHandler ThresholdReached;
}