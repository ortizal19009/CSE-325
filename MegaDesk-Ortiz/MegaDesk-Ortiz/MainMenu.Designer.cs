namespace MegaDesk_Ortiz
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddQuote = new Button();
            SearchQuotes = new Button();
            ViewAllQuotes = new Button();
            Exit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddQuote
            // 
            AddQuote.Location = new Point(22, 103);
            AddQuote.Name = "AddQuote";
            AddQuote.Size = new Size(112, 23);
            AddQuote.TabIndex = 0;
            AddQuote.Text = "AddQuote";
            AddQuote.UseVisualStyleBackColor = true;
            AddQuote.Click += AddQuote_Click;
            // 
            // SearchQuotes
            // 
            SearchQuotes.Location = new Point(22, 147);
            SearchQuotes.Name = "SearchQuotes";
            SearchQuotes.Size = new Size(112, 23);
            SearchQuotes.TabIndex = 1;
            SearchQuotes.Text = "SearchQuotes";
            SearchQuotes.UseVisualStyleBackColor = true;
            SearchQuotes.Click += SearchQuotes_Click;
            // 
            // ViewAllQuotes
            // 
            ViewAllQuotes.Location = new Point(22, 192);
            ViewAllQuotes.Name = "ViewAllQuotes";
            ViewAllQuotes.Size = new Size(112, 23);
            ViewAllQuotes.TabIndex = 2;
            ViewAllQuotes.Text = "ViewAllQuotes";
            ViewAllQuotes.UseVisualStyleBackColor = true;
            ViewAllQuotes.Click += ViewAllQuotes_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(22, 235);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 23);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 28);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 4;
            label1.Text = "MegaDesk 1.0 - Ortiz";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(ViewAllQuotes);
            Controls.Add(SearchQuotes);
            Controls.Add(AddQuote);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddQuote;
        private Button SearchQuotes;
        private Button ViewAllQuotes;
        private Button Exit;
        private Label label1;
    }
}