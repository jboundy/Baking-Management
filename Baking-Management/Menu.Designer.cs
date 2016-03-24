namespace Baking_Management
{
    partial class Menu
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
            this.btnEntryForm = new System.Windows.Forms.Button();
            this.btnDataManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntryForm
            // 
            this.btnEntryForm.Location = new System.Drawing.Point(107, 365);
            this.btnEntryForm.Name = "btnEntryForm";
            this.btnEntryForm.Size = new System.Drawing.Size(119, 23);
            this.btnEntryForm.TabIndex = 0;
            this.btnEntryForm.Text = "New Data Form";
            this.btnEntryForm.UseVisualStyleBackColor = true;
            this.btnEntryForm.Click += new System.EventHandler(this.btnEntryForm_Click);
            // 
            // btnDataManagement
            // 
            this.btnDataManagement.Location = new System.Drawing.Point(273, 365);
            this.btnDataManagement.Name = "btnDataManagement";
            this.btnDataManagement.Size = new System.Drawing.Size(142, 23);
            this.btnDataManagement.TabIndex = 1;
            this.btnDataManagement.Text = "Data Management Form";
            this.btnDataManagement.UseVisualStyleBackColor = true;
            this.btnDataManagement.Click += new System.EventHandler(this.btnDataManagement_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 485);
            this.Controls.Add(this.btnDataManagement);
            this.Controls.Add(this.btnEntryForm);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntryForm;
        private System.Windows.Forms.Button btnDataManagement;
    }
}