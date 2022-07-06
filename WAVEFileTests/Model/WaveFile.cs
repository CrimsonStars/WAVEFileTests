using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WAVEFileTests.Model
{
    internal class WaveFile
    {
        public WaveData Data { get; private set; }
        public string Folder { get; set; }
        public string Filename { get; set; }

        public WaveFile(string FOLDER, string FILENAME, WaveData DATA)
        {
            this.Folder = FOLDER;
            this.Filename = FILENAME;
            this.Data = DATA;
        }

        public void GenerateFile()
        {
            FileStream fs = File.Create(Path.Combine(Folder, Filename, ".wav"));



            fs.Close();
        }
    }
}
