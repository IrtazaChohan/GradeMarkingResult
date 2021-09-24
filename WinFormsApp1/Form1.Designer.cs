
namespace WinFormsApp1
{
    partial class FrmGradeMarking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGradeMarkingResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.txtGrade3 = new System.Windows.Forms.TextBox();
            this.txtGrade4 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGradeMarkingResult
            // 
            this.lblGradeMarkingResult.AutoSize = true;
            this.lblGradeMarkingResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGradeMarkingResult.ForeColor = System.Drawing.Color.Red;
            this.lblGradeMarkingResult.Location = new System.Drawing.Point(203, 27);
            this.lblGradeMarkingResult.Name = "lblGradeMarkingResult";
            this.lblGradeMarkingResult.Size = new System.Drawing.Size(262, 32);
            this.lblGradeMarkingResult.TabIndex = 0;
            this.lblGradeMarkingResult.Text = "Grade Marking Result";
            this.lblGradeMarkingResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(263, 178);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 30);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "CALCULATE!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter each grade below to work out the average";
            // 
            // txtGrade1
            // 
            this.txtGrade1.Location = new System.Drawing.Point(70, 122);
            this.txtGrade1.Name = "txtGrade1";
            this.txtGrade1.Size = new System.Drawing.Size(100, 23);
            this.txtGrade1.TabIndex = 3;
            // 
            // txtGrade2
            // 
            this.txtGrade2.Location = new System.Drawing.Point(213, 122);
            this.txtGrade2.Name = "txtGrade2";
            this.txtGrade2.Size = new System.Drawing.Size(100, 23);
            this.txtGrade2.TabIndex = 4;
            // 
            // txtGrade3
            // 
            this.txtGrade3.Location = new System.Drawing.Point(365, 122);
            this.txtGrade3.Name = "txtGrade3";
            this.txtGrade3.Size = new System.Drawing.Size(100, 23);
            this.txtGrade3.TabIndex = 5;
            // 
            // txtGrade4
            // 
            this.txtGrade4.Location = new System.Drawing.Point(505, 122);
            this.txtGrade4.Name = "txtGrade4";
            this.txtGrade4.Size = new System.Drawing.Size(100, 23);
            this.txtGrade4.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.Color.Navy;
            this.lblResult.Location = new System.Drawing.Point(12, 228);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(78, 32);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";
            this.lblResult.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(531, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGradeMarking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtGrade4);
            this.Controls.Add(this.txtGrade3);
            this.Controls.Add(this.txtGrade2);
            this.Controls.Add(this.txtGrade1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGradeMarkingResult);
            this.Name = "FrmGradeMarking";
            this.Text = "Grade Marking Result";
            this.Load += new System.EventHandler(this.FrmGradeMarking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradeMarkingResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.TextBox txtGrade3;
        private System.Windows.Forms.TextBox txtGrade4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}

