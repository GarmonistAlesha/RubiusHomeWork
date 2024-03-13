
class Ping
{
    public event EventHandler PingEvent;

    public void SendPing()
    {
        Console.WriteLine("Ping отправил Пинг");
        PingEvent?.Invoke(this, EventArgs.Empty);
    }

    public void ReceivePong()
    {
        Console.WriteLine("Ping получил Понг");
    }

    public void Missed()
    {
        Console.WriteLine("Ping промахнулся! Победил Pong");
    }
}