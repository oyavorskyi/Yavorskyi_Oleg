namespace WindowsFormsApp1
{
    partial class Form1
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
            this.OutputBox = new System.Windows.Forms.GroupBox();
            this.textOutBox = new System.Windows.Forms.TextBox();
            this.NextExpresion = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.textInBox = new System.Windows.Forms.TextBox();
            this.ChangeValue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndTranslate = new System.Windows.Forms.Button();
            this.StartTranslate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OutputBox.SuspendLayout();
            this.InputBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Controls.Add(this.textOutBox);
            this.OutputBox.Controls.Add(this.NextExpresion);
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputBox.Location = new System.Drawing.Point(12, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(517, 487);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.TabStop = false;
            this.OutputBox.Text = "Оригінал";
            // 
            // textOutBox
            // 
            this.textOutBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOutBox.Location = new System.Drawing.Point(7, 22);
            this.textOutBox.Multiline = true;
            this.textOutBox.Name = "textOutBox";
            this.textOutBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textOutBox.Size = new System.Drawing.Size(504, 421);
            this.textOutBox.TabIndex = 2;
            // 
            // NextExpresion
            // 
            this.NextExpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextExpresion.Location = new System.Drawing.Point(214, 449);
            this.NextExpresion.Name = "NextExpresion";
            this.NextExpresion.Size = new System.Drawing.Size(75, 32);
            this.NextExpresion.TabIndex = 1;
            this.NextExpresion.Text = "Далі";
            this.NextExpresion.UseVisualStyleBackColor = true;
            this.NextExpresion.Click += new System.EventHandler(this.NextExpresion_Click);
            // 
            // InputBox
            // 
            this.InputBox.Controls.Add(this.textInBox);
            this.InputBox.Controls.Add(this.ChangeValue);
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBox.Location = new System.Drawing.Point(535, 12);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(505, 487);
            this.InputBox.TabIndex = 1;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "Переклад";
            // 
            // textInBox
            // 
            this.textInBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textInBox.Location = new System.Drawing.Point(6, 22);
            this.textInBox.Multiline = true;
            this.textInBox.Name = "textInBox";
            this.textInBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textInBox.Size = new System.Drawing.Size(493, 421);
            this.textInBox.TabIndex = 3;
            // 
            // ChangeValue
            // 
            this.ChangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeValue.Location = new System.Drawing.Point(217, 449);
            this.ChangeValue.Name = "ChangeValue";
            this.ChangeValue.Size = new System.Drawing.Size(98, 32);
            this.ChangeValue.TabIndex = 1;
            this.ChangeValue.Text = "Замінити";
            this.ChangeValue.UseVisualStyleBackColor = true;
            this.ChangeValue.Click += new System.EventHandler(this.ChangeValue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EndTranslate);
            this.groupBox1.Controls.Add(this.StartTranslate);
            this.groupBox1.Location = new System.Drawing.Point(12, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // EndTranslate
            // 
            this.EndTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndTranslate.Location = new System.Drawing.Point(740, 33);
            this.EndTranslate.Name = "EndTranslate";
            this.EndTranslate.Size = new System.Drawing.Size(109, 38);
            this.EndTranslate.TabIndex = 1;
            this.EndTranslate.Text = "Зберегти";
            this.EndTranslate.UseVisualStyleBackColor = true;
            this.EndTranslate.Click += new System.EventHandler(this.EndTranslate_Click);
            // 
            // StartTranslate
            // 
            this.StartTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTranslate.Location = new System.Drawing.Point(199, 33);
            this.StartTranslate.Name = "StartTranslate";
            this.StartTranslate.Size = new System.Drawing.Size(114, 38);
            this.StartTranslate.TabIndex = 0;
            this.StartTranslate.Text = "Розпочати";
            this.StartTranslate.UseVisualStyleBackColor = true;
            this.StartTranslate.Click += new System.EventHandler(this.StartTranslate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(1046, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 593);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cписок ключів";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 562);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.OutputBox);
            this.Name = "Form1";
            this.Text = "VS Translator Tool";
            this.OutputBox.ResumeLayout(false);
            this.OutputBox.PerformLayout();
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OutputBox;
        private System.Windows.Forms.TextBox textOutBox;
        private System.Windows.Forms.Button NextExpresion;
        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.TextBox textInBox;
        private System.Windows.Forms.Button ChangeValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EndTranslate;
        private System.Windows.Forms.Button StartTranslate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

