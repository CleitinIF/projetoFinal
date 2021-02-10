
namespace ProjetoFinal
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mSubmit = new System.Windows.Forms.Button();
            this.mDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.mContent = new System.Windows.Forms.RichTextBox();
            this.mTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.mCancel);
            this.panel1.Controls.Add(this.mSubmit);
            this.panel1.Controls.Add(this.mDataGrid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mContent);
            this.panel1.Controls.Add(this.mTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 545);
            this.panel1.TabIndex = 0;
            // 
            // mSubmit
            // 
            this.mSubmit.Location = new System.Drawing.Point(12, 202);
            this.mSubmit.Name = "mSubmit";
            this.mSubmit.Size = new System.Drawing.Size(147, 30);
            this.mSubmit.TabIndex = 5;
            this.mSubmit.Text = "Salvar";
            this.mSubmit.UseVisualStyleBackColor = true;
            this.mSubmit.Click += new System.EventHandler(this.mSubmit_Click);
            // 
            // mDataGrid
            // 
            this.mDataGrid.AllowUserToAddRows = false;
            this.mDataGrid.AllowUserToDeleteRows = false;
            this.mDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGrid.Location = new System.Drawing.Point(12, 243);
            this.mDataGrid.Name = "mDataGrid";
            this.mDataGrid.ReadOnly = true;
            this.mDataGrid.Size = new System.Drawing.Size(310, 288);
            this.mDataGrid.TabIndex = 4;
            this.mDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mDataGrid_CellMouseClick);
            this.mDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mDataGrid_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conteudo";
            // 
            // mContent
            // 
            this.mContent.Location = new System.Drawing.Point(12, 64);
            this.mContent.Name = "mContent";
            this.mContent.Size = new System.Drawing.Size(310, 130);
            this.mContent.TabIndex = 2;
            this.mContent.Text = "";
            // 
            // mTitle
            // 
            this.mTitle.Location = new System.Drawing.Point(12, 25);
            this.mTitle.Name = "mTitle";
            this.mTitle.Size = new System.Drawing.Size(310, 20);
            this.mTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // mCancel
            // 
            this.mCancel.Location = new System.Drawing.Point(166, 202);
            this.mCancel.Name = "mCancel";
            this.mCancel.Size = new System.Drawing.Size(156, 30);
            this.mCancel.TabIndex = 6;
            this.mCancel.Text = "Cancelar";
            this.mCancel.UseVisualStyleBackColor = true;
            this.mCancel.Click += new System.EventHandler(this.mCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 543);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mTitle;
        private System.Windows.Forms.RichTextBox mContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView mDataGrid;
        private System.Windows.Forms.Button mSubmit;
        private System.Windows.Forms.Button mCancel;
    }
}

