namespace PhoneBook
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
            this.nameList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telephoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.ItemHeight = 12;
            this.nameList.Location = new System.Drawing.Point(24, 67);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(213, 172);
            this.nameList.TabIndex = 0;
            this.nameList.SelectedIndexChanged += new System.EventHandler(this.NameSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "names";
            // 
            // telephoneNumber
            // 
            this.telephoneNumber.Enabled = false;
            this.telephoneNumber.Location = new System.Drawing.Point(282, 67);
            this.telephoneNumber.Name = "telephoneNumber";
            this.telephoneNumber.Size = new System.Drawing.Size(205, 19);
            this.telephoneNumber.TabIndex = 2;
            this.telephoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "telephone number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telephoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telephoneNumber;
        private System.Windows.Forms.Label label2;
    }
}

