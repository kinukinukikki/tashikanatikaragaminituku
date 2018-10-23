namespace _01_HelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.helloButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(114, 176);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(112, 43);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "click!!!";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.HelloButtonClicked);
            // 
            // helloLabel
            // 
            this.helloLabel.Location = new System.Drawing.Point(112, 85);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(114, 23);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "??????";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 291);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Label helloLabel;
    }
}

