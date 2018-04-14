namespace CoursProject
{
    partial class Main
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
            this.level1 = new System.Windows.Forms.TableLayoutPanel();
            this.input = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.level1.SuspendLayout();
            this.SuspendLayout();
            // 
            // level1
            // 
            this.level1.ColumnCount = 1;
            this.level1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.level1.Controls.Add(this.input, 0, 1);
            this.level1.Controls.Add(this.generate, 0, 2);
            this.level1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.level1.Location = new System.Drawing.Point(0, 0);
            this.level1.Name = "level1";
            this.level1.RowCount = 4;
            this.level1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.level1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.level1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.level1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.level1.Size = new System.Drawing.Size(284, 265);
            this.level1.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(3, 109);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(122, 23);
            this.input.TabIndex = 0;
            this.input.Text = "Ввести дані";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(3, 162);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(122, 23);
            this.generate.TabIndex = 1;
            this.generate.Text = "Генерувати дані";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.level1);
            this.Name = "Main";
            this.Text = "Головна";
            this.level1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel level1;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button generate;
    }
}

