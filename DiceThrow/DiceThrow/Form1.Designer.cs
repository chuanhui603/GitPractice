namespace ThrowDice
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDice1 = new System.Windows.Forms.TextBox();
            this.txtDice2 = new System.Windows.Forms.TextBox();
            this.txtDice3 = new System.Windows.Forms.TextBox();
            this.txtDice4 = new System.Windows.Forms.TextBox();
            this.lblsame = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDice1
            // 
            this.txtDice1.Location = new System.Drawing.Point(181, 99);
            this.txtDice1.Multiline = true;
            this.txtDice1.Name = "txtDice1";
            this.txtDice1.ReadOnly = true;
            this.txtDice1.Size = new System.Drawing.Size(33, 35);
            this.txtDice1.TabIndex = 0;
            // 
            // txtDice2
            // 
            this.txtDice2.Location = new System.Drawing.Point(314, 99);
            this.txtDice2.Multiline = true;
            this.txtDice2.Name = "txtDice2";
            this.txtDice2.ReadOnly = true;
            this.txtDice2.Size = new System.Drawing.Size(33, 35);
            this.txtDice2.TabIndex = 1;
            // 
            // txtDice3
            // 
            this.txtDice3.Location = new System.Drawing.Point(443, 99);
            this.txtDice3.Multiline = true;
            this.txtDice3.Name = "txtDice3";
            this.txtDice3.ReadOnly = true;
            this.txtDice3.Size = new System.Drawing.Size(33, 35);
            this.txtDice3.TabIndex = 2;
            // 
            // txtDice4
            // 
            this.txtDice4.Location = new System.Drawing.Point(542, 99);
            this.txtDice4.Multiline = true;
            this.txtDice4.Name = "txtDice4";
            this.txtDice4.ReadOnly = true;
            this.txtDice4.Size = new System.Drawing.Size(33, 35);
            this.txtDice4.TabIndex = 3;
            // 
            // lblsame
            // 
            this.lblsame.AutoSize = true;
            this.lblsame.Location = new System.Drawing.Point(276, 224);
            this.lblsame.Name = "lblsame";
            this.lblsame.Size = new System.Drawing.Size(53, 12);
            this.lblsame.TabIndex = 4;
            this.lblsame.Text = "相同數字";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(485, 224);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(29, 12);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "總和";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "開始玩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblsame);
            this.Controls.Add(this.txtDice4);
            this.Controls.Add(this.txtDice3);
            this.Controls.Add(this.txtDice2);
            this.Controls.Add(this.txtDice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDice1;
        private System.Windows.Forms.TextBox txtDice2;
        private System.Windows.Forms.TextBox txtDice3;
        private System.Windows.Forms.TextBox txtDice4;
        private System.Windows.Forms.Label lblsame;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button button1;
    }
}

