class Program
{
    static void Main()
    {
        Ping ping = new Ping();
        Pong pong = new Pong();

        ping.PingEvent += (sender, e) =>
        {
            if (new Random().Next(2) == 0)
            {
                pong.ReceivePing();
                pong.SendPong();
            }
            else
            {
                pong.Missed();
            }
        };

        pong.PongEvent += (sender, e) =>
        {
            if (new Random().Next(2) == 0)
            {
                ping.ReceivePong();
                ping.SendPing();
            }
            else
            {
                ping.Missed();
            }
        };

        ping.SendPing();
    }
}

