namespace WindBackup
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectSourceBtn = new System.Windows.Forms.Button();
            this.selectSourceDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // selectSourceBtn
            // 
            this.selectSourceBtn.Location = new System.Drawing.Point(31, 378);
            this.selectSourceBtn.Name = "selectSourceBtn";
            this.selectSourceBtn.Size = new System.Drawing.Size(136, 43);
            this.selectSourceBtn.TabIndex = 0;
            this.selectSourceBtn.Text = "Select source folder";
            this.selectSourceBtn.UseVisualStyleBackColor = true;
            this.selectSourceBtn.Click += new System.EventHandler(this.selectSourceBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectSourceBtn);
            this.Name = "MainWindow";
            this.Text = "WindBackup";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button selectSourceBtn;
        private FolderBrowserDialog selectSourceDialog;
    }
}