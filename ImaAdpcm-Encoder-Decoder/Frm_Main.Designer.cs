
namespace ImaAdpcm_Encoder_Decoder
{
    partial class Frm_Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox_Encoder = new System.Windows.Forms.GroupBox();
            this.Checkbox_InputIsStereo = new System.Windows.Forms.CheckBox();
            this.Button_Encode = new System.Windows.Forms.Button();
            this.Numeric_EncodeInterleaving = new System.Windows.Forms.NumericUpDown();
            this.Label_EncodeInterleaving = new System.Windows.Forms.Label();
            this.Button_EncodeSearchFile = new System.Windows.Forms.Button();
            this.Textbox_EncodeFilePath = new System.Windows.Forms.TextBox();
            this.Label_EncodeFile = new System.Windows.Forms.Label();
            this.GroupBox_Decoder = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_Decode = new System.Windows.Forms.Button();
            this.Numeric_DecodeInterleaving = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Numeric_DecodeChannels = new System.Windows.Forms.NumericUpDown();
            this.Label_Channel = new System.Windows.Forms.Label();
            this.Label_Bits = new System.Windows.Forms.Label();
            this.Numeric_DecodeFrequency = new System.Windows.Forms.NumericUpDown();
            this.Label_Rate = new System.Windows.Forms.Label();
            this.Button_SearchFileDecode = new System.Windows.Forms.Button();
            this.Textbox_DecodeFilePath = new System.Windows.Forms.TextBox();
            this.Label_DecodeFile = new System.Windows.Forms.Label();
            this.GroupBox_Encoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_EncodeInterleaving)).BeginInit();
            this.GroupBox_Decoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeInterleaving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeChannels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Encoder
            // 
            this.GroupBox_Encoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Encoder.Controls.Add(this.Checkbox_InputIsStereo);
            this.GroupBox_Encoder.Controls.Add(this.Button_Encode);
            this.GroupBox_Encoder.Controls.Add(this.Numeric_EncodeInterleaving);
            this.GroupBox_Encoder.Controls.Add(this.Label_EncodeInterleaving);
            this.GroupBox_Encoder.Controls.Add(this.Button_EncodeSearchFile);
            this.GroupBox_Encoder.Controls.Add(this.Textbox_EncodeFilePath);
            this.GroupBox_Encoder.Controls.Add(this.Label_EncodeFile);
            this.GroupBox_Encoder.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Encoder.Name = "GroupBox_Encoder";
            this.GroupBox_Encoder.Size = new System.Drawing.Size(574, 150);
            this.GroupBox_Encoder.TabIndex = 0;
            this.GroupBox_Encoder.TabStop = false;
            this.GroupBox_Encoder.Text = "Encoder:";
            // 
            // Checkbox_InputIsStereo
            // 
            this.Checkbox_InputIsStereo.AutoSize = true;
            this.Checkbox_InputIsStereo.Checked = true;
            this.Checkbox_InputIsStereo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Checkbox_InputIsStereo.Location = new System.Drawing.Point(208, 48);
            this.Checkbox_InputIsStereo.Name = "Checkbox_InputIsStereo";
            this.Checkbox_InputIsStereo.Size = new System.Drawing.Size(117, 17);
            this.Checkbox_InputIsStereo.TabIndex = 5;
            this.Checkbox_InputIsStereo.Text = "Input is a stereo file";
            this.Checkbox_InputIsStereo.UseVisualStyleBackColor = true;
            // 
            // Button_Encode
            // 
            this.Button_Encode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Encode.Location = new System.Drawing.Point(203, 78);
            this.Button_Encode.Name = "Button_Encode";
            this.Button_Encode.Size = new System.Drawing.Size(185, 66);
            this.Button_Encode.TabIndex = 6;
            this.Button_Encode.Text = "Encode";
            this.Button_Encode.UseVisualStyleBackColor = true;
            this.Button_Encode.Click += new System.EventHandler(this.Button_Encode_Click);
            // 
            // Numeric_EncodeInterleaving
            // 
            this.Numeric_EncodeInterleaving.Location = new System.Drawing.Point(82, 45);
            this.Numeric_EncodeInterleaving.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Numeric_EncodeInterleaving.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_EncodeInterleaving.Name = "Numeric_EncodeInterleaving";
            this.Numeric_EncodeInterleaving.Size = new System.Drawing.Size(120, 20);
            this.Numeric_EncodeInterleaving.TabIndex = 4;
            this.Numeric_EncodeInterleaving.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Label_EncodeInterleaving
            // 
            this.Label_EncodeInterleaving.AutoSize = true;
            this.Label_EncodeInterleaving.Location = new System.Drawing.Point(11, 47);
            this.Label_EncodeInterleaving.Name = "Label_EncodeInterleaving";
            this.Label_EncodeInterleaving.Size = new System.Drawing.Size(65, 13);
            this.Label_EncodeInterleaving.TabIndex = 3;
            this.Label_EncodeInterleaving.Text = "Interleaving:";
            // 
            // Button_EncodeSearchFile
            // 
            this.Button_EncodeSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_EncodeSearchFile.Location = new System.Drawing.Point(543, 17);
            this.Button_EncodeSearchFile.Name = "Button_EncodeSearchFile";
            this.Button_EncodeSearchFile.Size = new System.Drawing.Size(25, 23);
            this.Button_EncodeSearchFile.TabIndex = 2;
            this.Button_EncodeSearchFile.Text = "...";
            this.Button_EncodeSearchFile.UseVisualStyleBackColor = true;
            this.Button_EncodeSearchFile.Click += new System.EventHandler(this.Button_EncodeSearchFile_Click);
            // 
            // Textbox_EncodeFilePath
            // 
            this.Textbox_EncodeFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_EncodeFilePath.Location = new System.Drawing.Point(43, 19);
            this.Textbox_EncodeFilePath.Name = "Textbox_EncodeFilePath";
            this.Textbox_EncodeFilePath.ReadOnly = true;
            this.Textbox_EncodeFilePath.Size = new System.Drawing.Size(494, 20);
            this.Textbox_EncodeFilePath.TabIndex = 1;
            // 
            // Label_EncodeFile
            // 
            this.Label_EncodeFile.AutoSize = true;
            this.Label_EncodeFile.Location = new System.Drawing.Point(11, 22);
            this.Label_EncodeFile.Name = "Label_EncodeFile";
            this.Label_EncodeFile.Size = new System.Drawing.Size(26, 13);
            this.Label_EncodeFile.TabIndex = 0;
            this.Label_EncodeFile.Text = "File:";
            // 
            // GroupBox_Decoder
            // 
            this.GroupBox_Decoder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Decoder.Controls.Add(this.textBox1);
            this.GroupBox_Decoder.Controls.Add(this.Button_Decode);
            this.GroupBox_Decoder.Controls.Add(this.Numeric_DecodeInterleaving);
            this.GroupBox_Decoder.Controls.Add(this.label5);
            this.GroupBox_Decoder.Controls.Add(this.Numeric_DecodeChannels);
            this.GroupBox_Decoder.Controls.Add(this.Label_Channel);
            this.GroupBox_Decoder.Controls.Add(this.Label_Bits);
            this.GroupBox_Decoder.Controls.Add(this.Numeric_DecodeFrequency);
            this.GroupBox_Decoder.Controls.Add(this.Label_Rate);
            this.GroupBox_Decoder.Controls.Add(this.Button_SearchFileDecode);
            this.GroupBox_Decoder.Controls.Add(this.Textbox_DecodeFilePath);
            this.GroupBox_Decoder.Controls.Add(this.Label_DecodeFile);
            this.GroupBox_Decoder.Location = new System.Drawing.Point(12, 168);
            this.GroupBox_Decoder.Name = "GroupBox_Decoder";
            this.GroupBox_Decoder.Size = new System.Drawing.Size(574, 196);
            this.GroupBox_Decoder.TabIndex = 1;
            this.GroupBox_Decoder.TabStop = false;
            this.GroupBox_Decoder.Text = "Decoder:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(222, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "16";
            // 
            // Button_Decode
            // 
            this.Button_Decode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Decode.Location = new System.Drawing.Point(203, 124);
            this.Button_Decode.Name = "Button_Decode";
            this.Button_Decode.Size = new System.Drawing.Size(185, 66);
            this.Button_Decode.TabIndex = 11;
            this.Button_Decode.Text = "Decode";
            this.Button_Decode.UseVisualStyleBackColor = true;
            this.Button_Decode.Click += new System.EventHandler(this.Button_Decode_Click);
            // 
            // Numeric_DecodeInterleaving
            // 
            this.Numeric_DecodeInterleaving.BackColor = System.Drawing.SystemColors.Window;
            this.Numeric_DecodeInterleaving.Location = new System.Drawing.Point(505, 45);
            this.Numeric_DecodeInterleaving.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Numeric_DecodeInterleaving.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_DecodeInterleaving.Name = "Numeric_DecodeInterleaving";
            this.Numeric_DecodeInterleaving.Size = new System.Drawing.Size(62, 20);
            this.Numeric_DecodeInterleaving.TabIndex = 10;
            this.Numeric_DecodeInterleaving.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Interleaving:";
            // 
            // Numeric_DecodeChannels
            // 
            this.Numeric_DecodeChannels.BackColor = System.Drawing.SystemColors.Window;
            this.Numeric_DecodeChannels.Location = new System.Drawing.Point(362, 45);
            this.Numeric_DecodeChannels.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Numeric_DecodeChannels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_DecodeChannels.Name = "Numeric_DecodeChannels";
            this.Numeric_DecodeChannels.Size = new System.Drawing.Size(57, 20);
            this.Numeric_DecodeChannels.TabIndex = 8;
            this.Numeric_DecodeChannels.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Label_Channel
            // 
            this.Label_Channel.AutoSize = true;
            this.Label_Channel.Location = new System.Drawing.Point(302, 47);
            this.Label_Channel.Name = "Label_Channel";
            this.Label_Channel.Size = new System.Drawing.Size(54, 13);
            this.Label_Channel.TabIndex = 7;
            this.Label_Channel.Text = "Channels:";
            // 
            // Label_Bits
            // 
            this.Label_Bits.AutoSize = true;
            this.Label_Bits.Location = new System.Drawing.Point(189, 47);
            this.Label_Bits.Name = "Label_Bits";
            this.Label_Bits.Size = new System.Drawing.Size(27, 13);
            this.Label_Bits.TabIndex = 5;
            this.Label_Bits.Text = "Bits:";
            // 
            // Numeric_DecodeFrequency
            // 
            this.Numeric_DecodeFrequency.BackColor = System.Drawing.SystemColors.Window;
            this.Numeric_DecodeFrequency.Location = new System.Drawing.Point(77, 45);
            this.Numeric_DecodeFrequency.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Numeric_DecodeFrequency.Name = "Numeric_DecodeFrequency";
            this.Numeric_DecodeFrequency.Size = new System.Drawing.Size(95, 20);
            this.Numeric_DecodeFrequency.TabIndex = 4;
            this.Numeric_DecodeFrequency.Value = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            // 
            // Label_Rate
            // 
            this.Label_Rate.AutoSize = true;
            this.Label_Rate.Location = new System.Drawing.Point(11, 47);
            this.Label_Rate.Name = "Label_Rate";
            this.Label_Rate.Size = new System.Drawing.Size(60, 13);
            this.Label_Rate.TabIndex = 3;
            this.Label_Rate.Text = "Frequency:";
            // 
            // Button_SearchFileDecode
            // 
            this.Button_SearchFileDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SearchFileDecode.Location = new System.Drawing.Point(543, 17);
            this.Button_SearchFileDecode.Name = "Button_SearchFileDecode";
            this.Button_SearchFileDecode.Size = new System.Drawing.Size(25, 23);
            this.Button_SearchFileDecode.TabIndex = 2;
            this.Button_SearchFileDecode.Text = "...";
            this.Button_SearchFileDecode.UseVisualStyleBackColor = true;
            this.Button_SearchFileDecode.Click += new System.EventHandler(this.Button_SearchFileDecode_Click);
            // 
            // Textbox_DecodeFilePath
            // 
            this.Textbox_DecodeFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_DecodeFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_DecodeFilePath.Location = new System.Drawing.Point(38, 19);
            this.Textbox_DecodeFilePath.Name = "Textbox_DecodeFilePath";
            this.Textbox_DecodeFilePath.ReadOnly = true;
            this.Textbox_DecodeFilePath.Size = new System.Drawing.Size(499, 20);
            this.Textbox_DecodeFilePath.TabIndex = 1;
            // 
            // Label_DecodeFile
            // 
            this.Label_DecodeFile.AutoSize = true;
            this.Label_DecodeFile.Location = new System.Drawing.Point(6, 22);
            this.Label_DecodeFile.Name = "Label_DecodeFile";
            this.Label_DecodeFile.Size = new System.Drawing.Size(26, 13);
            this.Label_DecodeFile.TabIndex = 0;
            this.Label_DecodeFile.Text = "File:";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 382);
            this.Controls.Add(this.GroupBox_Decoder);
            this.Controls.Add(this.GroupBox_Encoder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.Text = "IMA ADPCM Encoder - Decoder";
            this.GroupBox_Encoder.ResumeLayout(false);
            this.GroupBox_Encoder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_EncodeInterleaving)).EndInit();
            this.GroupBox_Decoder.ResumeLayout(false);
            this.GroupBox_Decoder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeInterleaving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeChannels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Encoder;
        private System.Windows.Forms.GroupBox GroupBox_Decoder;
        private System.Windows.Forms.Button Button_SearchFileDecode;
        private System.Windows.Forms.TextBox Textbox_DecodeFilePath;
        private System.Windows.Forms.Label Label_DecodeFile;
        private System.Windows.Forms.NumericUpDown Numeric_DecodeInterleaving;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Numeric_DecodeChannels;
        private System.Windows.Forms.Label Label_Channel;
        private System.Windows.Forms.Label Label_Bits;
        private System.Windows.Forms.NumericUpDown Numeric_DecodeFrequency;
        private System.Windows.Forms.Label Label_Rate;
        private System.Windows.Forms.Button Button_Decode;
        private System.Windows.Forms.Label Label_EncodeFile;
        private System.Windows.Forms.Button Button_Encode;
        private System.Windows.Forms.NumericUpDown Numeric_EncodeInterleaving;
        private System.Windows.Forms.Label Label_EncodeInterleaving;
        private System.Windows.Forms.Button Button_EncodeSearchFile;
        private System.Windows.Forms.TextBox Textbox_EncodeFilePath;
        private System.Windows.Forms.CheckBox Checkbox_InputIsStereo;
        private System.Windows.Forms.TextBox textBox1;
    }
}

