namespace _05_CountPrise
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
            this.ToNorth = new System.Windows.Forms.RadioButton();
            this.ToSouth = new System.Windows.Forms.RadioButton();
            this.ReturnTicket = new System.Windows.Forms.CheckBox();
            this.DiscountTicket = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CountTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToNorth
            // 
            this.ToNorth.AutoSize = true;
            this.ToNorth.Location = new System.Drawing.Point(70, 65);
            this.ToNorth.Name = "ToNorth";
            this.ToNorth.Size = new System.Drawing.Size(69, 22);
            this.ToNorth.TabIndex = 0;
            this.ToNorth.TabStop = true;
            this.ToNorth.Text = "北上";
            this.ToNorth.UseVisualStyleBackColor = true;
            // 
            // ToSouth
            // 
            this.ToSouth.AutoSize = true;
            this.ToSouth.Location = new System.Drawing.Point(221, 65);
            this.ToSouth.Name = "ToSouth";
            this.ToSouth.Size = new System.Drawing.Size(69, 22);
            this.ToSouth.TabIndex = 1;
            this.ToSouth.TabStop = true;
            this.ToSouth.Text = "南下";
            this.ToSouth.UseVisualStyleBackColor = true;
            // 
            // ReturnTicket
            // 
            this.ReturnTicket.AutoSize = true;
            this.ReturnTicket.Location = new System.Drawing.Point(70, 280);
            this.ReturnTicket.Name = "ReturnTicket";
            this.ReturnTicket.Size = new System.Drawing.Size(88, 22);
            this.ReturnTicket.TabIndex = 2;
            this.ReturnTicket.Text = "來回票";
            this.ReturnTicket.UseVisualStyleBackColor = true;
            // 
            // DiscountTicket
            // 
            this.DiscountTicket.AutoSize = true;
            this.DiscountTicket.Location = new System.Drawing.Point(70, 340);
            this.DiscountTicket.Name = "DiscountTicket";
            this.DiscountTicket.Size = new System.Drawing.Size(88, 22);
            this.DiscountTicket.TabIndex = 3;
            this.DiscountTicket.Text = "優惠票";
            this.DiscountTicket.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(337, 174);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 26);
            this.comboBox2.TabIndex = 5;
            // 
            // CountTotal
            // 
            this.CountTotal.Location = new System.Drawing.Point(472, 238);
            this.CountTotal.Name = "CountTotal";
            this.CountTotal.Size = new System.Drawing.Size(145, 78);
            this.CountTotal.TabIndex = 6;
            this.CountTotal.Text = "計算票價";
            this.CountTotal.UseVisualStyleBackColor = true;
            this.CountTotal.Click += new System.EventHandler(this.CountTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "票價為:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "起站";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "迄站";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountTotal);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DiscountTicket);
            this.Controls.Add(this.ReturnTicket);
            this.Controls.Add(this.ToSouth);
            this.Controls.Add(this.ToNorth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ToNorth;
        private System.Windows.Forms.RadioButton ToSouth;
        private System.Windows.Forms.CheckBox ReturnTicket;
        private System.Windows.Forms.CheckBox DiscountTicket;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button CountTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

