namespace lr_01
{
    partial class Calculator
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            sin = new Button();
            tg = new Button();
            cos = new Button();
            ctg = new Button();
            square = new Button();
            cube = new Button();
            degree = new Button();
            cleanvalues = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            Save = new Button();
            Get = new Button();
            Heaven = new ListBox();
            cleanList = new Button();
            cleanLastElement = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(220, 12);
            textBox3.Name = "textBox3";
            textBox3.ShortcutsEnabled = false;
            textBox3.Size = new Size(152, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // sin
            // 
            sin.Location = new Point(12, 135);
            sin.Name = "sin";
            sin.Size = new Size(94, 29);
            sin.TabIndex = 3;
            sin.Text = "sin";
            sin.UseVisualStyleBackColor = true;
            sin.Click += button1_Click;
            // 
            // tg
            // 
            tg.Location = new Point(12, 184);
            tg.Name = "tg";
            tg.Size = new Size(94, 29);
            tg.TabIndex = 4;
            tg.Text = "tg";
            tg.UseVisualStyleBackColor = true;
            tg.Click += tg_Click;
            // 
            // cos
            // 
            cos.Location = new Point(133, 135);
            cos.Name = "cos";
            cos.Size = new Size(94, 29);
            cos.TabIndex = 5;
            cos.Text = "cos";
            cos.UseVisualStyleBackColor = true;
            cos.Click += cos_Click;
            // 
            // ctg
            // 
            ctg.Location = new Point(133, 184);
            ctg.Name = "ctg";
            ctg.Size = new Size(94, 29);
            ctg.TabIndex = 6;
            ctg.Text = "ctg";
            ctg.UseVisualStyleBackColor = true;
            ctg.Click += ctg_Click;
            // 
            // square
            // 
            square.Location = new Point(12, 307);
            square.Name = "square";
            square.Size = new Size(94, 29);
            square.TabIndex = 7;
            square.Text = "x^2";
            square.UseVisualStyleBackColor = true;
            square.Click += square_Click;
            // 
            // cube
            // 
            cube.Location = new Point(133, 307);
            cube.Name = "cube";
            cube.Size = new Size(94, 29);
            cube.TabIndex = 8;
            cube.Text = "x^3";
            cube.UseVisualStyleBackColor = true;
            cube.Click += cube_Click;
            // 
            // degree
            // 
            degree.Location = new Point(257, 307);
            degree.Name = "degree";
            degree.Size = new Size(94, 29);
            degree.TabIndex = 9;
            degree.Text = "x^y";
            degree.UseVisualStyleBackColor = true;
            degree.Click += degree_Click;
            // 
            // cleanvalues
            // 
            cleanvalues.Location = new Point(12, 399);
            cleanvalues.Name = "cleanvalues";
            cleanvalues.Size = new Size(94, 29);
            cleanvalues.TabIndex = 10;
            cleanvalues.Text = "clean";
            cleanvalues.UseVisualStyleBackColor = true;
            cleanvalues.Click += cleanvalues_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(105, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 253);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(105, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(289, 253);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(134, 27);
            textBox6.TabIndex = 13;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Save
            // 
            Save.Location = new Point(521, 184);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 15;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Get
            // 
            Get.Location = new Point(657, 184);
            Get.Name = "Get";
            Get.Size = new Size(94, 29);
            Get.TabIndex = 16;
            Get.Text = "Get";
            Get.UseVisualStyleBackColor = true;
            Get.Click += Get_Click;
            // 
            // Heaven
            // 
            Heaven.FormattingEnabled = true;
            Heaven.ItemHeight = 20;
            Heaven.Location = new Point(521, 12);
            Heaven.Name = "Heaven";
            Heaven.Size = new Size(230, 104);
            Heaven.TabIndex = 17;
            // 
            // cleanList
            // 
            cleanList.Location = new Point(657, 253);
            cleanList.Name = "cleanList";
            cleanList.Size = new Size(94, 29);
            cleanList.TabIndex = 18;
            cleanList.Text = "clean list";
            cleanList.UseVisualStyleBackColor = true;
            cleanList.Click += cleanList_Click;
            // 
            // cleanLastElement
            // 
            cleanLastElement.Location = new Point(521, 253);
            cleanLastElement.Name = "cleanLastElement";
            cleanLastElement.Size = new Size(94, 29);
            cleanLastElement.TabIndex = 19;
            cleanLastElement.Text = "clean last ";
            cleanLastElement.UseVisualStyleBackColor = true;
            cleanLastElement.Click += cleanLastElement_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 456);
            Controls.Add(cleanLastElement);
            Controls.Add(cleanList);
            Controls.Add(Heaven);
            Controls.Add(Get);
            Controls.Add(Save);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(cleanvalues);
            Controls.Add(degree);
            Controls.Add(cube);
            Controls.Add(square);
            Controls.Add(ctg);
            Controls.Add(cos);
            Controls.Add(tg);
            Controls.Add(sin);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private Button sin;
        private Button tg;
        private Button cos;
        private Button ctg;
        private Button square;
        private Button cube;
        private Button degree;
        private Button cleanvalues;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ErrorProvider errorProvider1;
        private Button Get;
        private Button Save;
        private ListBox Heaven;
        private Button cleanList;
        private Button cleanLastElement;
    }
}