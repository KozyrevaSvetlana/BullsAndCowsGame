namespace BullWindowsFormsApp
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.rulesOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Правила игры \"Быки и коровы\"";
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesLabel.Location = new System.Drawing.Point(14, 56);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rulesLabel.Size = new System.Drawing.Size(741, 247);
            this.rulesLabel.TabIndex = 2;
            this.rulesLabel.Text = resources.GetString("rulesLabel.Text");
            // 
            // rulesOkButton
            // 
            this.rulesOkButton.Location = new System.Drawing.Point(308, 332);
            this.rulesOkButton.Name = "rulesOkButton";
            this.rulesOkButton.Size = new System.Drawing.Size(133, 41);
            this.rulesOkButton.TabIndex = 3;
            this.rulesOkButton.Text = "OK";
            this.rulesOkButton.UseVisualStyleBackColor = true;
            this.rulesOkButton.Click += new System.EventHandler(this.rulesOkButton_Click);
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 391);
            this.Controls.Add(this.rulesOkButton);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.label1);
            this.Name = "RulesForm";
            this.Text = "RulesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Button rulesOkButton;
    }
}