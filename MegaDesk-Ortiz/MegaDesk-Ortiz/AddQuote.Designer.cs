namespace MegaDesk_Ortiz
{
    partial class AddQuoteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            customerName = new TextBox();
            sizeWidth = new TextBox();
            sizeDepth = new TextBox();
            nDrawers = new TextBox();
            surfaceMaterial = new ComboBox();
            rushOrder = new ComboBox();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Location = new Point(335, 266);
            Menu.Name = "Menu";
            Menu.Size = new Size(75, 23);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 43);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Customer full name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 43);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Size of desk in width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 43);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 3;
            label3.Text = "Size of desk in depth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 101);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 4;
            label4.Text = "Number of drawers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 101);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 5;
            label5.Text = "Desktop surface material";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 101);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 6;
            label6.Text = "Rush order options";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 9);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 7;
            label7.Text = "Add new quote";
            // 
            // customerName
            // 
            customerName.Location = new Point(3, 61);
            customerName.Name = "customerName";
            customerName.Size = new Size(100, 23);
            customerName.TabIndex = 8;
            customerName.TextChanged += customerName_TextChanged;
            // 
            // sizeWidth
            // 
            sizeWidth.Location = new Point(172, 61);
            sizeWidth.Name = "sizeWidth";
            sizeWidth.Size = new Size(100, 23);
            sizeWidth.TabIndex = 9;
            sizeWidth.TextChanged += sizeWidth_TextChanged;
            // 
            // sizeDepth
            // 
            sizeDepth.Location = new Point(345, 61);
            sizeDepth.Name = "sizeDepth";
            sizeDepth.Size = new Size(100, 23);
            sizeDepth.TabIndex = 10;
            // 
            // nDrawers
            // 
            nDrawers.Location = new Point(1, 119);
            nDrawers.Name = "nDrawers";
            nDrawers.Size = new Size(100, 23);
            nDrawers.TabIndex = 11;
            // 
            // surfaceMaterial
            // 
            surfaceMaterial.FormattingEnabled = true;
            surfaceMaterial.Location = new Point(172, 119);
            surfaceMaterial.Name = "surfaceMaterial";
            surfaceMaterial.Size = new Size(121, 23);
            surfaceMaterial.TabIndex = 12;
            surfaceMaterial.SelectedIndexChanged += surfaceMaterial_SelectedIndexChanged;
            // 
            // rushOrder
            // 
            rushOrder.FormattingEnabled = true;
            rushOrder.Location = new Point(345, 119);
            rushOrder.Name = "rushOrder";
            rushOrder.Size = new Size(121, 23);
            rushOrder.TabIndex = 13;
            // 
            // AddQuoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(rushOrder);
            Controls.Add(surfaceMaterial);
            Controls.Add(nDrawers);
            Controls.Add(sizeDepth);
            Controls.Add(sizeWidth);
            Controls.Add(customerName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Menu);
            Name = "AddQuoteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddQuote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Menu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox customerName;
        private TextBox sizeWidth;
        private TextBox sizeDepth;
        private TextBox nDrawers;
        private ComboBox surfaceMaterial;
        private ComboBox rushOrder;
    }
}