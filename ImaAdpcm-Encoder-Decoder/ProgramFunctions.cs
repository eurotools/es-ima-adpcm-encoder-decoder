using NAudio.Wave;
using System;
using System.IO;

namespace ImaAdpcm_Tool
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal static class ProgramFunctions
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void ExecuteEncoder(string inputFile, string outputFile)
        {
            string fileExtension = Path.GetExtension(inputFile);
            if (fileExtension.Equals(".wav", StringComparison.OrdinalIgnoreCase))
            {
                short[] pcmData;
                int frequency, channels;

                //Get File Data
                using (WaveFileReader reader = new WaveFileReader(inputFile))
                {
                    //Get basic info
                    frequency = reader.WaveFormat.SampleRate;
                    channels = reader.WaveFormat.Channels;

                    //Get pcm short array
                    byte[] pcmByteData = new byte[reader.Length];
                    reader.Read(pcmByteData, 0, pcmByteData.Length);
                    pcmData = WavFunctions.ConvertByteArrayToShortArray(pcmByteData);
                }

                //Start encode!
                byte[] adpcmData = ImaCodec.Encode(pcmData);

                //Write File
                File.WriteAllBytes(outputFile, adpcmData);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void ExecuteDecoder(string inputFile, string outputFile, int sampleRate)
        {
            string fileExtension = Path.GetExtension(inputFile);
            if (fileExtension.Equals(".wav", StringComparison.OrdinalIgnoreCase))
            {
                byte[] imaData = File.ReadAllBytes(inputFile);

                //Start decoding!
                byte[] pcmData = WavFunctions.ShortArrayToByteArray(ImaCodec.Decode(imaData, imaData.Length * 2));

                //Save file
                IWaveProvider provider = new RawSourceWaveStream(new MemoryStream(pcmData), new WaveFormat(sampleRate, 16, 1));
                try
                {
                    WaveFileWriter.CreateWaveFile(outputFile, provider);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static bool CheckFileExists(string filePath)
        {
            bool fileExists = false;

            if (File.Exists(filePath))
            {
                fileExists = true;
            }
            else
            {
                Console.WriteLine("ERROR: file not found: " + filePath);
            }

            return fileExists;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
