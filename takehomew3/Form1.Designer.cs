namespace takehomew3
{
    partial class mainwindowform
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
            this.button_newform = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_favartist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_true = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_newform
            // 
            this.button_newform.Enabled = false;
            this.button_newform.Location = new System.Drawing.Point(97, 138);
            this.button_newform.Name = "button_newform";
            this.button_newform.Size = new System.Drawing.Size(204, 23);
            this.button_newform.TabIndex = 0;
            this.button_newform.Text = "Open Next Form";
            this.button_newform.UseVisualStyleBackColor = true;
            this.button_newform.Click += new System.EventHandler(this.button_newform_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(21, 27);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(50, 16);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name: ";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(78, 27);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_favartist
            // 
            this.textBox_favartist.Location = new System.Drawing.Point(126, 55);
            this.textBox_favartist.Name = "textBox_favartist";
            this.textBox_favartist.Size = new System.Drawing.Size(242, 22);
            this.textBox_favartist.TabIndex = 3;
            this.textBox_favartist.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "My favorite Artist:";
            // 
            // checkBox_true
            // 
            this.checkBox_true.AutoSize = true;
            this.checkBox_true.Location = new System.Drawing.Point(16, 94);
            this.checkBox_true.Name = "checkBox_true";
            this.checkBox_true.Size = new System.Drawing.Size(235, 20);
            this.checkBox_true.TabIndex = 5;
            this.checkBox_true.Text = "All of the content I put above is true!";
            this.checkBox_true.UseVisualStyleBackColor = true;
            this.checkBox_true.CheckedChanged += new System.EventHandler(this.checkBox_true_CheckedChanged);
            // 
            // button_submit
            // 
            this.button_submit.Enabled = false;
            this.button_submit.Location = new System.Drawing.Point(16, 138);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // mainwindowform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkBox_true);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_favartist);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_newform);
            this.Name = "mainwindowform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_newform;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_favartist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_true;
        private System.Windows.Forms.Button button_submit;
    }
}

