﻿namespace GroupBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbM2 = new System.Windows.Forms.RadioButton();
            this.rdbM1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbS3 = new System.Windows.Forms.RadioButton();
            this.rdbS2 = new System.Windows.Forms.RadioButton();
            this.rdbS1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbD4 = new System.Windows.Forms.RadioButton();
            this.rdbD3 = new System.Windows.Forms.RadioButton();
            this.rdbD2 = new System.Windows.Forms.RadioButton();
            this.rdbD1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.chkS = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbM2);
            this.groupBox1.Controls.Add(this.rdbM1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主餐";
            // 
            // rdbM2
            // 
            this.rdbM2.AutoSize = true;
            this.rdbM2.Location = new System.Drawing.Point(237, 36);
            this.rdbM2.Name = "rdbM2";
            this.rdbM2.Size = new System.Drawing.Size(182, 21);
            this.rdbM2.TabIndex = 1;
            this.rdbM2.Text = "2號餐：漢堡餐(95元)";
            this.rdbM2.UseVisualStyleBackColor = true;
            this.rdbM2.CheckedChanged += new System.EventHandler(this.rdbM2_CheckedChanged);
            // 
            // rdbM1
            // 
            this.rdbM1.AutoSize = true;
            this.rdbM1.Checked = true;
            this.rdbM1.Location = new System.Drawing.Point(31, 36);
            this.rdbM1.Name = "rdbM1";
            this.rdbM1.Size = new System.Drawing.Size(190, 21);
            this.rdbM1.TabIndex = 0;
            this.rdbM1.TabStop = true;
            this.rdbM1.Text = "1號餐：雞塊餐(115元)";
            this.rdbM1.UseVisualStyleBackColor = true;
            this.rdbM1.CheckedChanged += new System.EventHandler(this.rdbM1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbS3);
            this.groupBox2.Controls.Add(this.rdbS2);
            this.groupBox2.Controls.Add(this.rdbS1);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(24, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "副餐";
            // 
            // rdbS3
            // 
            this.rdbS3.AutoSize = true;
            this.rdbS3.Location = new System.Drawing.Point(286, 37);
            this.rdbS3.Name = "rdbS3";
            this.rdbS3.Size = new System.Drawing.Size(97, 21);
            this.rdbS3.TabIndex = 2;
            this.rdbS3.Text = "生菜沙拉";
            this.rdbS3.UseVisualStyleBackColor = true;
            // 
            // rdbS2
            // 
            this.rdbS2.AutoSize = true;
            this.rdbS2.Location = new System.Drawing.Point(163, 37);
            this.rdbS2.Name = "rdbS2";
            this.rdbS2.Size = new System.Drawing.Size(80, 21);
            this.rdbS2.TabIndex = 1;
            this.rdbS2.Text = "可樂餅";
            this.rdbS2.UseVisualStyleBackColor = true;
            // 
            // rdbS1
            // 
            this.rdbS1.AutoSize = true;
            this.rdbS1.Checked = true;
            this.rdbS1.Location = new System.Drawing.Point(31, 37);
            this.rdbS1.Name = "rdbS1";
            this.rdbS1.Size = new System.Drawing.Size(63, 21);
            this.rdbS1.TabIndex = 0;
            this.rdbS1.TabStop = true;
            this.rdbS1.Text = "薯條";
            this.rdbS1.UseVisualStyleBackColor = true;
            this.rdbS1.CheckedChanged += new System.EventHandler(this.rdbS1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbD4);
            this.groupBox3.Controls.Add(this.rdbD3);
            this.groupBox3.Controls.Add(this.rdbD2);
            this.groupBox3.Controls.Add(this.rdbD1);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(24, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "飲料";
            // 
            // rdbD4
            // 
            this.rdbD4.AutoSize = true;
            this.rdbD4.Location = new System.Drawing.Point(314, 39);
            this.rdbD4.Name = "rdbD4";
            this.rdbD4.Size = new System.Drawing.Size(80, 21);
            this.rdbD4.TabIndex = 3;
            this.rdbD4.Text = "冰咖啡";
            this.rdbD4.UseVisualStyleBackColor = true;
            // 
            // rdbD3
            // 
            this.rdbD3.AutoSize = true;
            this.rdbD3.Location = new System.Drawing.Point(206, 39);
            this.rdbD3.Name = "rdbD3";
            this.rdbD3.Size = new System.Drawing.Size(80, 21);
            this.rdbD3.TabIndex = 2;
            this.rdbD3.Text = "檸檬茶";
            this.rdbD3.UseVisualStyleBackColor = true;
            // 
            // rdbD2
            // 
            this.rdbD2.AutoSize = true;
            this.rdbD2.Location = new System.Drawing.Point(116, 39);
            this.rdbD2.Name = "rdbD2";
            this.rdbD2.Size = new System.Drawing.Size(63, 21);
            this.rdbD2.TabIndex = 1;
            this.rdbD2.Text = "紅茶";
            this.rdbD2.UseVisualStyleBackColor = true;
            // 
            // rdbD1
            // 
            this.rdbD1.AutoSize = true;
            this.rdbD1.Checked = true;
            this.rdbD1.Location = new System.Drawing.Point(31, 39);
            this.rdbD1.Name = "rdbD1";
            this.rdbD1.Size = new System.Drawing.Size(63, 21);
            this.rdbD1.TabIndex = 0;
            this.rdbD1.TabStop = true;
            this.rdbD1.Text = "汽水";
            this.rdbD1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkD);
            this.groupBox4.Controls.Add(this.chkS);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(27, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 69);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "升級";
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(235, 27);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(98, 21);
            this.chkD.TabIndex = 1;
            this.chkD.Text = "飲料加大";
            this.chkD.UseVisualStyleBackColor = true;
            this.chkD.CheckedChanged += new System.EventHandler(this.chkD_CheckedChanged);
            // 
            // chkS
            // 
            this.chkS.AutoSize = true;
            this.chkS.Location = new System.Drawing.Point(57, 27);
            this.chkS.Name = "chkS";
            this.chkS.Size = new System.Drawing.Size(98, 21);
            this.chkS.TabIndex = 0;
            this.chkS.Text = "薯條加大";
            this.chkS.UseVisualStyleBackColor = true;
            this.chkS.CheckedChanged += new System.EventHandler(this.chkS_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "小計";
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSum.Location = new System.Drawing.Point(68, 428);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(74, 29);
            this.txtSum.TabIndex = 5;
            this.txtSum.Text = "115";
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(154, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "* 數量";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(225, 428);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(68, 31);
            this.txtNum.TabIndex = 7;
            this.txtNum.Text = "1";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(301, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "=";
            // 
            // txtAmt
            // 
            this.txtAmt.BackColor = System.Drawing.Color.Black;
            this.txtAmt.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmt.ForeColor = System.Drawing.Color.White;
            this.txtAmt.Location = new System.Drawing.Point(331, 427);
            this.txtAmt.Multiline = true;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.ReadOnly = true;
            this.txtAmt.Size = new System.Drawing.Size(100, 32);
            this.txtAmt.TabIndex = 9;
            this.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(440, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "活力早餐店";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbM2;
        private System.Windows.Forms.RadioButton rdbM1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbS3;
        private System.Windows.Forms.RadioButton rdbS2;
        private System.Windows.Forms.RadioButton rdbS1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbD4;
        private System.Windows.Forms.RadioButton rdbD3;
        private System.Windows.Forms.RadioButton rdbD2;
        private System.Windows.Forms.RadioButton rdbD1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label4;
    }
}

