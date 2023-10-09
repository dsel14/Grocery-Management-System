namespace JeighdyT_Assign2
{
    partial class QuantitySoldLabelBut
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
            this.Superstore = new System.Windows.Forms.Label();
            this.OutPutListBox = new System.Windows.Forms.ListBox();
            this.LoadGroceryButton = new System.Windows.Forms.Button();
            this.LoadDataGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateSoldButton = new System.Windows.Forms.Button();
            this.DeleteGroItemButton = new System.Windows.Forms.Button();
            this.UpdateRestockedButton = new System.Windows.Forms.Button();
            this.SortItemButton = new System.Windows.Forms.Button();
            this.QSoldTxtBox = new System.Windows.Forms.TextBox();
            this.QRestockTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveGrocButton = new System.Windows.Forms.Button();
            this.SaveSalesButton = new System.Windows.Forms.Button();
            this.SaveRestockButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LoadDataGroupBox.SuspendLayout();
            this.UpdateDataGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Superstore
            // 
            this.Superstore.AutoSize = true;
            this.Superstore.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Superstore.Location = new System.Drawing.Point(220, -5);
            this.Superstore.Name = "Superstore";
            this.Superstore.Size = new System.Drawing.Size(895, 54);
            this.Superstore.TabIndex = 0;
            this.Superstore.Text = "SuperStore Grocery Management System";
            // 
            // OutPutListBox
            // 
            this.OutPutListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutListBox.FormattingEnabled = true;
            this.OutPutListBox.ItemHeight = 14;
            this.OutPutListBox.Location = new System.Drawing.Point(32, 52);
            this.OutPutListBox.Name = "OutPutListBox";
            this.OutPutListBox.Size = new System.Drawing.Size(1298, 284);
            this.OutPutListBox.TabIndex = 1;
            this.OutPutListBox.SelectedIndexChanged += new System.EventHandler(this.OutPutListBox_SelectedIndexChanged);
            // 
            // LoadGroceryButton
            // 
            this.LoadGroceryButton.Location = new System.Drawing.Point(38, 28);
            this.LoadGroceryButton.Name = "LoadGroceryButton";
            this.LoadGroceryButton.Size = new System.Drawing.Size(123, 51);
            this.LoadGroceryButton.TabIndex = 2;
            this.LoadGroceryButton.Text = "Load Grocery Data";
            this.LoadGroceryButton.UseVisualStyleBackColor = true;
            this.LoadGroceryButton.Click += new System.EventHandler(this.LoadGroceryButton_Click);
            // 
            // LoadDataGroupBox
            // 
            this.LoadDataGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadDataGroupBox.Controls.Add(this.LoadGroceryButton);
            this.LoadDataGroupBox.Location = new System.Drawing.Point(32, 360);
            this.LoadDataGroupBox.Name = "LoadDataGroupBox";
            this.LoadDataGroupBox.Size = new System.Drawing.Size(200, 95);
            this.LoadDataGroupBox.TabIndex = 3;
            this.LoadDataGroupBox.TabStop = false;
            this.LoadDataGroupBox.Text = "Load Data";
            // 
            // UpdateSoldButton
            // 
            this.UpdateSoldButton.Location = new System.Drawing.Point(84, 37);
            this.UpdateSoldButton.Name = "UpdateSoldButton";
            this.UpdateSoldButton.Size = new System.Drawing.Size(119, 50);
            this.UpdateSoldButton.TabIndex = 4;
            this.UpdateSoldButton.Text = "Update Sold Qty For Selected Items";
            this.UpdateSoldButton.UseVisualStyleBackColor = true;
            this.UpdateSoldButton.Click += new System.EventHandler(this.UpdateSoldButton_Click);
            // 
            // DeleteGroItemButton
            // 
            this.DeleteGroItemButton.Location = new System.Drawing.Point(84, 93);
            this.DeleteGroItemButton.Name = "DeleteGroItemButton";
            this.DeleteGroItemButton.Size = new System.Drawing.Size(119, 50);
            this.DeleteGroItemButton.TabIndex = 5;
            this.DeleteGroItemButton.Text = "Delete Selected Grocery Item";
            this.DeleteGroItemButton.UseVisualStyleBackColor = true;
            this.DeleteGroItemButton.Click += new System.EventHandler(this.DeleteGroItemButton_Click);
            // 
            // UpdateRestockedButton
            // 
            this.UpdateRestockedButton.Location = new System.Drawing.Point(405, 37);
            this.UpdateRestockedButton.Name = "UpdateRestockedButton";
            this.UpdateRestockedButton.Size = new System.Drawing.Size(119, 50);
            this.UpdateRestockedButton.TabIndex = 6;
            this.UpdateRestockedButton.Text = "Update Restocked Qty For Selected Item";
            this.UpdateRestockedButton.UseVisualStyleBackColor = true;
            this.UpdateRestockedButton.Click += new System.EventHandler(this.UpdateRestockedButton_Click);
            // 
            // SortItemButton
            // 
            this.SortItemButton.Location = new System.Drawing.Point(405, 93);
            this.SortItemButton.Name = "SortItemButton";
            this.SortItemButton.Size = new System.Drawing.Size(119, 50);
            this.SortItemButton.TabIndex = 7;
            this.SortItemButton.Text = "Sort Item Based on Sales";
            this.SortItemButton.UseVisualStyleBackColor = true;
            this.SortItemButton.Click += new System.EventHandler(this.SortItemButton_Click);
            // 
            // QSoldTxtBox
            // 
            this.QSoldTxtBox.Location = new System.Drawing.Point(145, 11);
            this.QSoldTxtBox.Name = "QSoldTxtBox";
            this.QSoldTxtBox.Size = new System.Drawing.Size(117, 20);
            this.QSoldTxtBox.TabIndex = 8;
            this.QSoldTxtBox.TextChanged += new System.EventHandler(this.QSoldTxtBox_TextChanged);
            // 
            // QRestockTxtBox
            // 
            this.QRestockTxtBox.Location = new System.Drawing.Point(449, 11);
            this.QRestockTxtBox.Name = "QRestockTxtBox";
            this.QRestockTxtBox.Size = new System.Drawing.Size(117, 20);
            this.QRestockTxtBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity Sold:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity Restocked:";
            // 
            // UpdateDataGroupBox
            // 
            this.UpdateDataGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateDataGroupBox.Controls.Add(this.label2);
            this.UpdateDataGroupBox.Controls.Add(this.label1);
            this.UpdateDataGroupBox.Controls.Add(this.QRestockTxtBox);
            this.UpdateDataGroupBox.Controls.Add(this.QSoldTxtBox);
            this.UpdateDataGroupBox.Controls.Add(this.SortItemButton);
            this.UpdateDataGroupBox.Controls.Add(this.UpdateRestockedButton);
            this.UpdateDataGroupBox.Controls.Add(this.DeleteGroItemButton);
            this.UpdateDataGroupBox.Controls.Add(this.UpdateSoldButton);
            this.UpdateDataGroupBox.Location = new System.Drawing.Point(364, 360);
            this.UpdateDataGroupBox.Name = "UpdateDataGroupBox";
            this.UpdateDataGroupBox.Size = new System.Drawing.Size(611, 161);
            this.UpdateDataGroupBox.TabIndex = 12;
            this.UpdateDataGroupBox.TabStop = false;
            this.UpdateDataGroupBox.Text = "Update Data";
            // 
            // SaveGrocButton
            // 
            this.SaveGrocButton.Location = new System.Drawing.Point(31, 10);
            this.SaveGrocButton.Name = "SaveGrocButton";
            this.SaveGrocButton.Size = new System.Drawing.Size(119, 50);
            this.SaveGrocButton.TabIndex = 16;
            this.SaveGrocButton.Text = "Save Grocery Data";
            this.SaveGrocButton.UseVisualStyleBackColor = true;
            this.SaveGrocButton.Click += new System.EventHandler(this.SaveGrocButton_Click);
            // 
            // SaveSalesButton
            // 
            this.SaveSalesButton.Location = new System.Drawing.Point(31, 66);
            this.SaveSalesButton.Name = "SaveSalesButton";
            this.SaveSalesButton.Size = new System.Drawing.Size(119, 50);
            this.SaveSalesButton.TabIndex = 17;
            this.SaveSalesButton.Text = "Save Sales Report";
            this.SaveSalesButton.UseVisualStyleBackColor = true;
            this.SaveSalesButton.Click += new System.EventHandler(this.SaveSalesButton_Click);
            // 
            // SaveRestockButton
            // 
            this.SaveRestockButton.Location = new System.Drawing.Point(31, 122);
            this.SaveRestockButton.Name = "SaveRestockButton";
            this.SaveRestockButton.Size = new System.Drawing.Size(119, 50);
            this.SaveRestockButton.TabIndex = 18;
            this.SaveRestockButton.Text = "Save Restock Needs Report";
            this.SaveRestockButton.UseVisualStyleBackColor = true;
            this.SaveRestockButton.Click += new System.EventHandler(this.SaveRestockButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.SaveRestockButton);
            this.groupBox1.Controls.Add(this.SaveSalesButton);
            this.groupBox1.Controls.Add(this.SaveGrocButton);
            this.groupBox1.Location = new System.Drawing.Point(1125, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 187);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Data";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(317, 551);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(5);
            this.StatusLabel.Size = new System.Drawing.Size(692, 47);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "Operation Status Update Displayed Here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.UseMnemonic = false;
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // QuantitySoldLabelBut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 636);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateDataGroupBox);
            this.Controls.Add(this.LoadDataGroupBox);
            this.Controls.Add(this.OutPutListBox);
            this.Controls.Add(this.Superstore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QuantitySoldLabelBut";
            this.Text = "Form1";
            this.LoadDataGroupBox.ResumeLayout(false);
            this.UpdateDataGroupBox.ResumeLayout(false);
            this.UpdateDataGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Superstore;
        private System.Windows.Forms.ListBox OutPutListBox;
        private System.Windows.Forms.Button LoadGroceryButton;
        private System.Windows.Forms.GroupBox LoadDataGroupBox;
        private System.Windows.Forms.Button UpdateSoldButton;
        private System.Windows.Forms.Button DeleteGroItemButton;
        private System.Windows.Forms.Button UpdateRestockedButton;
        private System.Windows.Forms.Button SortItemButton;
        private System.Windows.Forms.TextBox QSoldTxtBox;
        private System.Windows.Forms.TextBox QRestockTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox UpdateDataGroupBox;
        private System.Windows.Forms.Button SaveGrocButton;
        private System.Windows.Forms.Button SaveSalesButton;
        private System.Windows.Forms.Button SaveRestockButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label StatusLabel;
    }
}

