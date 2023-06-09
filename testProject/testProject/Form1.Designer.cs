namespace testProject
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
            listBox1 = new ListBox();
            buttonSave = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            buttonGO = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(387, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 304);
            listBox1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(33, 103);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(33, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(276, 31);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 3;
            label1.Text = "nama pet :";
            // 
            // buttonGO
            // 
            buttonGO.Location = new Point(33, 157);
            buttonGO.Name = "buttonGO";
            buttonGO.Size = new Size(348, 102);
            buttonGO.TabIndex = 4;
            buttonGO.Text = "GO !";
            buttonGO.UseVisualStyleBackColor = true;
            buttonGO.Click += buttonGO_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 287);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "basic";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(151, 287);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "skill";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(269, 287);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "ulti";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 349);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonGO);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonSave);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button buttonSave;
        private TextBox textBoxName;
        private Label label1;
        private Button buttonGO;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}