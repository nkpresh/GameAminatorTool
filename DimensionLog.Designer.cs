namespace GamerTool
{
    partial class dimensionLog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DimensionX = new System.Windows.Forms.NumericUpDown();
            this.DimensionY = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 81);
            this.panel1.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.Location = new System.Drawing.Point(85, 23);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(246, 37);
            this.Select.TabIndex = 0;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // DimensionX
            // 
            this.DimensionX.Location = new System.Drawing.Point(73, 29);
            this.DimensionX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DimensionX.Name = "DimensionX";
            this.DimensionX.Size = new System.Drawing.Size(124, 20);
            this.DimensionX.TabIndex = 2;
            this.DimensionX.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // DimensionY
            // 
            this.DimensionY.Location = new System.Drawing.Point(258, 29);
            this.DimensionY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DimensionY.Name = "DimensionY";
            this.DimensionY.Size = new System.Drawing.Size(122, 20);
            this.DimensionY.TabIndex = 3;
            this.DimensionY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dimensionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 184);
            this.Controls.Add(this.DimensionY);
            this.Controls.Add(this.DimensionX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dimensionLog";
            this.Text = "DimensionLog";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DimensionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DimensionX;
        private System.Windows.Forms.NumericUpDown DimensionY;
    }
}