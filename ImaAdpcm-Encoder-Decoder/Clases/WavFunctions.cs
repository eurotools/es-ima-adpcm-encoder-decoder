using NAudio.Wave;
using System.IO;

namespace ImaAdpcm_Encoder_Decoder
{
    internal class WavFunctions
    {
        internal static short[] GetPcmDataWavFile(string filePath, int bits)
        {
            short[] samplesShort = null;

            try
            {
                using (WaveFileReader fileReader = new WaveFileReader(filePath))
                {
                    if (fileReader.WaveFormat.BitsPerSample == bits && fileReader.WaveFormat.Encoding == WaveFormatEncoding.Pcm)
                    {
                        samplesShort = new short[fileReader.Length / 2];
                        byte[] pcmData = new byte[fileReader.Length];
                        fileReader.Read(pcmData, 0, (int)fileReader.Length);

                        WaveBuffer sourceWaveBuffer = new WaveBuffer(pcmData);
                        for (int i = 0; i < samplesShort.Length; i++)
                        {
                            samplesShort[i] = sourceWaveBuffer.ShortBuffer[i];
                        }
                    }
                }
            }
            catch
            {

            }
            return samplesShort;
        }

        internal static short[] SplitWavChannels(short[] inputChannel, bool leftChannel)
        {
            short[] channelData = new short[inputChannel.Length / 2];
            int channelDataIndex = 0;

            for (int i = 0; i < inputChannel.Length; i++)
            {
                if (leftChannel)
                {
                    channelData[channelDataIndex] = inputChannel[i];
                    channelDataIndex++;
                }
                leftChannel = !leftChannel;
            }

            return channelData;
        }

        internal static void CreateStereoWavFile(string filePath, byte[] pcmDataLeft, byte[] pcmDataRight, int frequency, int bits)
        {
            MemoryStream AudioSample = new MemoryStream(pcmDataLeft);
            IWaveProvider providerLeft = new RawSourceWaveStream(AudioSample, new WaveFormat(frequency, bits, 1));
            AudioSample = new MemoryStream(pcmDataRight);
            IWaveProvider providerRight = new RawSourceWaveStream(AudioSample, new WaveFormat(frequency, bits, 1));
            MultiplexingWaveProvider waveProvider = new MultiplexingWaveProvider(new IWaveProvider[] { providerLeft, providerRight }, 2);

            WaveFileWriter.CreateWaveFile(filePath, waveProvider);
        }

        internal static void CreateMonoWavFile(string filePath, byte[] pcmData, int frequency, int bits)
        {
            IWaveProvider provider = new RawSourceWaveStream(new MemoryStream(pcmData), new WaveFormat(frequency, bits, 1));
            WaveFileWriter.CreateWaveFile(filePath, provider);
        }
    }
}
