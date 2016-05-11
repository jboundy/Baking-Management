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
            this.btnCalculateDataEntry = new System.Windows.Forms.Button();
            this.btnCancelDataEntry = new System.Windows.Forms.Button();
            this.lvSourceDataEntry = new System.Windows.Forms.ListView();
            this.lvCalculationDataEntry = new System.Windows.Forms.ListView();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnRemoveData = new System.Windows.Forms.Button();
            this.btnGoToDM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculateDataEntry
            // 
            this.btnCalculateDataEntry.Location = new System.Drawing.Point(513, 426);
            this.btnCalculateDataEntry.Name = "btnCalculateDataEntry";
            this.btnCalculateDataEntry.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateDataEntry.TabIndex = 0;
            this.btnCalculateDataEntry.Text = "Calculate";
            this.btnCalculateDataEntry.UseVisualStyleBackColor = true;
            this.btnCalculateDataEntry.Click += new System.EventHandler(this.CalculateDataEntry_Click);
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
            // lvSourceDataEntry
            // 
            this.lvSourceDataEntry.LabelWrap = false;
            this.lvSourceDataEntry.Location = new System.Drawing.Point(12, 51);
            this.lvSourceDataEntry.Name = "lvSourceDataEntry";
            this.lvSourceDataEntry.Size = new System.Drawing.Size(121, 333);
            this.lvSourceDataEntry.TabIndex = 2;
            this.lvSourceDataEntry.UseCompatibleStateImageBehavior = false;
            // 
            // lvCalculationDataEntry
            // 
            this.lvCalculationDataEntry.LabelWrap = false;
            this.lvCalculationDataEntry.Location = new System.Drawing.Point(259, 51);
            this.lvCalculationDataEntry.Name = "lvCalculationDataEntry";
            this.lvCalculationDataEntry.Size = new System.Drawing.Size(121, 333);
            this.lvCalculationDataEntry.TabIndex = 3;
            this.lvCalculationDataEntry.UseCompatibleStateImageBehavior = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(516, 232);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(156, 20);
            this.tbTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(513, 195);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(151, 185);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(75, 23);
            this.btnAddData.TabIndex = 6;
            this.btnAddData.Text = "Add";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnRemoveData
            // 
            this.btnRemoveData.Location = new System.Drawing.Point(151, 232);
            this.btnRemoveData.Name = "btnRemoveData";
            this.btnRemoveData.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveData.TabIndex = 7;
            this.btnRemoveData.Text = "Remove";
            this.btnRemoveData.UseVisualStyleBackColor = true;
            this.btnRemoveData.Click += new System.EventHandler(this.btnRemoveData_Click);
            // 
            // btnGoToDM
            // 
            this.btnGoToDM.Location = new System.Drawing.Point(127, 426);
            this.btnGoToDM.Name = "btnGoToDM";
            this.btnGoToDM.Size = new System.Drawing.Size(143, 23);
            this.btnGoToDM.TabIndex = 8;
            this.btnGoToDM.Text = "Go to Data Management";
            this.btnGoToDM.UseVisualStyleBackColor = true;
            this.btnGoToDM.Click += new System.EventHandler(this.btnGoToDM_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 461);
            this.Controls.Add(this.btnGoToDM);
            this.Controls.Add(this.btnRemoveData);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lvCalculationDataEntry);
            this.Controls.Add(this.lvSourceDataEntry);
            this.Controls.Add(this.btnCancelDataEntry);
            this.Controls.Add(this.btnCalculateDataEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateDataEntry;
        private System.Windows.Forms.Button btnCancelDataEntry;
        private System.Windows.Forms.ListView lvSourceDataEntry;
        private System.Windows.Forms.ListView lvCalculationDataEntry;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnRemoveData;
        private System.Windows.Forms.Button btnGoToDM;
    }
}

