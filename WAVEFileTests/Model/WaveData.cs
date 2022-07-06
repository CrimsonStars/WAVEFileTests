using System;
using System.Collections.Generic;
using System.Text;

namespace WAVEFileTests.Model
{
    public class WaveData
    {
        public string Name { get; set; }
        public int Bitrate { get; set; }
        public int Length { get; set; }
        public int Frequency { get; set; }

        public WaveData()
        {
            Name = "Sample_wave_file";
            Bitrate = 0;
            Length = 0;
            Frequency = 440;
        }
    }
}
