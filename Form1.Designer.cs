namespace laborMgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.adminTxt = new System.Windows.Forms.RadioButton();
            this.managerTxt = new System.Windows.Forms.RadioButton();
            this.laborTxt = new System.Windows.Forms.RadioButton();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(217, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Login Option";
            // 
            // adminTxt
            // 
            this.adminTxt.AutoSize = true;
            this.adminTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTxt.Location = new System.Drawing.Point(256, 84);
            this.adminTxt.Name = "adminTxt";
            this.adminTxt.Size = new System.Drawing.Size(134, 24);
            this.adminTxt.TabIndex = 1;
            this.adminTxt.TabStop = true;
            this.adminTxt.Text = "Administrator";
            this.adminTxt.UseVisualStyleBackColor = true;
            // 
            // managerTxt
            // 
            this.managerTxt.AutoSize = true;
            this.managerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerTxt.Location = new System.Drawing.Point(256, 146);
            this.managerTxt.Name = "managerTxt";
            this.managerTxt.Size = new System.Drawing.Size(97, 24);
            this.managerTxt.TabIndex = 2;
            this.managerTxt.TabStop = true;
            this.managerTxt.Text = "Manager";
            this.managerTxt.UseVisualStyleBackColor = true;
            // 
            // laborTxt
            // 
            this.laborTxt.AutoSize = true;
            this.laborTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborTxt.Location = new System.Drawing.Point(256, 210);
            this.laborTxt.Name = "laborTxt";
            this.laborTxt.Size = new System.Drawing.Size(73, 24);
            this.laborTxt.TabIndex = 3;
            this.laborTxt.TabStop = true;
            this.laborTxt.Text = "Labor";
            this.laborTxt.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(256, 256);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(97, 41);
            this.ok.TabIndex = 4;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(722, 341);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.laborTxt);
            this.Controls.Add(this.managerTxt);
            this.Controls.Add(this.adminTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton adminTxt;
        private System.Windows.Forms.RadioButton managerTxt;
        private System.Windows.Forms.RadioButton laborTxt;
        private System.Windows.Forms.Button ok;
    }
}

