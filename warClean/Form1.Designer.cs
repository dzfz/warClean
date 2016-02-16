namespace warClean
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.warPath_button = new System.Windows.Forms.Button();
            this.warPath_textBox = new System.Windows.Forms.TextBox();
            this.run_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warPath_button
            // 
            this.warPath_button.Location = new System.Drawing.Point(197, 12);
            this.warPath_button.Name = "warPath_button";
            this.warPath_button.Size = new System.Drawing.Size(75, 23);
            this.warPath_button.TabIndex = 0;
            this.warPath_button.Text = "war包路径";
            this.warPath_button.UseVisualStyleBackColor = true;
            this.warPath_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // warPath_textBox
            // 
            this.warPath_textBox.Location = new System.Drawing.Point(12, 12);
            this.warPath_textBox.Name = "warPath_textBox";
            this.warPath_textBox.Size = new System.Drawing.Size(168, 21);
            this.warPath_textBox.TabIndex = 1;
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(100, 49);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(75, 23);
            this.run_button.TabIndex = 2;
            this.run_button.Text = "清理";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.warPath_textBox);
            this.Controls.Add(this.warPath_button);
            this.Name = "MainForm";
            this.Text = "war包清理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button warPath_button;
        private System.Windows.Forms.TextBox warPath_textBox;
        private System.Windows.Forms.Button run_button;

    }
}

