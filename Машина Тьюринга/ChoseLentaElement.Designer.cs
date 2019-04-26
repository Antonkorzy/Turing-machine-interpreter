namespace Машина_тьюринга
{
    partial class ChoseLentaElement
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
            this.ChoseElTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ChoseElTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoseElTable
            // 
            this.ChoseElTable.AllowUserToAddRows = false;
            this.ChoseElTable.AllowUserToDeleteRows = false;
            this.ChoseElTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChoseElTable.ColumnHeadersVisible = false;
            this.ChoseElTable.Location = new System.Drawing.Point(-1, 0);
            this.ChoseElTable.MultiSelect = false;
            this.ChoseElTable.Name = "ChoseElTable";
            this.ChoseElTable.ReadOnly = true;
            this.ChoseElTable.RowHeadersVisible = false;
            this.ChoseElTable.Size = new System.Drawing.Size(785, 42);
            this.ChoseElTable.TabIndex = 0;
            this.ChoseElTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ChoseElTable_CellMouseClick);
            // 
            // ChoseLentaElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 43);
            this.Controls.Add(this.ChoseElTable);
            this.Name = "ChoseLentaElement";
            this.Text = "ChoseElement";
            this.Load += new System.EventHandler(this.ChoseLentaElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChoseElTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ChoseElTable;
    }
}