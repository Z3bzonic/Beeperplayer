namespace BeeperPlayer
{
    internal class RythmDivider
    {
        /// <summary>
        /// speed 4 = play full note from tempo convienint for keeping the ints
        /// </summary>
        /// <param name="rythm"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public static int DivideRythm(Rythm rythm, int tempo)
        {
            switch (rythm)
            {
                case Rythm.Thirtytwos:
                    return tempo / 32;
                case Rythm.Sixtenths:
                    return tempo / 16;
                case Rythm.Eights:
                    return tempo / 8;
                case Rythm.Quarter:
                    return tempo / 4;
                case Rythm.WholeNote:
                    return tempo / 2;
                case Rythm.Doubles:
                    return tempo;
                case Rythm.OneBar:
                    return tempo * 2;
                case Rythm.TwoBars:
                    return tempo * 4;
                default:
                    throw new NotImplementedException($"{nameof(rythm)} : {rythm}");
            }
        }
    }
}