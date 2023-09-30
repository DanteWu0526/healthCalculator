namespace practise01
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SureButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ShowTextBox = new System.Windows.Forms.TextBox();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClassComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.WeightTextBox);
            this.groupBox1.Controls.Add(this.HeightTextBox);
            this.groupBox1.Controls.Add(this.GenderComboBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.SureButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IdLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入資料";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "學號:";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IdLabel.Location = new System.Drawing.Point(55, 35);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(15, 16);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "性別:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "身高:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "體重:";
            // 
            // SureButton
            // 
            this.SureButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SureButton.Location = new System.Drawing.Point(9, 304);
            this.SureButton.Name = "SureButton";
            this.SureButton.Size = new System.Drawing.Size(54, 30);
            this.SureButton.TabIndex = 7;
            this.SureButton.Text = "確定";
            this.SureButton.UseVisualStyleBackColor = true;
            this.SureButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CancelButton.Location = new System.Drawing.Point(97, 304);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(54, 30);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTextBox.Location = new System.Drawing.Point(58, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(87, 27);
            this.NameTextBox.TabIndex = 9;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "男性",
            "女性"});
            this.GenderComboBox.Location = new System.Drawing.Point(55, 113);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(90, 24);
            this.GenderComboBox.TabIndex = 10;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightTextBox.Location = new System.Drawing.Point(58, 209);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(87, 27);
            this.HeightTextBox.TabIndex = 11;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WeightTextBox.Location = new System.Drawing.Point(58, 257);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(87, 27);
            this.WeightTextBox.TabIndex = 12;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComputeButton.Location = new System.Drawing.Point(199, 12);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(54, 30);
            this.ComputeButton.TabIndex = 14;
            this.ComputeButton.Text = "計算";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShowTextBox
            // 
            this.ShowTextBox.Location = new System.Drawing.Point(199, 48);
            this.ShowTextBox.Multiline = true;
            this.ShowTextBox.Name = "ShowTextBox";
            this.ShowTextBox.Size = new System.Drawing.Size(471, 343);
            this.ShowTextBox.TabIndex = 15;
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Items.AddRange(new object[] {
            "A班",
            "B班",
            "C班"});
            this.ClassComboBox.Location = new System.Drawing.Point(58, 160);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(90, 24);
            this.ClassComboBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(9, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "班級:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowTextBox);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SureButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.TextBox ShowTextBox;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label label7;
    }
}

