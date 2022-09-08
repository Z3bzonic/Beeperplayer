namespace BeeperPlayer
{
    public class Note
    {
        public Note(Pitch pitch, Octave octave, Rythm rythm)
        {
            Pitch = pitch;
            Octave = octave;
            Rythm = rythm;
        }

        public Pitch Pitch { get; set; }
        public Octave Octave { get; set; }
        public Rythm Rythm { get; set; }
    }
}