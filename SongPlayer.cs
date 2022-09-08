using BeeperPlayer.Output;

namespace BeeperPlayer
{
    public class SongPlayer
    {
        public SongPlayer(IBeeper beeper)
        {
            Beeper = beeper;
        }

        public IBeeper Beeper { get; }

        /// <summary>
        /// note - octavepicker (0 for C4to B4 - rythmpicker(safe till 2 on tempo 1000 result 127ms, will become buggy on most HW)
        /// </summary>
        /// <param name="song"></param>
        public void PlaySong(Song song)
        {
            foreach (var note in song.Notes)
            {
                var finalPitch = Octaver.IncreaseOctave(note.Pitch, note.Octave);
                var finalTempo = RythmDivider.DivideRythm(note.Rythm, song.Tempo);
                Beeper.PlayNote(finalPitch, finalTempo);
                //var note = song[i, 0];
                //var octUp = song[i, 0 + 1];
                //if (playing != "RandomSong")
                //    {
                //    noteDisplay.DisplayNotes(note,octUp);
                //    }
            }
        }

        //public void PlaySong(int[,] song, int tempo = 1000, string lyrics = "") // skipping lyrics -- not seen object types yet
        //{
        //    //NoteDisplay noteDisplay = new NoteDisplay();
        //    //string playing = Songs.nowPlaying;

        //    // note - octavepicker (0 for C4to B4 - rythmpicker(safe till 2 on tempo 1000 result 127ms, will become buggy on most HW) 
        //    for (var i = 0; i < song.Length / 3; i++) //song.Length/3 omdat hij de total lenght doet maar gezien er 3 kolommen zijn...
        //    {
        //        var finalPitch = Octaver.IncreaseOctave(song[i, 0], song[i, 0 + 1]);
        //        var finalTempo = RythmDivider.DivideRythm(song[i, 0 + 2], tempo);
        //        BeeperOutput.PlayNote(finalPitch, finalTempo);
        //        //var note = song[i, 0];
        //        //var octUp = song[i, 0 + 1];
        //        //if (playing != "RandomSong")
        //        //    {
        //        //    noteDisplay.DisplayNotes(note,octUp);
        //        //    }
        //    }
        //}
    }
}
