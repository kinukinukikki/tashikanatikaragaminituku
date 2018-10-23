namespace TexCalc
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
            this.priceBox = new System.Windows.Forms.TextBox();
            this.TaxPriceBox = new System.Windows.Forms.TextBox();
            this.calcBotton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(233, 49);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(306, 19);
            this.priceBox.TabIndex = 0;
            // 
            // TaxPriceBox
            // 
            this.TaxPriceBox.Enabled = false;
            this.TaxPriceBox.Location = new System.Drawing.Point(233, 100);
            this.TaxPriceBox.Name = "TaxPriceBox";
            this.TaxPriceBox.Size = new System.Drawing.Size(306, 19);
            this.TaxPriceBox.TabIndex = 1;
            // 
            // calcBotton
            // 
            this.calcBotton.Location = new System.Drawing.Point(441, 145);
            this.calcBotton.Name = "calcBotton";
            this.calcBotton.Size = new System.Drawing.Size(98, 45);
            this.calcBotton.TabIndex = 2;
            this.calcBotton.Text = "Calcurate";
            this.calcBotton.UseVisualStyleBackColor = true;
            this.calcBotton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "tax price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcBotton);
            this.Controls.Add(this.TaxPriceBox);
            this.Controls.Add(this.priceBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox TaxPriceBox;
        private System.Windows.Forms.Button calcBotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

