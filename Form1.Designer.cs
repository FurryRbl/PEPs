namespace PEPs
{
    partial class PEPs
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.启动 = new System.Windows.Forms.Button();
            this.工具箱 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 启动
            // 
            this.启动.Location = new System.Drawing.Point(150, 150);
            this.启动.Name = "启动";
            this.启动.Size = new System.Drawing.Size(100, 80);
            this.启动.TabIndex = 0;
            this.启动.Text = "启动";
            this.启动.UseVisualStyleBackColor = true;
            this.启动.Click += new System.EventHandler(this.启动_Click);
            // 
            // 工具箱
            // 
            this.工具箱.Location = new System.Drawing.Point(500, 150);
            this.工具箱.Name = "工具箱";
            this.工具箱.Size = new System.Drawing.Size(100, 80);
            this.工具箱.TabIndex = 1;
            this.工具箱.Text = "工具箱";
            this.工具箱.UseVisualStyleBackColor = true;
            // 
            // PEPs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.工具箱);
            this.Controls.Add(this.启动);
            this.Name = "PEPs";
            this.Text = "PEPs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 启动;
        private System.Windows.Forms.Button 工具箱;
    }
}

