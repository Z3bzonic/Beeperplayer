namespace BeeperPlayer.Output
{
    public class RealBeeper : IBeeper
    {
        public void PlayNote(int pitch, int speed)
        {
            if (pitch == 0)
                Thread.Sleep(speed);
            else
                Console.Beep(pitch, speed);
        }
    }
}
