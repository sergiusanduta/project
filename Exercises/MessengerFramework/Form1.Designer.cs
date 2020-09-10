namespace MessengerFramework
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSmsForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Body";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(217, 36);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(558, 26);
            this.txtTo.TabIndex = 3;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(217, 95);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(558, 26);
            this.txtSubject.TabIndex = 4;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(217, 155);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(558, 190);
            this.txtBody.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(700, 390);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 36);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSmsForm
            // 
            this.btnSmsForm.Location = new System.Drawing.Point(563, 390);
            this.btnSmsForm.Name = "btnSmsForm";
            this.btnSmsForm.Size = new System.Drawing.Size(97, 36);
            this.btnSmsForm.TabIndex = 7;
            this.btnSmsForm.Text = "Open Sms Form";
            this.btnSmsForm.UseVisualStyleBackColor = true;
            this.btnSmsForm.Click += new System.EventHandler(this.btnSmsForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSmsForm);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSmsForm;
    }
}

