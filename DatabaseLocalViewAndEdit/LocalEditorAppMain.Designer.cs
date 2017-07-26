namespace DatabaseLocalViewAndEdit
{
    partial class LocalEditorAppMain
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
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.dbSelector = new System.Windows.Forms.ComboBox();
            this.btnEditDeleteRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Enabled = false;
            this.btnAddRecord.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRecord.Location = new System.Drawing.Point(51, 99);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(275, 36);
            this.btnAddRecord.TabIndex = 0;
            this.btnAddRecord.Text = "Создать запись";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            // 
            // dbSelector
            // 
            this.dbSelector.FormattingEnabled = true;
            this.dbSelector.Location = new System.Drawing.Point(51, 21);
            this.dbSelector.Name = "dbSelector";
            this.dbSelector.Size = new System.Drawing.Size(275, 21);
            this.dbSelector.TabIndex = 1;
            this.dbSelector.Text = "Выберите таблицу данных...";
            this.dbSelector.SelectedIndexChanged += new System.EventHandler(this.dbSelector_SelectedIndexChanged);
            // 
            // btnEditDeleteRecord
            // 
            this.btnEditDeleteRecord.Enabled = false;
            this.btnEditDeleteRecord.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditDeleteRecord.Location = new System.Drawing.Point(51, 141);
            this.btnEditDeleteRecord.Name = "btnEditDeleteRecord";
            this.btnEditDeleteRecord.Size = new System.Drawing.Size(274, 40);
            this.btnEditDeleteRecord.TabIndex = 2;
            this.btnEditDeleteRecord.Text = "Редактировать/Удалить запись";
            this.btnEditDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // LocalEditorAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 241);
            this.Controls.Add(this.btnEditDeleteRecord);
            this.Controls.Add(this.dbSelector);
            this.Controls.Add(this.btnAddRecord);
            this.Name = "LocalEditorAppMain";
            this.Text = "Редактор Базы - Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.ComboBox dbSelector;
        private System.Windows.Forms.Button btnEditDeleteRecord;
    }
}

