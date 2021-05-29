using System.Windows.Forms;

namespace ImaAdpcm_Encoder_Decoder
{
    internal static class Browsers
    {
        internal static string FileBrowserDialog(string browserFilter, int selectedIndexFilter, bool forceSpecifiedFilter)
        {
            string filePath = string.Empty;

            using (OpenFileDialog fileBrowser = new OpenFileDialog())
            {
                if (forceSpecifiedFilter)
                {
                    fileBrowser.Filter = browserFilter;
                }
                else
                {
                    fileBrowser.Filter = browserFilter + "|All files(*.*)|*.*";
                }
                fileBrowser.FilterIndex = selectedIndexFilter;

                if (fileBrowser.ShowDialog() == DialogResult.OK)
                {
                    filePath = fileBrowser.FileName;
                }
            }

            return filePath;
        }

        internal static string SaveFileBrowser(string filter, int selectedIndexFilter, bool restoreDirectory, string fileName)
        {
            string selectedPath = string.Empty;

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = filter + "|All files(*.*)|*.*";
                saveFile.FilterIndex = selectedIndexFilter;
                saveFile.RestoreDirectory = restoreDirectory;
                if (!string.IsNullOrEmpty(fileName))
                {
                    saveFile.FileName = fileName;
                }

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = saveFile.FileName;
                }
            }

            return selectedPath;
        }
    }
}
