namespace TestWinForms
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
            this.btn_Hello = new System.Windows.Forms.Button();
            this.lbl_Hello = new System.Windows.Forms.Label();
            this.btn_Color = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbltxt1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Hello
            // 
            this.btn_Hello.Location = new System.Drawing.Point(144, 134);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(464, 189);
            this.btn_Hello.TabIndex = 0;
            this.btn_Hello.Text = "Click Me";
            this.btn_Hello.UseVisualStyleBackColor = true;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // lbl_Hello
            // 
            this.lbl_Hello.AutoSize = true;
            this.lbl_Hello.Location = new System.Drawing.Point(354, 351);
            this.lbl_Hello.Name = "lbl_Hello";
            this.lbl_Hello.Size = new System.Drawing.Size(0, 16);
            this.lbl_Hello.TabIndex = 1;
            // 
            // btn_Color
            // 
            this.btn_Color.Location = new System.Drawing.Point(631, 134);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(102, 50);
            this.btn_Color.TabIndex = 2;
            this.btn_Color.Text = "Color";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(560, 88);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbltxt1
            // 
            this.lbltxt1.AutoSize = true;
            this.lbltxt1.Location = new System.Drawing.Point(664, 91);
            this.lbltxt1.Name = "lbltxt1";
            this.lbltxt1.Size = new System.Drawing.Size(0, 16);
            this.lbltxt1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltxt1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Color);
            this.Controls.Add(this.lbl_Hello);
            this.Controls.Add(this.btn_Hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Label lbl_Hello;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbltxt1;
    }
}

