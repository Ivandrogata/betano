namespace betano
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
            mashinki = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // mashinki
            // 
            mashinki.Location = new Point(570, 96);
            mashinki.Name = "mashinki";
            mashinki.Size = new Size(158, 56);
            mashinki.TabIndex = 0;
            mashinki.Text = "pikoto ne proshtava";
            mashinki.TextAlign = ContentAlignment.MiddleRight;
            mashinki.UseVisualStyleBackColor = true;
            mashinki.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.Location = new Point(1, 100);
            button2.Name = "button2";
            button2.Size = new Size(122, 52);
            button2.TabIndex = 1;
            button2.Text = "whitepower";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 114);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(593, 180);
            button1.Name = "button1";
            button1.Size = new Size(115, 64);
            button1.TabIndex = 3;
            button1.Text = "MANQK SI ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_3;
            // 
            // button3
            // 
            button3.Location = new Point(6, 180);
            button3.Name = "button3";
            button3.Size = new Size(117, 64);
            button3.TabIndex = 4;
            button3.Text = "deportaciq vednaga";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 349);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(mashinki);
            Cursor = Cursors.IBeam;
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mashinki;
        private Button button2;
        private Label label1;
        private Button button1;
        private Button button3;
    }
}