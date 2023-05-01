namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImgOpen = new System.Windows.Forms.Button();
            this.btnSendC = new System.Windows.Forms.Button();
            this.picResponse = new System.Windows.Forms.PictureBox();
            this.picOrigin = new System.Windows.Forms.PictureBox();
            this.labPicRes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSendA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtResA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Message";
            // 
            // btnSendA
            // 
            this.btnSendA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSendA.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnSendA.Location = new System.Drawing.Point(351, 122);
            this.btnSendA.Name = "btnSendA";
            this.btnSendA.Size = new System.Drawing.Size(74, 20);
            this.btnSendA.TabIndex = 4;
            this.btnSendA.Text = "Send";
            this.btnSendA.UseVisualStyleBackColor = false;
            this.btnSendA.Click += new System.EventHandler(this.BtnSendA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Response";
            // 
            // txtResA
            // 
            this.txtResA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResA.Location = new System.Drawing.Point(224, 39);
            this.txtResA.Multiline = true;
            this.txtResA.Name = "txtResA";
            this.txtResA.ReadOnly = true;
            this.txtResA.Size = new System.Drawing.Size(201, 58);
            this.txtResA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Content";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxA.Location = new System.Drawing.Point(21, 39);
            this.txtBoxA.Multiline = true;
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(196, 58);
            this.txtBoxA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSendB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtResB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxB);
            this.groupBox2.Location = new System.Drawing.Point(13, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 148);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number Array Message";
            // 
            // btnSendB
            // 
            this.btnSendB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendB.Location = new System.Drawing.Point(350, 119);
            this.btnSendB.Name = "btnSendB";
            this.btnSendB.Size = new System.Drawing.Size(75, 23);
            this.btnSendB.TabIndex = 4;
            this.btnSendB.Text = "Send";
            this.btnSendB.UseVisualStyleBackColor = true;
            this.btnSendB.Click += new System.EventHandler(this.BtnSendB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Response";
            // 
            // txtResB
            // 
            this.txtResB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResB.Location = new System.Drawing.Point(224, 39);
            this.txtResB.Multiline = true;
            this.txtResB.Name = "txtResB";
            this.txtResB.ReadOnly = true;
            this.txtResB.Size = new System.Drawing.Size(201, 58);
            this.txtResB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Content";
            // 
            // txtBoxB
            // 
            this.txtBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxB.Location = new System.Drawing.Point(21, 39);
            this.txtBoxB.Multiline = true;
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(196, 58);
            this.txtBoxB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnImgOpen);
            this.groupBox3.Controls.Add(this.btnSendC);
            this.groupBox3.Controls.Add(this.picResponse);
            this.groupBox3.Controls.Add(this.picOrigin);
            this.groupBox3.Controls.Add(this.labPicRes);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(13, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 178);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Message";
            // 
            // btnImgOpen
            // 
            this.btnImgOpen.Location = new System.Drawing.Point(69, 17);
            this.btnImgOpen.Name = "btnImgOpen";
            this.btnImgOpen.Size = new System.Drawing.Size(28, 19);
            this.btnImgOpen.TabIndex = 7;
            this.btnImgOpen.Text = "...";
            this.btnImgOpen.UseVisualStyleBackColor = true;
            this.btnImgOpen.Click += new System.EventHandler(this.BtnImgOpen_Click);
            // 
            // btnSendC
            // 
            this.btnSendC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendC.Location = new System.Drawing.Point(350, 149);
            this.btnSendC.Name = "btnSendC";
            this.btnSendC.Size = new System.Drawing.Size(75, 23);
            this.btnSendC.TabIndex = 5;
            this.btnSendC.Text = "Send";
            this.btnSendC.UseVisualStyleBackColor = true;
            this.btnSendC.Click += new System.EventHandler(this.BtnSendC_Click);
            // 
            // picResponse
            // 
            this.picResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResponse.Location = new System.Drawing.Point(224, 39);
            this.picResponse.Name = "picResponse";
            this.picResponse.Size = new System.Drawing.Size(193, 103);
            this.picResponse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResponse.TabIndex = 6;
            this.picResponse.TabStop = false;
            // 
            // picOrigin
            // 
            this.picOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOrigin.Location = new System.Drawing.Point(23, 39);
            this.picOrigin.Name = "picOrigin";
            this.picOrigin.Size = new System.Drawing.Size(193, 103);
            this.picOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrigin.TabIndex = 5;
            this.picOrigin.TabStop = false;
            // 
            // labPicRes
            // 
            this.labPicRes.AutoSize = true;
            this.labPicRes.Location = new System.Drawing.Point(221, 20);
            this.labPicRes.Name = "labPicRes";
            this.labPicRes.Size = new System.Drawing.Size(55, 13);
            this.labPicRes.TabIndex = 3;
            this.labPicRes.Text = "Response";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Content";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labPicRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendC;
        private System.Windows.Forms.PictureBox picResponse;
        private System.Windows.Forms.PictureBox picOrigin;
        private System.Windows.Forms.Button btnImgOpen;
    }
}

