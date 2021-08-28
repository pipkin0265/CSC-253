
namespace AreaClassUI
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
            this.CircleRadioBtn = new System.Windows.Forms.RadioButton();
            this.RectanleRadioBtn = new System.Windows.Forms.RadioButton();
            this.CylRadioBtn = new System.Windows.Forms.RadioButton();
            this.circleGroupBox = new System.Windows.Forms.GroupBox();
            this.circleBtn = new System.Windows.Forms.Button();
            this.radiusLbl = new System.Windows.Forms.Label();
            this.radiusTxtBox = new System.Windows.Forms.TextBox();
            this.rectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.widthLbl = new System.Windows.Forms.Label();
            this.lengthTxtBox = new System.Windows.Forms.TextBox();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.widthTxtBox = new System.Windows.Forms.TextBox();
            this.cyGroupBox = new System.Windows.Forms.GroupBox();
            this.cylinderBtn = new System.Windows.Forms.Button();
            this.cyHeightTxtBox = new System.Windows.Forms.TextBox();
            this.cyRadiusTxtBox = new System.Windows.Forms.TextBox();
            this.cyRadiusLbl = new System.Windows.Forms.Label();
            this.cyHeightLbl = new System.Windows.Forms.Label();
            this.circleGroupBox.SuspendLayout();
            this.rectangleGroupBox.SuspendLayout();
            this.cyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CircleRadioBtn
            // 
            this.CircleRadioBtn.AutoSize = true;
            this.CircleRadioBtn.Location = new System.Drawing.Point(32, 49);
            this.CircleRadioBtn.Name = "CircleRadioBtn";
            this.CircleRadioBtn.Size = new System.Drawing.Size(88, 17);
            this.CircleRadioBtn.TabIndex = 0;
            this.CircleRadioBtn.TabStop = true;
            this.CircleRadioBtn.Text = "Area of Circle";
            this.CircleRadioBtn.UseVisualStyleBackColor = true;
            this.CircleRadioBtn.CheckedChanged += new System.EventHandler(this.CircleRadioBtn_CheckedChanged);
            // 
            // RectanleRadioBtn
            // 
            this.RectanleRadioBtn.AutoSize = true;
            this.RectanleRadioBtn.Location = new System.Drawing.Point(259, 49);
            this.RectanleRadioBtn.Name = "RectanleRadioBtn";
            this.RectanleRadioBtn.Size = new System.Drawing.Size(99, 17);
            this.RectanleRadioBtn.TabIndex = 1;
            this.RectanleRadioBtn.TabStop = true;
            this.RectanleRadioBtn.Text = "Area Rectangle";
            this.RectanleRadioBtn.UseVisualStyleBackColor = true;
            this.RectanleRadioBtn.CheckedChanged += new System.EventHandler(this.RectanleRadioBtn_CheckedChanged);
            // 
            // CylRadioBtn
            // 
            this.CylRadioBtn.AutoSize = true;
            this.CylRadioBtn.Location = new System.Drawing.Point(480, 49);
            this.CylRadioBtn.Name = "CylRadioBtn";
            this.CylRadioBtn.Size = new System.Drawing.Size(99, 17);
            this.CylRadioBtn.TabIndex = 2;
            this.CylRadioBtn.TabStop = true;
            this.CylRadioBtn.Text = "Area of Cylinder";
            this.CylRadioBtn.UseVisualStyleBackColor = true;
            this.CylRadioBtn.CheckedChanged += new System.EventHandler(this.CylRadioBtn_CheckedChanged);
            // 
            // circleGroupBox
            // 
            this.circleGroupBox.Controls.Add(this.circleBtn);
            this.circleGroupBox.Controls.Add(this.radiusLbl);
            this.circleGroupBox.Controls.Add(this.radiusTxtBox);
            this.circleGroupBox.Location = new System.Drawing.Point(32, 99);
            this.circleGroupBox.Name = "circleGroupBox";
            this.circleGroupBox.Size = new System.Drawing.Size(200, 219);
            this.circleGroupBox.TabIndex = 3;
            this.circleGroupBox.TabStop = false;
            this.circleGroupBox.Text = "Circle";
            // 
            // circleBtn
            // 
            this.circleBtn.Location = new System.Drawing.Point(49, 153);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(90, 23);
            this.circleBtn.TabIndex = 4;
            this.circleBtn.Text = "Calculate Area";
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // radiusLbl
            // 
            this.radiusLbl.AutoSize = true;
            this.radiusLbl.Location = new System.Drawing.Point(6, 58);
            this.radiusLbl.Name = "radiusLbl";
            this.radiusLbl.Size = new System.Drawing.Size(63, 13);
            this.radiusLbl.TabIndex = 0;
            this.radiusLbl.Text = "Enter width:";
            // 
            // radiusTxtBox
            // 
            this.radiusTxtBox.Location = new System.Drawing.Point(84, 58);
            this.radiusTxtBox.Name = "radiusTxtBox";
            this.radiusTxtBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTxtBox.TabIndex = 5;
            // 
            // rectangleGroupBox
            // 
            this.rectangleGroupBox.Controls.Add(this.rectangleBtn);
            this.rectangleGroupBox.Controls.Add(this.widthLbl);
            this.rectangleGroupBox.Controls.Add(this.lengthTxtBox);
            this.rectangleGroupBox.Controls.Add(this.lengthLbl);
            this.rectangleGroupBox.Controls.Add(this.widthTxtBox);
            this.rectangleGroupBox.Location = new System.Drawing.Point(259, 99);
            this.rectangleGroupBox.Name = "rectangleGroupBox";
            this.rectangleGroupBox.Size = new System.Drawing.Size(200, 219);
            this.rectangleGroupBox.TabIndex = 0;
            this.rectangleGroupBox.TabStop = false;
            this.rectangleGroupBox.Text = "Rectangle";
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.Location = new System.Drawing.Point(64, 153);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(86, 23);
            this.rectangleBtn.TabIndex = 5;
            this.rectangleBtn.Text = "Calculate Area";
            this.rectangleBtn.UseVisualStyleBackColor = true;
            this.rectangleBtn.Click += new System.EventHandler(this.rectangleBtn_Click);
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(6, 58);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(63, 13);
            this.widthLbl.TabIndex = 1;
            this.widthLbl.Text = "Enter width:";
            // 
            // lengthTxtBox
            // 
            this.lengthTxtBox.Location = new System.Drawing.Point(83, 98);
            this.lengthTxtBox.Name = "lengthTxtBox";
            this.lengthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTxtBox.TabIndex = 8;
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(6, 101);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(67, 13);
            this.lengthLbl.TabIndex = 2;
            this.lengthLbl.Text = "Enter length:";
            // 
            // widthTxtBox
            // 
            this.widthTxtBox.Location = new System.Drawing.Point(83, 55);
            this.widthTxtBox.Name = "widthTxtBox";
            this.widthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.widthTxtBox.TabIndex = 6;
            // 
            // cyGroupBox
            // 
            this.cyGroupBox.Controls.Add(this.cylinderBtn);
            this.cyGroupBox.Controls.Add(this.cyHeightTxtBox);
            this.cyGroupBox.Controls.Add(this.cyRadiusTxtBox);
            this.cyGroupBox.Controls.Add(this.cyRadiusLbl);
            this.cyGroupBox.Controls.Add(this.cyHeightLbl);
            this.cyGroupBox.Location = new System.Drawing.Point(480, 99);
            this.cyGroupBox.Name = "cyGroupBox";
            this.cyGroupBox.Size = new System.Drawing.Size(200, 219);
            this.cyGroupBox.TabIndex = 0;
            this.cyGroupBox.TabStop = false;
            this.cyGroupBox.Text = "Cylinder";
            // 
            // cylinderBtn
            // 
            this.cylinderBtn.Location = new System.Drawing.Point(71, 153);
            this.cylinderBtn.Name = "cylinderBtn";
            this.cylinderBtn.Size = new System.Drawing.Size(84, 23);
            this.cylinderBtn.TabIndex = 6;
            this.cylinderBtn.Text = "Calculate Area";
            this.cylinderBtn.UseVisualStyleBackColor = true;
            this.cylinderBtn.Click += new System.EventHandler(this.cylinderBtn_Click);
            // 
            // cyHeightTxtBox
            // 
            this.cyHeightTxtBox.Location = new System.Drawing.Point(94, 98);
            this.cyHeightTxtBox.Name = "cyHeightTxtBox";
            this.cyHeightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.cyHeightTxtBox.TabIndex = 9;
            // 
            // cyRadiusTxtBox
            // 
            this.cyRadiusTxtBox.Location = new System.Drawing.Point(94, 55);
            this.cyRadiusTxtBox.Name = "cyRadiusTxtBox";
            this.cyRadiusTxtBox.Size = new System.Drawing.Size(100, 20);
            this.cyRadiusTxtBox.TabIndex = 7;
            // 
            // cyRadiusLbl
            // 
            this.cyRadiusLbl.AutoSize = true;
            this.cyRadiusLbl.Location = new System.Drawing.Point(22, 58);
            this.cyRadiusLbl.Name = "cyRadiusLbl";
            this.cyRadiusLbl.Size = new System.Drawing.Size(66, 13);
            this.cyRadiusLbl.TabIndex = 3;
            this.cyRadiusLbl.Text = "Enter radius:";
            // 
            // cyHeightLbl
            // 
            this.cyHeightLbl.AutoSize = true;
            this.cyHeightLbl.Location = new System.Drawing.Point(21, 101);
            this.cyHeightLbl.Name = "cyHeightLbl";
            this.cyHeightLbl.Size = new System.Drawing.Size(67, 13);
            this.cyHeightLbl.TabIndex = 4;
            this.cyHeightLbl.Text = "Enter height:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.rectangleGroupBox);
            this.Controls.Add(this.cyGroupBox);
            this.Controls.Add(this.circleGroupBox);
            this.Controls.Add(this.CylRadioBtn);
            this.Controls.Add(this.RectanleRadioBtn);
            this.Controls.Add(this.CircleRadioBtn);
            this.Name = "MainForm";
            this.Text = "Area";
            this.circleGroupBox.ResumeLayout(false);
            this.circleGroupBox.PerformLayout();
            this.rectangleGroupBox.ResumeLayout(false);
            this.rectangleGroupBox.PerformLayout();
            this.cyGroupBox.ResumeLayout(false);
            this.cyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CircleRadioBtn;
        private System.Windows.Forms.RadioButton RectanleRadioBtn;
        private System.Windows.Forms.RadioButton CylRadioBtn;
        private System.Windows.Forms.GroupBox circleGroupBox;
        private System.Windows.Forms.GroupBox rectangleGroupBox;
        private System.Windows.Forms.GroupBox cyGroupBox;
        private System.Windows.Forms.Label radiusLbl;
        private System.Windows.Forms.TextBox radiusTxtBox;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.TextBox widthTxtBox;
        private System.Windows.Forms.TextBox cyHeightTxtBox;
        private System.Windows.Forms.TextBox lengthTxtBox;
        private System.Windows.Forms.TextBox cyRadiusTxtBox;
        private System.Windows.Forms.Label cyRadiusLbl;
        private System.Windows.Forms.Label cyHeightLbl;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button cylinderBtn;
    }
}

