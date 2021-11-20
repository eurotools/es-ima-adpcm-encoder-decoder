
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
            this.Button_Encode = new System.Windows.Forms.Button();
            this.Button_EncodeSearchFile = new System.Windows.Forms.Button();
            this.Textbox_EncodeFilePath = new System.Windows.Forms.TextBox();
            this.Label_EncodeFile = new System.Windows.Forms.Label();
            this.GroupBox_Decoder = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Numeric_DecodeFrequency = new System.Windows.Forms.NumericUpDown();
            this.Label_Rate = new System.Windows.Forms.Label();
            this.Label_Channel = new System.Windows.Forms.Label();
            this.Numeric_DecodeChannels = new System.Windows.Forms.NumericUpDown();
            this.Button_Decode = new System.Windows.Forms.Button();
            this.Button_SearchFileDecode = new System.Windows.Forms.Button();
            this.Textbox_DecodeFilePath = new System.Windows.Forms.TextBox();
            this.Label_DecodeFile = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox_Encoder.SuspendLayout();
            this.GroupBox_Decoder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeChannels)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Encoder
            // 
            this.GroupBox_Encoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Encoder.Controls.Add(this.Button_Encode);
            this.GroupBox_Encoder.Controls.Add(this.Button_EncodeSearchFile);
            this.GroupBox_Encoder.Controls.Add(this.Textbox_EncodeFilePath);
            this.GroupBox_Encoder.Controls.Add(this.Label_EncodeFile);
            this.GroupBox_Encoder.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Encoder.Name = "GroupBox_Encoder";
            this.GroupBox_Encoder.Size = new System.Drawing.Size(412, 78);
            this.GroupBox_Encoder.TabIndex = 0;
            this.GroupBox_Encoder.TabStop = false;
            this.GroupBox_Encoder.Text = "Encoder:";
            // 
            // Button_Encode
            // 
            this.Button_Encode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Encode.Location = new System.Drawing.Point(331, 45);
            this.Button_Encode.Name = "Button_Encode";
            this.Button_Encode.Size = new System.Drawing.Size(75, 22);
            this.Button_Encode.TabIndex = 6;
            this.Button_Encode.Text = "Encode";
            this.Button_Encode.UseVisualStyleBackColor = true;
            this.Button_Encode.Click += new System.EventHandler(this.Button_Encode_Click);
            // 
            // Button_EncodeSearchFile
            // 
            this.Button_EncodeSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_EncodeSearchFile.Location = new System.Drawing.Point(381, 19);
            this.Button_EncodeSearchFile.Name = "Button_EncodeSearchFile";
            this.Button_EncodeSearchFile.Size = new System.Drawing.Size(25, 20);
            this.Button_EncodeSearchFile.TabIndex = 2;
            this.Button_EncodeSearchFile.Text = "...";
            this.Button_EncodeSearchFile.UseVisualStyleBackColor = true;
            this.Button_EncodeSearchFile.Click += new System.EventHandler(this.Button_EncodeSearchFile_Click);
            // 
            // Textbox_EncodeFilePath
            // 
            this.Textbox_EncodeFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_EncodeFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_EncodeFilePath.Location = new System.Drawing.Point(63, 19);
            this.Textbox_EncodeFilePath.Name = "Textbox_EncodeFilePath";
            this.Textbox_EncodeFilePath.ReadOnly = true;
            this.Textbox_EncodeFilePath.Size = new System.Drawing.Size(312, 20);
            this.Textbox_EncodeFilePath.TabIndex = 1;
            // 
            // Label_EncodeFile
            // 
            this.Label_EncodeFile.AutoSize = true;
            this.Label_EncodeFile.Location = new System.Drawing.Point(6, 22);
            this.Label_EncodeFile.Name = "Label_EncodeFile";
            this.Label_EncodeFile.Size = new System.Drawing.Size(51, 13);
            this.Label_EncodeFile.TabIndex = 0;
            this.Label_EncodeFile.Text = "File Path:";
            // 
            // GroupBox_Decoder
            // 
            this.GroupBox_Decoder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Decoder.Controls.Add(this.groupBox2);
            this.GroupBox_Decoder.Controls.Add(this.Button_Decode);
            this.GroupBox_Decoder.Controls.Add(this.Button_SearchFileDecode);
            this.GroupBox_Decoder.Controls.Add(this.Textbox_DecodeFilePath);
            this.GroupBox_Decoder.Controls.Add(this.Label_DecodeFile);
            this.GroupBox_Decoder.Location = new System.Drawing.Point(12, 96);
            this.GroupBox_Decoder.Name = "GroupBox_Decoder";
            this.GroupBox_Decoder.Size = new System.Drawing.Size(412, 106);
            this.GroupBox_Decoder.TabIndex = 1;
            this.GroupBox_Decoder.TabStop = false;
            this.GroupBox_Decoder.Text = "Decoder:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Numeric_DecodeFrequency);
            this.groupBox2.Controls.Add(this.Label_Rate);
            this.groupBox2.Controls.Add(this.Label_Channel);
            this.groupBox2.Controls.Add(this.Numeric_DecodeChannels);
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 55);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Parameters:";
            // 
            // Numeric_DecodeFrequency
            // 
            this.Numeric_DecodeFrequency.BackColor = System.Drawing.SystemColors.Window;
            this.Numeric_DecodeFrequency.Location = new System.Drawing.Point(72, 19);
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
            this.Label_Rate.Location = new System.Drawing.Point(6, 21);
            this.Label_Rate.Name = "Label_Rate";
            this.Label_Rate.Size = new System.Drawing.Size(60, 13);
            this.Label_Rate.TabIndex = 3;
            this.Label_Rate.Text = "Frequency:";
            // 
            // Label_Channel
            // 
            this.Label_Channel.AutoSize = true;
            this.Label_Channel.Location = new System.Drawing.Point(173, 21);
            this.Label_Channel.Name = "Label_Channel";
            this.Label_Channel.Size = new System.Drawing.Size(54, 13);
            this.Label_Channel.TabIndex = 7;
            this.Label_Channel.Text = "Channels:";
            // 
            // Numeric_DecodeChannels
            // 
            this.Numeric_DecodeChannels.BackColor = System.Drawing.SystemColors.Window;
            this.Numeric_DecodeChannels.Location = new System.Drawing.Point(233, 19);
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
            // Button_Decode
            // 
            this.Button_Decode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Decode.Location = new System.Drawing.Point(331, 45);
            this.Button_Decode.Name = "Button_Decode";
            this.Button_Decode.Size = new System.Drawing.Size(75, 54);
            this.Button_Decode.TabIndex = 11;
            this.Button_Decode.Text = "Decode";
            this.Button_Decode.UseVisualStyleBackColor = true;
            this.Button_Decode.Click += new System.EventHandler(this.Button_Decode_Click);
            // 
            // Button_SearchFileDecode
            // 
            this.Button_SearchFileDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SearchFileDecode.Location = new System.Drawing.Point(381, 19);
            this.Button_SearchFileDecode.Name = "Button_SearchFileDecode";
            this.Button_SearchFileDecode.Size = new System.Drawing.Size(25, 20);
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
            this.Textbox_DecodeFilePath.Size = new System.Drawing.Size(337, 20);
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
            // SaveFileDialog
            // 
            this.SaveFileDialog.RestoreDirectory = true;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 214);
            this.Controls.Add(this.GroupBox_Decoder);
            this.Controls.Add(this.GroupBox_Encoder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.Text = "IMA ADPCM Tool";
            this.GroupBox_Encoder.ResumeLayout(false);
            this.GroupBox_Encoder.PerformLayout();
            this.GroupBox_Decoder.ResumeLayout(false);
            this.GroupBox_Decoder.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DecodeChannels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Encoder;
        private System.Windows.Forms.GroupBox GroupBox_Decoder;
        private System.Windows.Forms.Button Button_SearchFileDecode;
        private System.Windows.Forms.TextBox Textbox_DecodeFilePath;
        private System.Windows.Forms.Label Label_DecodeFile;
        private System.Windows.Forms.NumericUpDown Numeric_DecodeChannels;
        private System.Windows.Forms.Label Label_Channel;
        private System.Windows.Forms.NumericUpDown Numeric_DecodeFrequency;
        private System.Windows.Forms.Label Label_Rate;
        private System.Windows.Forms.Button Button_Decode;
        private System.Windows.Forms.Label Label_EncodeFile;
        private System.Windows.Forms.Button Button_Encode;
        private System.Windows.Forms.Button Button_EncodeSearchFile;
        private System.Windows.Forms.TextBox Textbox_EncodeFilePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

