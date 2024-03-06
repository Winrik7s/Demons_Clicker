namespace Winki.Clicker.D
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Button4;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(90, 160);
            button1.Name = "button1";
            button1.Size = new Size(220, 220);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.Button2UP;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(90, 395);
            button2.Name = "button2";
            button2.Size = new Size(220, 48);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label4);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(90, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 29);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.No;
            label4.ForeColor = Color.DarkMagenta;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 6;
            label4.Text = "HP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.No;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Total score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(5, 30);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Points:";
            label2.DoubleClick += Label2_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.IBeam;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(5, 55);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Damage:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.IBeam;
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 474);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 6;
            label5.Text = "GitHub Version";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fon_Form;
            ClientSize = new Size(388, 492);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demon's Clicker";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}
