namespace Машина_тьюринга
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.Lenta = new System.Windows.Forms.DataGridView();
            this.EventTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LentaNum = new System.Windows.Forms.DataGridView();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.buttonAddCol = new System.Windows.Forms.Button();
            this.buttonDelCol = new System.Windows.Forms.Button();
            this.labelYourAlphabet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LentaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTask
            // 
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(12, 48);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(710, 67);
            this.textBoxTask.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Условие задачи:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.СохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // СохранитьToolStripMenuItem
            // 
            this.СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem";
            this.СохранитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.СохранитьToolStripMenuItem.Text = "Сохранить...";
            this.СохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(567, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Комментарий к состояниям";
            // 
            // textBoxComment
            // 
            this.textBoxComment.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxComment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxComment.Location = new System.Drawing.Point(534, 274);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(246, 282);
            this.textBoxComment.TabIndex = 5;
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(12, 245);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(131, 23);
            this.CreateTableButton.TabIndex = 6;
            this.CreateTableButton.Text = "Создание алфавита";
            this.toolTipInfo.SetToolTip(this.CreateTableButton, "Выберете один из предложенных \r\nалфавитов или задайте свой!");
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // Lenta
            // 
            this.Lenta.AllowUserToAddRows = false;
            this.Lenta.AllowUserToDeleteRows = false;
            this.Lenta.AllowUserToResizeColumns = false;
            this.Lenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Lenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Lenta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Lenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lenta.ColumnHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Lenta.DefaultCellStyle = dataGridViewCellStyle7;
            this.Lenta.Location = new System.Drawing.Point(0, 31);
            this.Lenta.MultiSelect = false;
            this.Lenta.Name = "Lenta";
            this.Lenta.ReadOnly = true;
            this.Lenta.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lenta.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Lenta.RowTemplate.Height = 30;
            this.Lenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Lenta.ShowCellToolTips = false;
            this.Lenta.ShowEditingIcon = false;
            this.Lenta.Size = new System.Drawing.Size(727, 33);
            this.Lenta.TabIndex = 9;
            this.Lenta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Lenta_CellMouseClick);
            // 
            // EventTable
            // 
            this.EventTable.AllowUserToAddRows = false;
            this.EventTable.AllowUserToDeleteRows = false;
            this.EventTable.AllowUserToResizeColumns = false;
            this.EventTable.AllowUserToResizeRows = false;
            this.EventTable.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.EventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventTable.ColumnHeadersVisible = false;
            this.EventTable.Location = new System.Drawing.Point(0, 274);
            this.EventTable.MultiSelect = false;
            this.EventTable.Name = "EventTable";
            this.EventTable.RowHeadersVisible = false;
            this.EventTable.Size = new System.Drawing.Size(516, 282);
            this.EventTable.TabIndex = 10;
            this.EventTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventTable_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LentaNum);
            this.groupBox1.Controls.Add(this.Lenta);
            this.groupBox1.Location = new System.Drawing.Point(31, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 64);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // LentaNum
            // 
            this.LentaNum.AllowUserToAddRows = false;
            this.LentaNum.AllowUserToDeleteRows = false;
            this.LentaNum.AllowUserToResizeColumns = false;
            this.LentaNum.AllowUserToResizeRows = false;
            this.LentaNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LentaNum.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LentaNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LentaNum.ColumnHeadersVisible = false;
            this.LentaNum.Enabled = false;
            this.LentaNum.Location = new System.Drawing.Point(0, 7);
            this.LentaNum.Name = "LentaNum";
            this.LentaNum.ReadOnly = true;
            this.LentaNum.RowHeadersVisible = false;
            this.LentaNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LentaNum.Size = new System.Drawing.Size(727, 24);
            this.LentaNum.TabIndex = 10;
            // 
            // Left
            // 
            this.Left.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Left.Location = new System.Drawing.Point(0, 164);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(34, 57);
            this.Left.TabIndex = 11;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Right.Location = new System.Drawing.Point(751, 164);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(41, 57);
            this.Right.TabIndex = 12;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // buttonAddCol
            // 
            this.buttonAddCol.Location = new System.Drawing.Point(97, 562);
            this.buttonAddCol.Name = "buttonAddCol";
            this.buttonAddCol.Size = new System.Drawing.Size(141, 24);
            this.buttonAddCol.TabIndex = 15;
            this.buttonAddCol.Text = "Добавление Столбца";
            this.buttonAddCol.UseVisualStyleBackColor = true;
            this.buttonAddCol.Click += new System.EventHandler(this.buttonAddCol_Click);
            // 
            // buttonDelCol
            // 
            this.buttonDelCol.Location = new System.Drawing.Point(257, 563);
            this.buttonDelCol.Name = "buttonDelCol";
            this.buttonDelCol.Size = new System.Drawing.Size(122, 23);
            this.buttonDelCol.TabIndex = 17;
            this.buttonDelCol.Text = "Удаление столбца";
            this.buttonDelCol.UseVisualStyleBackColor = true;
            this.buttonDelCol.Click += new System.EventHandler(this.buttonDelCol_Click);
            // 
            // labelYourAlphabet
            // 
            this.labelYourAlphabet.AutoSize = true;
            this.labelYourAlphabet.Location = new System.Drawing.Point(28, 132);
            this.labelYourAlphabet.Name = "labelYourAlphabet";
            this.labelYourAlphabet.Size = new System.Drawing.Size(78, 13);
            this.labelYourAlphabet.TabIndex = 18;
            this.labelYourAlphabet.Text = "Ваш Алфавит:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(390, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "^";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Image = global::Машина_тьюринга.Properties.Resources.shell32_290;
            this.buttonStart.Location = new System.Drawing.Point(31, 562);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(24, 23);
            this.buttonStart.TabIndex = 14;
            this.toolTipInfo.SetToolTip(this.buttonStart, "Нажатие данной кнопки запустит программу!");
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(396, 563);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(75, 23);
            this.buttonStep.TabIndex = 21;
            this.buttonStep.Text = "Пошагово";
            this.toolTipInfo.SetToolTip(this.buttonStep, "Каждое нажатие кнопки последовательно \r\nвыполнит один шаг алгоритма!");
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AutomaticDelay = 100;
            this.toolTipInfo.AutoPopDelay = 5000;
            this.toolTipInfo.InitialDelay = 100;
            this.toolTipInfo.ReshowDelay = 20;
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo.ToolTipTitle = "Подсказка";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 593);
            this.Controls.Add(this.buttonStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelYourAlphabet);
            this.Controls.Add(this.buttonDelCol);
            this.Controls.Add(this.buttonAddCol);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.EventTable);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTask);
            this.Name = "Main";
            this.Text = "Интерпретатор Машины Тьюринга";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LentaNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.DataGridView Lenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView LentaNum;
        private new System.Windows.Forms.Button Right;
        private new System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button buttonDelCol;
        public System.Windows.Forms.DataGridView EventTable;
        public System.Windows.Forms.Button buttonStart;
        public System.Windows.Forms.Button buttonAddCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        public System.Windows.Forms.Label labelYourAlphabet;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.ToolStripMenuItem СохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipInfo;
    }
}

