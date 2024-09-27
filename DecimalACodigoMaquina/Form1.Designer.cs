namespace DecimalACodigoMaquina
{
    partial class form1
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
            inputBox = new TextBox();
            convertButton = new Button();
            label1 = new Label();
            dwButton = new Button();
            ddButton = new Button();
            dqButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.BackColor = SystemColors.ButtonHighlight;
            inputBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            inputBox.Location = new Point(39, 70);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(255, 34);
            inputBox.TabIndex = 0;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(325, 70);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(122, 34);
            convertButton.TabIndex = 1;
            convertButton.Text = "CONVERTIR";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(39, 182);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 2;
            label1.Text = "linea 180";
            // 
            // dwButton
            // 
            dwButton.Location = new Point(497, 70);
            dwButton.Name = "dwButton";
            dwButton.Size = new Size(122, 34);
            dwButton.TabIndex = 1;
            dwButton.Text = "DW";
            dwButton.UseVisualStyleBackColor = true;
            dwButton.Click += dwButton_Click;
            // 
            // ddButton
            // 
            ddButton.Location = new Point(497, 127);
            ddButton.Name = "ddButton";
            ddButton.Size = new Size(122, 34);
            ddButton.TabIndex = 1;
            ddButton.Text = "DD";
            ddButton.UseVisualStyleBackColor = true;
            ddButton.Click += ddButton_Click;
            // 
            // dqButton
            // 
            dqButton.Location = new Point(497, 182);
            dqButton.Name = "dqButton";
            dqButton.Size = new Size(122, 34);
            dqButton.TabIndex = 1;
            dqButton.Text = "DQ";
            dqButton.UseVisualStyleBackColor = true;
            dqButton.Click += dqButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(39, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dqButton);
            Controls.Add(ddButton);
            Controls.Add(dwButton);
            Controls.Add(convertButton);
            Controls.Add(inputBox);
            Name = "form1";
            Text = "Convertidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Button convertButton;
        private Label label1;
        private Button dwButton;
        private Button ddButton;
        private Button dqButton;
        private Label label2;
    }
}