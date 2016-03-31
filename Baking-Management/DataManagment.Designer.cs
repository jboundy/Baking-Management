using System.Data;

namespace Baking_Management
{
    partial class DataManagment
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
            this.components = new System.ComponentModel.Container();
            this.btnDataSave = new System.Windows.Forms.Button();
            this.btnDataCancel = new System.Windows.Forms.Button();
            this.gvDataManagement = new System.Windows.Forms.DataGridView();
            this.bakingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFormOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDataSave
            // 
            this.btnDataSave.Location = new System.Drawing.Point(161, 374);
            this.btnDataSave.Name = "btnDataSave";
            this.btnDataSave.Size = new System.Drawing.Size(96, 48);
            this.btnDataSave.TabIndex = 1;
            this.btnDataSave.Text = "Save";
            this.btnDataSave.UseVisualStyleBackColor = true;
            this.btnDataSave.Click += new System.EventHandler(this.btnDataSave_Click);
            // 
            // btnDataCancel
            // 
            this.btnDataCancel.Location = new System.Drawing.Point(313, 374);
            this.btnDataCancel.Name = "btnDataCancel";
            this.btnDataCancel.Size = new System.Drawing.Size(92, 48);
            this.btnDataCancel.TabIndex = 7;
            this.btnDataCancel.Text = "Cancel";
            this.btnDataCancel.UseVisualStyleBackColor = true;
            this.btnDataCancel.Click += new System.EventHandler(this.btnDataCancel_Click);
            // 
            // gvDataManagement
            // 
            this.gvDataManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDataManagement.Location = new System.Drawing.Point(161, 56);
            this.gvDataManagement.Name = "gvDataManagement";
            this.gvDataManagement.Size = new System.Drawing.Size(244, 282);
            this.gvDataManagement.TabIndex = 11;
            // 
            // bakingBindingSource
            // 
            this.bakingBindingSource.DataSource = typeof(Baking_Management.Core.Models.Baking);
            // 
            // btnFormOpen
            // 
            this.btnFormOpen.Location = new System.Drawing.Point(224, 442);
            this.btnFormOpen.Name = "btnFormOpen";
            this.btnFormOpen.Size = new System.Drawing.Size(108, 23);
            this.btnFormOpen.TabIndex = 12;
            this.btnFormOpen.Text = "Go To Form";
            this.btnFormOpen.UseVisualStyleBackColor = true;
            this.btnFormOpen.Click += new System.EventHandler(this.btnFormOpen_Click);
            // 
            // DataManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 477);
            this.Controls.Add(this.btnFormOpen);
            this.Controls.Add(this.gvDataManagement);
            this.Controls.Add(this.btnDataCancel);
            this.Controls.Add(this.btnDataSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataManagment";
            ((System.ComponentModel.ISupportInitialize)(this.gvDataManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDataSave;
        private System.Windows.Forms.Button btnDataCancel;
        private System.Windows.Forms.DataGridView gvDataManagement;
        private System.Windows.Forms.BindingSource bakingBindingSource;
        private System.Windows.Forms.Button btnFormOpen;
    }
}