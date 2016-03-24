namespace Baking_Management
{
    partial class EntryForm
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
            this.btnSaveDataEntry = new System.Windows.Forms.Button();
            this.btnCancelDataEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveDataEntry
            // 
            this.btnSaveDataEntry.Location = new System.Drawing.Point(513, 426);
            this.btnSaveDataEntry.Name = "btnSaveDataEntry";
            this.btnSaveDataEntry.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDataEntry.TabIndex = 0;
            this.btnSaveDataEntry.Text = "Save";
            this.btnSaveDataEntry.UseVisualStyleBackColor = true;
            this.btnSaveDataEntry.Click += new System.EventHandler(this.SaveDataEntry_Click);
            // 
            // btnCancelDataEntry
            // 
            this.btnCancelDataEntry.Location = new System.Drawing.Point(594, 426);
            this.btnCancelDataEntry.Name = "btnCancelDataEntry";
            this.btnCancelDataEntry.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDataEntry.TabIndex = 1;
            this.btnCancelDataEntry.Text = "Cancel";
            this.btnCancelDataEntry.UseVisualStyleBackColor = true;
            this.btnCancelDataEntry.Click += new System.EventHandler(this.btnCancelDataEntry_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 461);
            this.Controls.Add(this.btnCancelDataEntry);
            this.Controls.Add(this.btnSaveDataEntry);
            this.Name = "EntryForm";
            this.Text = "Data Entry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDataEntry;
        private System.Windows.Forms.Button btnCancelDataEntry;
    }
}

