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
            Textbox_EncodeFilePath.Text = Browsers.FileBrowserDialog("Wav Audio File (*.WAV)|*.wav", 0, true);
        }

        private void Button_Encode_Click(object sender, EventArgs e)
        {
            //Ensure that the file still exists
            if (File.Exists(Textbox_EncodeFilePath.Text))
            {
                short[] pcmDataWav = WavFunctions.GetPcmDataWavFile(Textbox_EncodeFilePath.Text, 16);
                if (pcmDataWav != null)
                {
                    string savePath = Browsers.SaveFileBrowser("IMA Audio File (*.ima)|*.ima", 0, true, string.Join("", Path.GetFileNameWithoutExtension(Textbox_EncodeFilePath.Text), ".IMA"));

                    if (Directory.Exists(Path.GetDirectoryName(savePath)))
                    {
                        if (Checkbox_InputIsStereo.Checked)
                        {
                            uint interleavingValue = (uint)Numeric_EncodeInterleaving.Value;
                            if (IsPowerOfTwo(interleavingValue))
                            {
                                short[] leftChannelData = WavFunctions.SplitWavChannels(pcmDataWav, true);
                                short[] rightChannelData = WavFunctions.SplitWavChannels(pcmDataWav, false);

                                byte[] encodedDataLeftChannel = ImaADPCM.EncodeIMA_ADPCM(leftChannelData, leftChannelData.Length);
                                byte[] encodedDataRightChannel = ImaADPCM.EncodeIMA_ADPCM(rightChannelData, rightChannelData.Length);

                                File.WriteAllBytes(savePath, ImaADPCM.CombineChannelsIMA(encodedDataLeftChannel, encodedDataRightChannel, (int)Numeric_EncodeInterleaving.Value));
                            }
                            else
                            {
                                MessageBox.Show("The interleaving value must be power of 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            byte[] encodedData = ImaADPCM.EncodeIMA_ADPCM(pcmDataWav, pcmDataWav.Length);
                            File.WriteAllBytes(savePath, encodedData);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seems that the input audio file is not compatible, this tool is only compatible with PCM encoded 16 bits WAV files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //*===============================================================================================
        //* DECODE
        //*===============================================================================================
        private void Button_SearchFileDecode_Click(object sender, EventArgs e)
        {
            Textbox_DecodeFilePath.Text = Browsers.FileBrowserDialog("IMA Audio File (*.ima)|*.ima", 0, true);
        }

        private void Button_Decode_Click(object sender, EventArgs e)
        {
            if (File.Exists(Textbox_DecodeFilePath.Text))
            {
                byte[] imaData = File.ReadAllBytes(Textbox_DecodeFilePath.Text);
                string saveFilePath = Browsers.SaveFileBrowser("Wav Audio File (*.WAV)|*.wav", 0, true, string.Join("", Path.GetFileNameWithoutExtension(Textbox_DecodeFilePath.Text), ".IMA"));
                if (Numeric_DecodeChannels.Value == 2)
                {
                    uint interleavingValue = (uint)Numeric_DecodeInterleaving.Value;
                    if (IsPowerOfTwo(interleavingValue))
                    {
                        byte[] leftChannelData = ImaADPCM.SplitImaChannels(imaData, (int)Numeric_DecodeInterleaving.Value, true);
                        byte[] rightChannelData = ImaADPCM.SplitImaChannels(imaData, (int)Numeric_DecodeInterleaving.Value, false);

                        byte[] decodedDataLeftChannel = ImaADPCM.DecodeIMA_ADPCM(leftChannelData, leftChannelData.Length * 2);
                        byte[] decodedDataRightChannel = ImaADPCM.DecodeIMA_ADPCM(rightChannelData, rightChannelData.Length * 2);

                        WavFunctions.CreateStereoWavFile(saveFilePath, decodedDataLeftChannel, decodedDataRightChannel, (int)Numeric_DecodeFrequency.Value, 16);
                    }
                    else
                    {
                        MessageBox.Show("The interleaving value must be power of 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    byte[] decodedData = ImaADPCM.DecodeIMA_ADPCM(imaData, imaData.Length * 2);
                    WavFunctions.CreateMonoWavFile(saveFilePath, decodedData, (int)Numeric_DecodeFrequency.Value, 16);
                }
            }
        }

        bool IsPowerOfTwo(ulong x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }
    }
}
