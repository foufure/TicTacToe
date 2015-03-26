namespace TicTacToe.WinForms.MVP
{
    partial class TicTacToeGUI
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
            this.ApplicationLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.TicTacToeGameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.C0 = new System.Windows.Forms.Label();
            this.B0 = new System.Windows.Forms.Label();
            this.A0 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.GameInformation = new System.Windows.Forms.TextBox();
            this.ApplicationLayout.SuspendLayout();
            this.TicTacToeGameBoard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationLayout
            // 
            this.ApplicationLayout.BackColor = System.Drawing.Color.White;
            this.ApplicationLayout.Controls.Add(this.TicTacToeGameBoard);
            this.ApplicationLayout.Controls.Add(this.GameInformation);
            this.ApplicationLayout.Controls.Add(this.tableLayoutPanel1);
            this.ApplicationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplicationLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ApplicationLayout.Location = new System.Drawing.Point(0, 0);
            this.ApplicationLayout.Name = "ApplicationLayout";
            this.ApplicationLayout.Size = new System.Drawing.Size(287, 541);
            this.ApplicationLayout.TabIndex = 0;
            // 
            // TicTacToeGameBoard
            // 
            this.TicTacToeGameBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.TicTacToeGameBoard.ColumnCount = 3;
            this.TicTacToeGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeGameBoard.Controls.Add(this.C0, 2, 2);
            this.TicTacToeGameBoard.Controls.Add(this.B0, 1, 2);
            this.TicTacToeGameBoard.Controls.Add(this.A0, 0, 2);
            this.TicTacToeGameBoard.Controls.Add(this.C1, 2, 1);
            this.TicTacToeGameBoard.Controls.Add(this.B1, 1, 1);
            this.TicTacToeGameBoard.Controls.Add(this.A1, 0, 1);
            this.TicTacToeGameBoard.Controls.Add(this.C2, 2, 0);
            this.TicTacToeGameBoard.Controls.Add(this.B2, 1, 0);
            this.TicTacToeGameBoard.Controls.Add(this.A2, 0, 0);
            this.TicTacToeGameBoard.Location = new System.Drawing.Point(3, 3);
            this.TicTacToeGameBoard.Name = "TicTacToeGameBoard";
            this.TicTacToeGameBoard.RowCount = 3;
            this.TicTacToeGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TicTacToeGameBoard.Size = new System.Drawing.Size(281, 208);
            this.TicTacToeGameBoard.TabIndex = 0;
            // 
            // C0
            // 
            this.C0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.C0.AutoSize = true;
            this.C0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C0.Location = new System.Drawing.Point(190, 139);
            this.C0.Name = "C0";
            this.C0.Size = new System.Drawing.Size(85, 66);
            this.C0.TabIndex = 8;
            this.C0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C0.Click += new System.EventHandler(this.C0_Click);
            // 
            // B0
            // 
            this.B0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B0.AutoSize = true;
            this.B0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B0.Location = new System.Drawing.Point(98, 139);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(83, 66);
            this.B0.TabIndex = 7;
            this.B0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // A0
            // 
            this.A0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A0.AutoSize = true;
            this.A0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A0.Location = new System.Drawing.Point(6, 139);
            this.A0.Name = "A0";
            this.A0.Size = new System.Drawing.Size(83, 66);
            this.A0.TabIndex = 6;
            this.A0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A0.Click += new System.EventHandler(this.A0_Click);
            // 
            // C1
            // 
            this.C1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.C1.AutoSize = true;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(190, 71);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(85, 65);
            this.C1.TabIndex = 5;
            this.C1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // B1
            // 
            this.B1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B1.AutoSize = true;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(98, 71);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(83, 65);
            this.B1.TabIndex = 4;
            this.B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // A1
            // 
            this.A1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A1.AutoSize = true;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(6, 71);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(83, 65);
            this.A1.TabIndex = 3;
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // C2
            // 
            this.C2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.C2.AutoSize = true;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(190, 3);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(85, 65);
            this.C2.TabIndex = 2;
            this.C2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // B2
            // 
            this.B2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B2.AutoSize = true;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(98, 3);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(83, 65);
            this.B2.TabIndex = 1;
            this.B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // A2
            // 
            this.A2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A2.AutoSize = true;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(6, 3);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(83, 65);
            this.A2.TabIndex = 0;
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRestart, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 508);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 29);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(144, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(134, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // GameInformation
            // 
            this.GameInformation.AcceptsReturn = true;
            this.GameInformation.Location = new System.Drawing.Point(3, 217);
            this.GameInformation.Multiline = true;
            this.GameInformation.Name = "GameInformation";
            this.GameInformation.ReadOnly = true;
            this.GameInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GameInformation.Size = new System.Drawing.Size(281, 285);
            this.GameInformation.TabIndex = 3;
            this.GameInformation.Text = "Game Information:";
            // 
            // TicTacToeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 541);
            this.Controls.Add(this.ApplicationLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TicTacToeGUI";
            this.Text = "TicTacToe";
            this.ApplicationLayout.ResumeLayout(false);
            this.ApplicationLayout.PerformLayout();
            this.TicTacToeGameBoard.ResumeLayout(false);
            this.TicTacToeGameBoard.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ApplicationLayout;
        private System.Windows.Forms.TableLayoutPanel TicTacToeGameBoard;
        private System.Windows.Forms.Label C0;
        private System.Windows.Forms.Label B0;
        private System.Windows.Forms.Label A0;
        private System.Windows.Forms.Label C1;
        private System.Windows.Forms.Label B1;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label C2;
        private System.Windows.Forms.Label B2;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox GameInformation;
    }
}

