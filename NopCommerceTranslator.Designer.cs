namespace Marjani.Net.GoogleTranslator
{
    partial class GoogleTranslatorFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleTranslatorFrm));
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._btnTranslate = new System.Windows.Forms.Button();
            this._lblStatus = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lblSourceInfo = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // _comboTo
            // 
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Location = new System.Drawing.Point(12, 26);
            this._comboTo.MaxDropDownItems = 20;
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(210, 21);
            this._comboTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target language:";
            // 
            // _btnTranslate
            // 
            this._btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTranslate.Location = new System.Drawing.Point(557, 53);
            this._btnTranslate.Name = "_btnTranslate";
            this._btnTranslate.Size = new System.Drawing.Size(75, 23);
            this._btnTranslate.TabIndex = 10;
            this._btnTranslate.Text = "Translate";
            this._btnTranslate.UseVisualStyleBackColor = true;
            this._btnTranslate.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // _lblStatus
            // 
            this._lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(12, 393);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(10, 13);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = " ";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(12, 53);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(90, 23);
            this.btnChooseFile.TabIndex = 13;
            this.btnChooseFile.Text = "Select XML File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblSourceInfo
            // 
            this.lblSourceInfo.AutoSize = true;
            this.lblSourceInfo.Location = new System.Drawing.Point(130, 58);
            this.lblSourceInfo.Name = "lblSourceInfo";
            this.lblSourceInfo.Size = new System.Drawing.Size(0, 13);
            this.lblSourceInfo.TabIndex = 15;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value,
            this.Translation});
            this.dgvData.Location = new System.Drawing.Point(15, 82);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(698, 300);
            this.dgvData.TabIndex = 16;
            // 
            // Key
            // 
            this.Key.HeaderText = "Name";
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 150;
            // 
            // Translation
            // 
            this.Translation.HeaderText = "Translation";
            this.Translation.Name = "Translation";
            this.Translation.Width = 300;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(638, 53);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // GoogleTranslatorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(725, 423);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblSourceInfo);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._btnTranslate);
            this.Controls.Add(this._comboTo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoogleTranslatorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marjani.Net | NopCommerce Translator";
            this.Load += new System.EventHandler(this.GoogleTranslatorFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _comboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnTranslate;
        private System.Windows.Forms.Label _lblStatus;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblSourceInfo;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation;
    }
}