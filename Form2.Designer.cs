namespace PCBTool
{
    partial class FormKonfiguracja
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
            textBoxKatalogRoboczy = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            textBox1 = new TextBox();
            buttonTestEmail = new Button();
            checkBox2 = new CheckBox();
            buttonTak = new Button();
            buttonNie = new Button();
            SuspendLayout();
            // 
            // textBoxKatalogRoboczy
            // 
            textBoxKatalogRoboczy.Location = new Point(24, 26);
            textBoxKatalogRoboczy.Name = "textBoxKatalogRoboczy";
            textBoxKatalogRoboczy.Size = new Size(221, 23);
            textBoxKatalogRoboczy.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 8);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Katalog roboczy";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(24, 66);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(184, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Wysyłanie email'a awaryjnego";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 88);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Adres email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 4;
            // 
            // buttonTestEmail
            // 
            buttonTestEmail.Location = new Point(248, 106);
            buttonTestEmail.Name = "buttonTestEmail";
            buttonTestEmail.Size = new Size(75, 23);
            buttonTestEmail.TabIndex = 5;
            buttonTestEmail.Text = "Test";
            buttonTestEmail.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(24, 159);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(161, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Pamiętaj parametry okien";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // buttonTak
            // 
            buttonTak.Location = new Point(248, 202);
            buttonTak.Name = "buttonTak";
            buttonTak.Size = new Size(75, 23);
            buttonTak.TabIndex = 7;
            buttonTak.Text = "TAK";
            buttonTak.UseVisualStyleBackColor = true;
            // 
            // buttonNie
            // 
            buttonNie.Location = new Point(152, 202);
            buttonNie.Name = "buttonNie";
            buttonNie.Size = new Size(75, 23);
            buttonNie.TabIndex = 8;
            buttonNie.Text = "NIE";
            buttonNie.UseVisualStyleBackColor = true;
            // 
            // FormKonfiguracja
            // 
            AcceptButton = buttonTak;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonNie;
            ClientSize = new Size(338, 238);
            Controls.Add(buttonNie);
            Controls.Add(buttonTak);
            Controls.Add(checkBox2);
            Controls.Add(buttonTestEmail);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(textBoxKatalogRoboczy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormKonfiguracja";
            Text = "Konfiguracja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxKatalogRoboczy;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox textBox1;
        private Button buttonTestEmail;
        private CheckBox checkBox2;
        private Button buttonTak;
        private Button buttonNie;
    }
}