public class Counter
{
    public event EventHandler ThresholdReached;

    public void CountTo100()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine($"Counting: {i}");

            if (i == 77)
            {
                OnThresholdReached();
            }
        }
    }

    protected virtual void OnThresholdReached()
    {
        ThresholdReached?.Invoke(this, EventArgs.Empty);
    }
}