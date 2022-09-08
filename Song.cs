namespace BeeperPlayer
{
    public class Song
    {
        public Song(int tempo, List<Note> notes)
        {
            Tempo = tempo;
            Notes = notes;
        }

        public int Tempo { get; set; }
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
