namespace IdGenerator
{
    partial class IDGeneratorForm
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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.IDListLabel = new System.Windows.Forms.Label();
            this.IDListBox = new System.Windows.Forms.ListBox();
            this.LatestIDSetupLabel = new System.Windows.Forms.Label();
            this.LatestIDLabel = new System.Windows.Forms.Label();
            this.InUseSetupLabel = new System.Windows.Forms.Label();
            this.InUseLabel = new System.Windows.Forms.Label();
            this.ExportIDButton = new System.Windows.Forms.Button();
            this.ClearIDButton = new System.Windows.Forms.Button();
            this.ImportIDButton = new System.Windows.Forms.Button();
            this.ClearIDList = new System.Windows.Forms.Button();
            this.OpenIDFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 18);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(133, 41);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate ID";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // IDListLabel
            // 
            this.IDListLabel.AutoSize = true;
            this.IDListLabel.Location = new System.Drawing.Point(234, 20);
            this.IDListLabel.Name = "IDListLabel";
            this.IDListLabel.Size = new System.Drawing.Size(58, 13);
            this.IDListLabel.TabIndex = 1;
            this.IDListLabel.Text = "ID\'s in Use";
            // 
            // IDListBox
            // 
            this.IDListBox.FormattingEnabled = true;
            this.IDListBox.Location = new System.Drawing.Point(204, 41);
            this.IDListBox.Name = "IDListBox";
            this.IDListBox.Size = new System.Drawing.Size(118, 173);
            this.IDListBox.TabIndex = 2;
            // 
            // LatestIDSetupLabel
            // 
            this.LatestIDSetupLabel.AutoSize = true;
            this.LatestIDSetupLabel.Location = new System.Drawing.Point(12, 83);
            this.LatestIDSetupLabel.Name = "LatestIDSetupLabel";
            this.LatestIDSetupLabel.Size = new System.Drawing.Size(106, 13);
            this.LatestIDSetupLabel.TabIndex = 3;
            this.LatestIDSetupLabel.Text = "Latest ID Generated:";
            // 
            // LatestIDLabel
            // 
            this.LatestIDLabel.AutoSize = true;
            this.LatestIDLabel.Location = new System.Drawing.Point(118, 83);
            this.LatestIDLabel.Name = "LatestIDLabel";
            this.LatestIDLabel.Size = new System.Drawing.Size(27, 13);
            this.LatestIDLabel.TabIndex = 4;
            this.LatestIDLabel.Text = "N/A";
            // 
            // InUseSetupLabel
            // 
            this.InUseSetupLabel.AutoSize = true;
            this.InUseSetupLabel.Location = new System.Drawing.Point(49, 108);
            this.InUseSetupLabel.Name = "InUseSetupLabel";
            this.InUseSetupLabel.Size = new System.Drawing.Size(69, 13);
            this.InUseSetupLabel.TabIndex = 5;
            this.InUseSetupLabel.Text = "Is ID in use?:";
            // 
            // InUseLabel
            // 
            this.InUseLabel.AutoSize = true;
            this.InUseLabel.Location = new System.Drawing.Point(118, 108);
            this.InUseLabel.Name = "InUseLabel";
            this.InUseLabel.Size = new System.Drawing.Size(27, 13);
            this.InUseLabel.TabIndex = 6;
            this.InUseLabel.Text = "N/A";
            // 
            // ExportIDButton
            // 
            this.ExportIDButton.Location = new System.Drawing.Point(12, 198);
            this.ExportIDButton.Name = "ExportIDButton";
            this.ExportIDButton.Size = new System.Drawing.Size(133, 41);
            this.ExportIDButton.TabIndex = 7;
            this.ExportIDButton.Text = "Export ID\'s";
            this.ExportIDButton.UseVisualStyleBackColor = true;
            this.ExportIDButton.Click += new System.EventHandler(this.ExportIDButton_Click);
            // 
            // ClearIDButton
            // 
            this.ClearIDButton.Location = new System.Drawing.Point(12, 245);
            this.ClearIDButton.Name = "ClearIDButton";
            this.ClearIDButton.Size = new System.Drawing.Size(133, 41);
            this.ClearIDButton.TabIndex = 8;
            this.ClearIDButton.Text = "Clear Saved ID\'s";
            this.ClearIDButton.UseVisualStyleBackColor = true;
            this.ClearIDButton.Click += new System.EventHandler(this.ClearIDButton_Click);
            // 
            // ImportIDButton
            // 
            this.ImportIDButton.Location = new System.Drawing.Point(12, 151);
            this.ImportIDButton.Name = "ImportIDButton";
            this.ImportIDButton.Size = new System.Drawing.Size(133, 41);
            this.ImportIDButton.TabIndex = 9;
            this.ImportIDButton.Text = "Import ID\'s";
            this.ImportIDButton.UseVisualStyleBackColor = true;
            this.ImportIDButton.Click += new System.EventHandler(this.ImportIDButton_Click);
            // 
            // ClearIDList
            // 
            this.ClearIDList.Location = new System.Drawing.Point(214, 223);
            this.ClearIDList.Name = "ClearIDList";
            this.ClearIDList.Size = new System.Drawing.Size(97, 27);
            this.ClearIDList.TabIndex = 10;
            this.ClearIDList.Text = "Clear ID List";
            this.ClearIDList.UseVisualStyleBackColor = true;
            this.ClearIDList.Click += new System.EventHandler(this.ClearIDList_Click);
            // 
            // OpenIDFileButton
            // 
            this.OpenIDFileButton.Location = new System.Drawing.Point(214, 258);
            this.OpenIDFileButton.Name = "OpenIDFileButton";
            this.OpenIDFileButton.Size = new System.Drawing.Size(97, 28);
            this.OpenIDFileButton.TabIndex = 11;
            this.OpenIDFileButton.Text = "Open ID File";
            this.OpenIDFileButton.UseVisualStyleBackColor = true;
            this.OpenIDFileButton.Click += new System.EventHandler(this.OpenIDFileButton_Click);
            // 
            // IDGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.OpenIDFileButton);
            this.Controls.Add(this.ClearIDList);
            this.Controls.Add(this.ImportIDButton);
            this.Controls.Add(this.ClearIDButton);
            this.Controls.Add(this.ExportIDButton);
            this.Controls.Add(this.InUseLabel);
            this.Controls.Add(this.InUseSetupLabel);
            this.Controls.Add(this.LatestIDLabel);
            this.Controls.Add(this.LatestIDSetupLabel);
            this.Controls.Add(this.IDListBox);
            this.Controls.Add(this.IDListLabel);
            this.Controls.Add(this.GenerateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IDGeneratorForm";
            this.ShowIcon = false;
            this.Text = "ID Generator";
            this.Load += new System.EventHandler(this.IDGeneratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label IDListLabel;
        private System.Windows.Forms.ListBox IDListBox;
        private System.Windows.Forms.Label LatestIDSetupLabel;
        private System.Windows.Forms.Label LatestIDLabel;
        private System.Windows.Forms.Label InUseSetupLabel;
        private System.Windows.Forms.Label InUseLabel;
        private System.Windows.Forms.Button ExportIDButton;
        private System.Windows.Forms.Button ClearIDButton;
        private System.Windows.Forms.Button ImportIDButton;
        private System.Windows.Forms.Button ClearIDList;
        private System.Windows.Forms.Button OpenIDFileButton;
    }
}

