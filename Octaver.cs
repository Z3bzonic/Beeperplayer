namespace BeeperPlayer
{
    internal class Octaver
    {
        public static int IncreaseOctave(Pitch pitch, Octave octave)
        {
            switch (octave)
            {
                case Octave.Four:
                    return (int)pitch;
                case Octave.Five:
                    return (int)pitch * 2;
                case Octave.Six:
                    return (int)pitch * 4;
                case Octave.Seven:
                    return (int)pitch * 8;
                default:
                    throw new NotImplementedException($"{nameof(octave)} : {octave}");
            }
        }
    }
}
