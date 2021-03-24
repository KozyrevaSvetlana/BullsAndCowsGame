namespace BullWindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.puzzledWordLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.bullsCountLabel = new System.Windows.Forms.Label();
            this.cowsCountLabel = new System.Windows.Forms.Label();
            this.infoUserAnswerLabel = new System.Windows.Forms.Label();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.StepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BullsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CowsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // puzzledWordLabel
            // 
            this.puzzledWordLabel.AutoSize = true;
            this.puzzledWordLabel.Location = new System.Drawing.Point(13, 425);
            this.puzzledWordLabel.Name = "puzzledWordLabel";
            this.puzzledWordLabel.Size = new System.Drawing.Size(13, 13);
            this.puzzledWordLabel.TabIndex = 0;
            this.puzzledWordLabel.Text = "0";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(16, 174);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(183, 20);
            this.userAnswerTextBox.TabIndex = 1;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(249, 170);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "ОК";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // bullsCountLabel
            // 
            this.bullsCountLabel.AutoSize = true;
            this.bullsCountLabel.Location = new System.Drawing.Point(16, 229);
            this.bullsCountLabel.Name = "bullsCountLabel";
            this.bullsCountLabel.Size = new System.Drawing.Size(46, 13);
            this.bullsCountLabel.TabIndex = 3;
            this.bullsCountLabel.Text = "Быков: ";
            // 
            // cowsCountLabel
            // 
            this.cowsCountLabel.AutoSize = true;
            this.cowsCountLabel.Location = new System.Drawing.Point(16, 268);
            this.cowsCountLabel.Name = "cowsCountLabel";
            this.cowsCountLabel.Size = new System.Drawing.Size(44, 13);
            this.cowsCountLabel.TabIndex = 4;
            this.cowsCountLabel.Text = "Коров: ";
            // 
            // infoUserAnswerLabel
            // 
            this.infoUserAnswerLabel.AutoSize = true;
            this.infoUserAnswerLabel.Location = new System.Drawing.Point(19, 136);
            this.infoUserAnswerLabel.Name = "infoUserAnswerLabel";
            this.infoUserAnswerLabel.Size = new System.Drawing.Size(158, 13);
            this.infoUserAnswerLabel.TabIndex = 5;
            this.infoUserAnswerLabel.Text = "Введите 4 уникальных цифры";
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepColumn,
            this.BullsColumn,
            this.CowsColumn,
            this.NumberColumn});
            this.historyDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.historyDataGridView.Location = new System.Drawing.Point(379, 34);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.Size = new System.Drawing.Size(409, 404);
            this.historyDataGridView.TabIndex = 6;
            // 
            // StepColumn
            // 
            this.StepColumn.HeaderText = "Ход";
            this.StepColumn.Name = "StepColumn";
            this.StepColumn.ReadOnly = true;
            // 
            // BullsColumn
            // 
            this.BullsColumn.HeaderText = "Быков";
            this.BullsColumn.Name = "BullsColumn";
            this.BullsColumn.ReadOnly = true;
            // 
            // CowsColumn
            // 
            this.CowsColumn.HeaderText = "Коров";
            this.CowsColumn.Name = "CowsColumn";
            this.CowsColumn.ReadOnly = true;
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Число";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.infoUserAnswerLabel);
            this.Controls.Add(this.cowsCountLabel);
            this.Controls.Add(this.bullsCountLabel);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.puzzledWordLabel);
            this.Name = "MainForm";
            this.Text = "Игра \"Быки и коровы\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label puzzledWordLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label bullsCountLabel;
        private System.Windows.Forms.Label cowsCountLabel;
        private System.Windows.Forms.Label infoUserAnswerLabel;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BullsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CowsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
    }
}

