
namespace BMI
{
    partial class Forms1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WheigtInput_Box = new System.Windows.Forms.TextBox();
            this.LenhgInput_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BMI_PrintOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ext_Btn = new System.Windows.Forms.Button();
            this.Message_LBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorMessage_LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Räkna ut BMI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "BMI beräkning";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WheigtInput_Box
            // 
            this.WheigtInput_Box.Location = new System.Drawing.Point(30, 54);
            this.WheigtInput_Box.Name = "WheigtInput_Box";
            this.WheigtInput_Box.Size = new System.Drawing.Size(100, 23);
            this.WheigtInput_Box.TabIndex = 2;
            // 
            // LenhgInput_Box
            // 
            this.LenhgInput_Box.Location = new System.Drawing.Point(136, 54);
            this.LenhgInput_Box.Name = "LenhgInput_Box";
            this.LenhgInput_Box.Size = new System.Drawing.Size(100, 23);
            this.LenhgInput_Box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vikt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Längd CM";
            // 
            // BMI_PrintOut
            // 
            this.BMI_PrintOut.Location = new System.Drawing.Point(30, 98);
            this.BMI_PrintOut.Name = "BMI_PrintOut";
            this.BMI_PrintOut.Size = new System.Drawing.Size(206, 23);
            this.BMI_PrintOut.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "BMI";
            // 
            // Ext_Btn
            // 
            this.Ext_Btn.Location = new System.Drawing.Point(147, 127);
            this.Ext_Btn.Name = "Ext_Btn";
            this.Ext_Btn.Size = new System.Drawing.Size(89, 31);
            this.Ext_Btn.TabIndex = 8;
            this.Ext_Btn.Text = "Exit Aplication";
            this.Ext_Btn.UseVisualStyleBackColor = true;
            this.Ext_Btn.Click += new System.EventHandler(this.Ext_Btn_Click);
            // 
            // Message_LBL
            // 
            this.Message_LBL.AutoSize = true;
            this.Message_LBL.Location = new System.Drawing.Point(30, 161);
            this.Message_LBL.Name = "Message_LBL";
            this.Message_LBL.Size = new System.Drawing.Size(77, 15);
            this.Message_LBL.TabIndex = 9;
            this.Message_LBL.Text = "Bmi Message";
            this.Message_LBL.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 10;
            // 
            // ErrorMessage_LBL
            // 
            this.ErrorMessage_LBL.AutoSize = true;
            this.ErrorMessage_LBL.Location = new System.Drawing.Point(30, 176);
            this.ErrorMessage_LBL.Name = "ErrorMessage_LBL";
            this.ErrorMessage_LBL.Size = new System.Drawing.Size(117, 15);
            this.ErrorMessage_LBL.TabIndex = 11;
            this.ErrorMessage_LBL.Text = "Working as expected";
            // 
            // Forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 223);
            this.Controls.Add(this.ErrorMessage_LBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Message_LBL);
            this.Controls.Add(this.Ext_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BMI_PrintOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LenhgInput_Box);
            this.Controls.Add(this.WheigtInput_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Forms1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WheigtInput_Box;
        private System.Windows.Forms.TextBox LenhgInput_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BMI_PrintOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Ext_Btn;
        private System.Windows.Forms.Label Message_LBL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ErrorMessage_LBL;
    }
}

