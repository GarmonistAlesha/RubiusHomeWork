
class Pong
{
    public event EventHandler PongEvent;

    public void SendPong()
    {
        Console.WriteLine("Pong отправил Понг");
        PongEvent?.Invoke(this, EventArgs.Empty);
    }

    public void ReceivePing()
    {
        Console.WriteLine("Pong получил Пинг");
    }

    public void Missed()
    {
        Console.WriteLine("Pong промахнулся! Победил Ping");
    }
}
