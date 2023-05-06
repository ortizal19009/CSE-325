namespace MegaDesk_Ortiz
{
    partial class SearchQuotesForm
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
            Menu = new Button();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Location = new Point(91, 237);
            Menu.Name = "Menu";
            Menu.Size = new Size(75, 23);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // SearchQuotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(Menu);
            Name = "SearchQuotesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchQuotes";
            ResumeLayout(false);
        }

        #endregion

        private Button Menu;
    }
}