namespace CoursProject
{
    partial class Input
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hLable = new System.Windows.Forms.Label();
            this.rLable = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.PancakesCollaction = new System.Windows.Forms.DataGridView();
            this.HeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadiusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.go = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PancakesCollaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInput)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.add, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PancakesCollaction, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mInput, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 473);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.hLable, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rLable, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radius, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.height, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // hLable
            // 
            this.hLable.AutoSize = true;
            this.hLable.Location = new System.Drawing.Point(3, 0);
            this.hLable.Name = "hLable";
            this.hLable.Size = new System.Drawing.Size(46, 13);
            this.hLable.TabIndex = 0;
            this.hLable.Text = "Висота:";
            // 
            // rLable
            // 
            this.rLable.AutoSize = true;
            this.rLable.Location = new System.Drawing.Point(142, 0);
            this.rLable.Name = "rLable";
            this.rLable.Size = new System.Drawing.Size(42, 13);
            this.rLable.TabIndex = 1;
            this.rLable.Text = "Радіус:";
            // 
            // radius
            // 
            this.radius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radius.Location = new System.Drawing.Point(142, 30);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(133, 20);
            this.radius.TabIndex = 2;
            this.radius.Leave += new System.EventHandler(this.radius_Leave);
            // 
            // height
            // 
            this.height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.height.Location = new System.Drawing.Point(3, 30);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(133, 20);
            this.height.TabIndex = 3;
            this.height.Leave += new System.EventHandler(this.height_Leave);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 63);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Додати";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // PancakesCollaction
            // 
            this.PancakesCollaction.AllowUserToAddRows = false;
            this.PancakesCollaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PancakesCollaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeightColumn,
            this.RadiusColumn});
            this.PancakesCollaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PancakesCollaction.Location = new System.Drawing.Point(3, 93);
            this.PancakesCollaction.Name = "PancakesCollaction";
            this.PancakesCollaction.Size = new System.Drawing.Size(278, 282);
            this.PancakesCollaction.TabIndex = 2;
            this.PancakesCollaction.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.PancakesCollaction_CellValidating);
            this.PancakesCollaction.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PancakesCollaction_RowsAdded);
            this.PancakesCollaction.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.PancakesCollaction_RowsRemoved);
            // 
            // HeightColumn
            // 
            this.HeightColumn.HeaderText = "Висота";
            this.HeightColumn.Name = "HeightColumn";
            // 
            // RadiusColumn
            // 
            this.RadiusColumn.HeaderText = "Радіус";
            this.RadiusColumn.Name = "RadiusColumn";
            // 
            // mInput
            // 
            this.mInput.Location = new System.Drawing.Point(3, 411);
            this.mInput.Name = "mInput";
            this.mInput.Size = new System.Drawing.Size(120, 20);
            this.mInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кількість млинців, що потрібно взяти:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.go, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.reset, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 441);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 29);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(3, 3);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(90, 23);
            this.go.TabIndex = 4;
            this.go.Text = "Розрахувати";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(142, 3);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(94, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "Скинути";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Input";
            this.Text = "Введення даних";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PancakesCollaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInput)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label hLable;
        private System.Windows.Forms.Label rLable;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView PancakesCollaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadiusColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button reset;
    }
}