namespace BeeperPlayer.Output
{
    public class ConsoleBeeper : IBeeper
    {
        public void PlayNote(int pitch, int speed)
        {
            Console.WriteLine($"{nameof(pitch)} : {pitch}, {nameof(speed)} : {speed}");
        }
    }
}
