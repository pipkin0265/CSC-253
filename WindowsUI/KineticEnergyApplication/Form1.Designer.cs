
namespace KineticEnergyApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.massTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.velocityTxtBox = new System.Windows.Forms.TextBox();
            this.btnCalcKE = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKeneticEnergy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kinetic Energy Application ";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(28, 85);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(78, 13);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "Mass in kg (m):";
            // 
            // massTxtBox
            // 
            this.massTxtBox.Location = new System.Drawing.Point(138, 85);
            this.massTxtBox.Name = "massTxtBox";
            this.massTxtBox.Size = new System.Drawing.Size(100, 20);
            this.massTxtBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Velocity in mps (v):";
            // 
            // velocityTxtBox
            // 
            this.velocityTxtBox.Location = new System.Drawing.Point(138, 137);
            this.velocityTxtBox.Name = "velocityTxtBox";
            this.velocityTxtBox.Size = new System.Drawing.Size(100, 20);
            this.velocityTxtBox.TabIndex = 4;
            // 
            // btnCalcKE
            // 
            this.btnCalcKE.Location = new System.Drawing.Point(34, 210);
            this.btnCalcKE.Name = "btnCalcKE";
            this.btnCalcKE.Size = new System.Drawing.Size(89, 48);
            this.btnCalcKE.TabIndex = 5;
            this.btnCalcKE.Text = "Calculate Kinetic Energy";
            this.btnCalcKE.UseVisualStyleBackColor = true;
            this.btnCalcKE.Click += new System.EventHandler(this.btnCalcKE_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(149, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kinetic Energy (J):";
            // 
            // lblKeneticEnergy
            // 
            this.lblKeneticEnergy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKeneticEnergy.Location = new System.Drawing.Point(146, 295);
            this.lblKeneticEnergy.Name = "lblKeneticEnergy";
            this.lblKeneticEnergy.Size = new System.Drawing.Size(100, 23);
            this.lblKeneticEnergy.TabIndex = 8;
            this.lblKeneticEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 346);
            this.Controls.Add(this.lblKeneticEnergy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcKE);
            this.Controls.Add(this.velocityTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.massTxtBox);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kinetic Energy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox massTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox velocityTxtBox;
        private System.Windows.Forms.Button btnCalcKE;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKeneticEnergy;
    }
}

