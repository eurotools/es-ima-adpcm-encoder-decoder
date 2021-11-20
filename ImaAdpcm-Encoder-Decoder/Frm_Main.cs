using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace ImaAdpcm_Encoder_Decoder
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        //*===============================================================================================
        //* ENCODE
        //*===============================================================================================
        private void Button_EncodeSearchFile_Click(object sender, EventArgs e)
        {
            //Open files explorer
            OpenFileDialog.Filter = "Wave Audio File (*.wav)|*.wav";
            DialogResult openWaveFile = OpenFileDialog.ShowDialog();
            if (openWaveFile == DialogResult.OK)
            {
                //Get the selected file 
                Textbox_EncodeFilePath.Text = OpenFileDialog.FileName;
            }
        }

        private void Button_Encode_Click(object sender, EventArgs e)
        {
            //Ensure that the file still exists
            if (File.Exists(Textbox_EncodeFilePath.Text))
            {
                    using (WaveFileReader fileReader = new WaveFileReader(Textbox_EncodeFilePath.Text))
                    {
                        if (fileReader.WaveFormat.BitsPerSample == 16 && fileReader.WaveFormat.Encoding == WaveFormatEncoding.Pcm)
                        {
                            //Get PCM Data (in bytes)
                            byte[] pcmData = new byte[fileReader.Length];
                            fileReader.Read(pcmData, 0, (int)fileReader.Length);

                            //Parse PCM Data to a short array
                            short[] samplesShort = new short[pcmData.Length / 2];
                            WaveBuffer sourceWaveBuffer = new WaveBuffer(pcmData);
                            for (int i = 0; i < samplesShort.Length; i++)
                            {
                                samplesShort[i] = sourceWaveBuffer.ShortBuffer[i];
                            }

                            //Save File
                            SaveFileDialog.Filter = "Interactive Multimedia Association ADPCM File(*.ima)| *.ima";
                            SaveFileDialog.FileName = string.Join("", Path.GetFileNameWithoutExtension(Textbox_EncodeFilePath.Text), "_Encoded");
                            DialogResult saveFileDialog = SaveFileDialog.ShowDialog();
                            if (saveFileDialog == DialogResult.OK)
                            {
                                //Encode stereo
                                byte[] encodedData;
                                if (fileReader.WaveFormat.Channels == 2)
                                {
                                    short[][] splittedData = WavFunctions.SplitChannels(samplesShort, 2);
                                    byte[] encodedDataLeftChannel = ImaADPCM.EncodeIMA_ADPCM(splittedData[0]);
                                    byte[] encodedDataRightChannel = ImaADPCM.EncodeIMA_ADPCM(splittedData[1]);

                                    encodedData = ImaADPCM.CombineChannelsIMA(encodedDataLeftChannel, encodedDataRightChannel, 1);
                                }
                                //Encode mono
                                else
                                {
                                    encodedData = ImaADPCM.EncodeIMA_ADPCM(samplesShort);
                                }
                                File.WriteAllBytes(SaveFileDialog.FileName, encodedData);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Format not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
        }

        //*===============================================================================================
        //* DECODE
        //*===============================================================================================
        private void Button_SearchFileDecode_Click(object sender, EventArgs e)
        {
            //Open files explorer
            OpenFileDialog.Filter = "Interactive Multimedia Association ADPCM File (*.ima)|*.ima";
            DialogResult openImaFile = OpenFileDialog.ShowDialog();
            if (openImaFile == DialogResult.OK)
            {
                //Get the selected file 
                Textbox_DecodeFilePath.Text = OpenFileDialog.FileName;
            }
        }

        private void Button_Decode_Click(object sender, EventArgs e)
        {
            if (File.Exists(Textbox_DecodeFilePath.Text))
            {
                byte[] imaData = File.ReadAllBytes(Textbox_DecodeFilePath.Text);

                //Save File
                SaveFileDialog.Filter = "Wave Audio File (*.wav)|*.wav";
                SaveFileDialog.FileName = string.Join("", Path.GetFileNameWithoutExtension(Textbox_DecodeFilePath.Text), "_Decoded");
                DialogResult saveFileDialog = SaveFileDialog.ShowDialog();
                if (saveFileDialog == DialogResult.OK)
                {
                    if (Numeric_DecodeChannels.Value == 2)
                    {
                        byte[][] splittedData = ImaADPCM.SplitChannels(imaData, 2);
                        short[] decodedDataLeftChannel = ImaADPCM.DecodeIMA_ADPCM(splittedData[0], splittedData[0].Length * 2);
                        short[] decodedDataRightChannel = ImaADPCM.DecodeIMA_ADPCM(splittedData[1], splittedData[1].Length * 2);
                        WavFunctions.CreateStereoWavFile(SaveFileDialog.FileName, WavFunctions.ShortArrayToByteArray(decodedDataLeftChannel), WavFunctions.ShortArrayToByteArray(decodedDataRightChannel), (int)Numeric_DecodeFrequency.Value);
                    }
                    else
                    {
                        short[] decodedData = ImaADPCM.DecodeIMA_ADPCM(imaData, imaData.Length * 2);
                        WavFunctions.CreateMonoWavFile(SaveFileDialog.FileName, WavFunctions.ShortArrayToByteArray(decodedData), (int)Numeric_DecodeFrequency.Value, 16);
                    }
                }
            }
        }
    }
}
