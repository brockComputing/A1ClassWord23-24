namespace WinFormsF
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtHair = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHasHair = new System.Windows.Forms.CheckBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 180);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(534, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 33);
            this.txtName.TabIndex = 1;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtage.Location = new System.Drawing.Point(534, 146);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 33);
            this.txtage.TabIndex = 2;
            this.txtage.Text = "0";
            // 
            // txtHair
            // 
            this.txtHair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHair.Location = new System.Drawing.Point(534, 214);
            this.txtHair.Name = "txtHair";
            this.txtHair.Size = new System.Drawing.Size(100, 33);
            this.txtHair.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // chkHasHair
            // 
            this.chkHasHair.AutoSize = true;
            this.chkHasHair.Location = new System.Drawing.Point(534, 275);
            this.chkHasHair.Name = "chkHasHair";
            this.chkHasHair.Size = new System.Drawing.Size(83, 19);
            this.chkHasHair.TabIndex = 5;
            this.chkHasHair.Text = "checkBox1";
            this.chkHasHair.UseVisualStyleBackColor = true;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.Location = new System.Drawing.Point(488, 351);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(96, 37);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 77);
            this.button2.TabIndex = 7;
            this.button2.Text = "Open EX2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(710, 214);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(88, 97);
            this.btnOpenForm2.TabIndex = 8;
            this.btnOpenForm2.Text = "Open Form2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenForm2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.chkHasHair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHair);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtName;
        private TextBox txtage;
        private TextBox txtHair;
        private Label label1;
        private CheckBox chkHasHair;
        private Label lblAnswer;
        private Button button2;
        private Button btnOpenForm2;
    }
}