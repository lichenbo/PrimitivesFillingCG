namespace PrimitivesFillingCG
{
    partial class CanvasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioScan = new System.Windows.Forms.RadioButton();
            this.radioRecursive = new System.Windows.Forms.RadioButton();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.txtIntersection = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm";
            // 
            // radioScan
            // 
            this.radioScan.AutoSize = true;
            this.radioScan.Checked = true;
            this.radioScan.Location = new System.Drawing.Point(165, 32);
            this.radioScan.Name = "radioScan";
            this.radioScan.Size = new System.Drawing.Size(71, 16);
            this.radioScan.TabIndex = 1;
            this.radioScan.TabStop = true;
            this.radioScan.Text = "扫描填充";
            this.radioScan.UseVisualStyleBackColor = true;
            // 
            // radioRecursive
            // 
            this.radioRecursive.AutoSize = true;
            this.radioRecursive.Location = new System.Drawing.Point(294, 32);
            this.radioRecursive.Name = "radioRecursive";
            this.radioRecursive.Size = new System.Drawing.Size(155, 16);
            this.radioRecursive.TabIndex = 2;
            this.radioRecursive.Text = "区域填充(中心为种子点)";
            this.radioRecursive.UseVisualStyleBackColor = true;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(47, 90);
            this.txtPoints.Multiline = true;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPoints.Size = new System.Drawing.Size(185, 74);
            this.txtPoints.TabIndex = 3;
            this.txtPoints.Text = "0,25-10,49\r\n10,49-30,30\r\n30,30-40,5\r\n40,5-0,25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Points(counterclockwise)";
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(250, 90);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(473, 326);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 5;
            this.picbox.TabStop = false;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(489, 29);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 6;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIntersection
            // 
            this.txtIntersection.Location = new System.Drawing.Point(49, 196);
            this.txtIntersection.Multiline = true;
            this.txtIntersection.Name = "txtIntersection";
            this.txtIntersection.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIntersection.Size = new System.Drawing.Size(183, 220);
            this.txtIntersection.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Debug";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(594, 31);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 9;
            // 
            // CanvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 433);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIntersection);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.radioRecursive);
            this.Controls.Add(this.radioScan);
            this.Controls.Add(this.label1);
            this.Name = "CanvasForm";
            this.Text = "CanvasForm";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioScan;
        private System.Windows.Forms.RadioButton radioRecursive;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.TextBox txtIntersection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime;
    }
}