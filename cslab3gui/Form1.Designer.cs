namespace cslab3gui
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.save = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.RichTextBox();
            this.Show = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NumElement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 222);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 94);
            this.save.TabIndex = 1;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(351, 96);
            this.display.TabIndex = 2;
            this.display.Text = "D= 3BA + (B - A)";
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(140, 222);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(221, 94);
            this.Show.TabIndex = 3;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NumElement
            // 
            this.NumElement.Location = new System.Drawing.Point(12, 162);
            this.NumElement.Name = "NumElement";
            this.NumElement.Size = new System.Drawing.Size(349, 17);
            this.NumElement.TabIndex = 6;
            this.NumElement.Text = "Number of Element";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 457);
            this.Controls.Add(this.NumElement);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.display);
            this.Controls.Add(this.save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NumElement;
    }
}

