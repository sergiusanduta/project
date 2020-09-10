using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FS
{
    public class NotesStorage
    {
        public List<string> GetNote(string path)
        {
            List<string> allLines = File.ReadAllLines(path).ToList();
            return allLines;
        }

        public void SaveNote (string note, string path) // path = "C:/Program Files/mynotes.txt";
        {
            File.AppendAllText(path, note + Environment.NewLine);
        }
    }
     
}
