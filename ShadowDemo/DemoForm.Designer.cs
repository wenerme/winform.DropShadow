namespace ShadowDemo
{
	partial class DemoForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnShadowHIn = new System.Windows.Forms.Button();
			this.btnShadowHDe = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBlurIn = new System.Windows.Forms.Button();
			this.btnBlurDe = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSpreadIn = new System.Windows.Forms.Button();
			this.btnSpreadDe = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRandomColor = new System.Windows.Forms.Button();
			this.btnToggleRegion = new System.Windows.Forms.Button();
			this.comboBoxStep = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.vShadowV = new System.Windows.Forms.Label();
			this.vShadowH = new System.Windows.Forms.Label();
			this.vBlur = new System.Windows.Forms.Label();
			this.vSpread = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.DimGray;
			this.button1.Location = new System.Drawing.Point(139, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = ">";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "ShadowV";
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.DimGray;
			this.button2.Location = new System.Drawing.Point(77, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "<";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnShadowHIn
			// 
			this.btnShadowHIn.ForeColor = System.Drawing.Color.DimGray;
			this.btnShadowHIn.Location = new System.Drawing.Point(139, 55);
			this.btnShadowHIn.Name = "btnShadowHIn";
			this.btnShadowHIn.Size = new System.Drawing.Size(60, 23);
			this.btnShadowHIn.TabIndex = 0;
			this.btnShadowHIn.Text = ">";
			this.btnShadowHIn.UseVisualStyleBackColor = true;
			this.btnShadowHIn.Click += new System.EventHandler(this.btnShadowHIn_Click);
			// 
			// btnShadowHDe
			// 
			this.btnShadowHDe.ForeColor = System.Drawing.Color.DimGray;
			this.btnShadowHDe.Location = new System.Drawing.Point(77, 55);
			this.btnShadowHDe.Name = "btnShadowHDe";
			this.btnShadowHDe.Size = new System.Drawing.Size(56, 23);
			this.btnShadowHDe.TabIndex = 0;
			this.btnShadowHDe.Text = "<";
			this.btnShadowHDe.UseVisualStyleBackColor = true;
			this.btnShadowHDe.Click += new System.EventHandler(this.btnShadowHDe_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "ShadowH";
			// 
			// btnBlurIn
			// 
			this.btnBlurIn.ForeColor = System.Drawing.Color.DimGray;
			this.btnBlurIn.Location = new System.Drawing.Point(139, 97);
			this.btnBlurIn.Name = "btnBlurIn";
			this.btnBlurIn.Size = new System.Drawing.Size(60, 23);
			this.btnBlurIn.TabIndex = 0;
			this.btnBlurIn.Text = ">";
			this.btnBlurIn.UseVisualStyleBackColor = true;
			this.btnBlurIn.Click += new System.EventHandler(this.btnBlurIn_Click);
			// 
			// btnBlurDe
			// 
			this.btnBlurDe.ForeColor = System.Drawing.Color.DimGray;
			this.btnBlurDe.Location = new System.Drawing.Point(77, 97);
			this.btnBlurDe.Name = "btnBlurDe";
			this.btnBlurDe.Size = new System.Drawing.Size(56, 23);
			this.btnBlurDe.TabIndex = 0;
			this.btnBlurDe.Text = "<";
			this.btnBlurDe.UseVisualStyleBackColor = true;
			this.btnBlurDe.Click += new System.EventHandler(this.btnBlurDe_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(12, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "Blur";
			// 
			// btnSpreadIn
			// 
			this.btnSpreadIn.ForeColor = System.Drawing.Color.DimGray;
			this.btnSpreadIn.Location = new System.Drawing.Point(139, 143);
			this.btnSpreadIn.Name = "btnSpreadIn";
			this.btnSpreadIn.Size = new System.Drawing.Size(60, 23);
			this.btnSpreadIn.TabIndex = 0;
			this.btnSpreadIn.Text = ">";
			this.btnSpreadIn.UseVisualStyleBackColor = true;
			this.btnSpreadIn.Click += new System.EventHandler(this.btnSpreadIn_Click);
			// 
			// btnSpreadDe
			// 
			this.btnSpreadDe.ForeColor = System.Drawing.Color.DimGray;
			this.btnSpreadDe.Location = new System.Drawing.Point(77, 143);
			this.btnSpreadDe.Name = "btnSpreadDe";
			this.btnSpreadDe.Size = new System.Drawing.Size(56, 23);
			this.btnSpreadDe.TabIndex = 0;
			this.btnSpreadDe.Text = "<";
			this.btnSpreadDe.UseVisualStyleBackColor = true;
			this.btnSpreadDe.Click += new System.EventHandler(this.btnSpreadDe_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(12, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "Spread";
			// 
			// btnRandomColor
			// 
			this.btnRandomColor.ForeColor = System.Drawing.Color.Black;
			this.btnRandomColor.Location = new System.Drawing.Point(14, 186);
			this.btnRandomColor.Name = "btnRandomColor";
			this.btnRandomColor.Size = new System.Drawing.Size(131, 23);
			this.btnRandomColor.TabIndex = 0;
			this.btnRandomColor.Text = "Random Color";
			this.btnRandomColor.UseVisualStyleBackColor = true;
			this.btnRandomColor.Click += new System.EventHandler(this.btnRandomColor_Click);
			// 
			// btnToggleRegion
			// 
			this.btnToggleRegion.ForeColor = System.Drawing.Color.Black;
			this.btnToggleRegion.Location = new System.Drawing.Point(14, 215);
			this.btnToggleRegion.Name = "btnToggleRegion";
			this.btnToggleRegion.Size = new System.Drawing.Size(131, 23);
			this.btnToggleRegion.TabIndex = 0;
			this.btnToggleRegion.Text = "Toggle Region";
			this.btnToggleRegion.UseVisualStyleBackColor = true;
			this.btnToggleRegion.Click += new System.EventHandler(this.btnToggleRegion_Click);
			// 
			// comboBoxStep
			// 
			this.comboBoxStep.FormattingEnabled = true;
			this.comboBoxStep.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
			this.comboBoxStep.Location = new System.Drawing.Point(197, 189);
			this.comboBoxStep.Name = "comboBoxStep";
			this.comboBoxStep.Size = new System.Drawing.Size(64, 20);
			this.comboBoxStep.TabIndex = 2;
			this.comboBoxStep.Text = "10";
			this.comboBoxStep.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(162, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 1;
			this.label5.Text = "Step";
			// 
			// vShadowV
			// 
			this.vShadowV.AutoSize = true;
			this.vShadowV.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.vShadowV.Location = new System.Drawing.Point(220, 17);
			this.vShadowV.Name = "vShadowV";
			this.vShadowV.Size = new System.Drawing.Size(41, 12);
			this.vShadowV.TabIndex = 3;
			this.vShadowV.Text = "label6";
			// 
			// vShadowH
			// 
			this.vShadowH.AutoSize = true;
			this.vShadowH.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.vShadowH.Location = new System.Drawing.Point(220, 60);
			this.vShadowH.Name = "vShadowH";
			this.vShadowH.Size = new System.Drawing.Size(41, 12);
			this.vShadowH.TabIndex = 3;
			this.vShadowH.Text = "label6";
			// 
			// vBlur
			// 
			this.vBlur.AutoSize = true;
			this.vBlur.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.vBlur.Location = new System.Drawing.Point(220, 102);
			this.vBlur.Name = "vBlur";
			this.vBlur.Size = new System.Drawing.Size(41, 12);
			this.vBlur.TabIndex = 3;
			this.vBlur.Text = "label6";
			// 
			// vSpread
			// 
			this.vSpread.AutoSize = true;
			this.vSpread.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.vSpread.Location = new System.Drawing.Point(220, 148);
			this.vSpread.Name = "vSpread";
			this.vSpread.Size = new System.Drawing.Size(41, 12);
			this.vSpread.TabIndex = 3;
			this.vSpread.Text = "label6";
			// 
			// DemoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.vSpread);
			this.Controls.Add(this.vBlur);
			this.Controls.Add(this.vShadowH);
			this.Controls.Add(this.vShadowV);
			this.Controls.Add(this.comboBoxStep);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnToggleRegion);
			this.Controls.Add(this.btnRandomColor);
			this.Controls.Add(this.btnSpreadDe);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBlurDe);
			this.Controls.Add(this.btnSpreadIn);
			this.Controls.Add(this.btnShadowHDe);
			this.Controls.Add(this.btnBlurIn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnShadowHIn);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "DemoForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.DemoForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnShadowHIn;
		private System.Windows.Forms.Button btnShadowHDe;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBlurIn;
		private System.Windows.Forms.Button btnBlurDe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSpreadIn;
		private System.Windows.Forms.Button btnSpreadDe;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnRandomColor;
		private System.Windows.Forms.Button btnToggleRegion;
		private System.Windows.Forms.ComboBox comboBoxStep;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label vShadowV;
		private System.Windows.Forms.Label vShadowH;
		private System.Windows.Forms.Label vBlur;
		private System.Windows.Forms.Label vSpread;
	}
}

