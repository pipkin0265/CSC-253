
namespace Car_Class_UI
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxMake = new System.Windows.Forms.TextBox();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.AccelerateBtn = new System.Windows.Forms.Button();
            this.BrakeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Speed Checker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Speed:";
            // 
            // txtboxMake
            // 
            this.txtboxMake.Location = new System.Drawing.Point(111, 46);
            this.txtboxMake.Name = "txtboxMake";
            this.txtboxMake.Size = new System.Drawing.Size(100, 20);
            this.txtboxMake.TabIndex = 4;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(111, 87);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(100, 20);
            this.txtBoxYear.TabIndex = 5;
            // 
            // lblSpeed
            // 
            this.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpeed.Location = new System.Drawing.Point(111, 132);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(100, 23);
            this.lblSpeed.TabIndex = 6;
            // 
            // AccelerateBtn
            // 
            this.AccelerateBtn.Location = new System.Drawing.Point(52, 180);
            this.AccelerateBtn.Name = "AccelerateBtn";
            this.AccelerateBtn.Size = new System.Drawing.Size(75, 23);
            this.AccelerateBtn.TabIndex = 7;
            this.AccelerateBtn.Text = "Accelerate";
            this.AccelerateBtn.UseVisualStyleBackColor = true;
            this.AccelerateBtn.Click += new System.EventHandler(this.AccelerateBtn_Click);
            // 
            // BrakeBtn
            // 
            this.BrakeBtn.Location = new System.Drawing.Point(154, 180);
            this.BrakeBtn.Name = "BrakeBtn";
            this.BrakeBtn.Size = new System.Drawing.Size(75, 23);
            this.BrakeBtn.TabIndex = 8;
            this.BrakeBtn.Text = "Brake";
            this.BrakeBtn.UseVisualStyleBackColor = true;
            this.BrakeBtn.Click += new System.EventHandler(this.BrakeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 231);
            this.Controls.Add(this.BrakeBtn);
            this.Controls.Add(this.AccelerateBtn);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.txtboxMake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxMake;
        private System.Windows.Forms.TextBox txtBoxYear;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button AccelerateBtn;
        private System.Windows.Forms.Button BrakeBtn;
    }
}

