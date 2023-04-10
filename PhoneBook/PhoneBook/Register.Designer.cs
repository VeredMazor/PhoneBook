namespace PhoneBook
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.New_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save_butt = new System.Windows.Forms.ToolStripButton();
            this.Info_gbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_textBox1 = new System.Windows.Forms.TextBox();
            this.fn_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ln_textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cn_textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.e_textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.a_textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.c_textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Info_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.New_butt,
            this.toolStripSeparator1,
            this.Save_butt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(555, 105);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 105);
            // 
            // New_butt
            // 
            this.New_butt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_butt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.New_butt.Image = ((System.Drawing.Image)(resources.GetObject("New_butt.Image")));
            this.New_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.New_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_butt.Name = "New_butt";
            this.New_butt.Size = new System.Drawing.Size(146, 102);
            this.New_butt.Text = "New Data";
            this.New_butt.Click += new System.EventHandler(this.New_Butt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 105);
            // 
            // Save_butt
            // 
            this.Save_butt.Enabled = false;
            this.Save_butt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_butt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Save_butt.Image = ((System.Drawing.Image)(resources.GetObject("Save_butt.Image")));
            this.Save_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Save_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_butt.Name = "Save_butt";
            this.Save_butt.Size = new System.Drawing.Size(172, 102);
            this.Save_butt.Text = "Save Changes";
            this.Save_butt.Click += new System.EventHandler(this.Save_Butt_Click);
            // 
            // Info_gbox
            // 
            this.Info_gbox.Controls.Add(this.c_textBox8);
            this.Info_gbox.Controls.Add(this.label8);
            this.Info_gbox.Controls.Add(this.a_textBox7);
            this.Info_gbox.Controls.Add(this.label7);
            this.Info_gbox.Controls.Add(this.e_textBox6);
            this.Info_gbox.Controls.Add(this.label6);
            this.Info_gbox.Controls.Add(this.cn_textBox5);
            this.Info_gbox.Controls.Add(this.label5);
            this.Info_gbox.Controls.Add(this.t_textBox4);
            this.Info_gbox.Controls.Add(this.label4);
            this.Info_gbox.Controls.Add(this.ln_textBox3);
            this.Info_gbox.Controls.Add(this.label3);
            this.Info_gbox.Controls.Add(this.fn_textBox2);
            this.Info_gbox.Controls.Add(this.label2);
            this.Info_gbox.Controls.Add(this.id_textBox1);
            this.Info_gbox.Controls.Add(this.label1);
            this.Info_gbox.Enabled = false;
            this.Info_gbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_gbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Info_gbox.Location = new System.Drawing.Point(25, 131);
            this.Info_gbox.Name = "Info_gbox";
            this.Info_gbox.Size = new System.Drawing.Size(504, 507);
            this.Info_gbox.TabIndex = 1;
            this.Info_gbox.TabStop = false;
            this.Info_gbox.Text = "  Information";
            this.Info_gbox.Enter += new System.EventHandler(this.Reg_Data_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(62, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id_textBox1
            // 
            this.id_textBox1.Location = new System.Drawing.Point(169, 88);
            this.id_textBox1.Name = "id_textBox1";
            this.id_textBox1.Size = new System.Drawing.Size(218, 22);
            this.id_textBox1.TabIndex = 1;
            this.id_textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fn_textBox2
            // 
            this.fn_textBox2.Location = new System.Drawing.Point(169, 125);
            this.fn_textBox2.Name = "fn_textBox2";
            this.fn_textBox2.Size = new System.Drawing.Size(218, 22);
            this.fn_textBox2.TabIndex = 3;
            this.fn_textBox2.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = " First Name:";
            // 
            // ln_textBox3
            // 
            this.ln_textBox3.Location = new System.Drawing.Point(169, 164);
            this.ln_textBox3.Name = "ln_textBox3";
            this.ln_textBox3.Size = new System.Drawing.Size(218, 22);
            this.ln_textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(60, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // t_textBox4
            // 
            this.t_textBox4.Location = new System.Drawing.Point(169, 204);
            this.t_textBox4.Name = "t_textBox4";
            this.t_textBox4.Size = new System.Drawing.Size(218, 22);
            this.t_textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(60, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone:";
            // 
            // cn_textBox5
            // 
            this.cn_textBox5.Location = new System.Drawing.Point(169, 245);
            this.cn_textBox5.Name = "cn_textBox5";
            this.cn_textBox5.Size = new System.Drawing.Size(218, 22);
            this.cn_textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(62, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cell Number:";
            // 
            // e_textBox6
            // 
            this.e_textBox6.Location = new System.Drawing.Point(169, 286);
            this.e_textBox6.Name = "e_textBox6";
            this.e_textBox6.Size = new System.Drawing.Size(218, 22);
            this.e_textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(62, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // a_textBox7
            // 
            this.a_textBox7.Location = new System.Drawing.Point(169, 326);
            this.a_textBox7.Name = "a_textBox7";
            this.a_textBox7.Size = new System.Drawing.Size(218, 22);
            this.a_textBox7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(62, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address:";
            // 
            // c_textBox8
            // 
            this.c_textBox8.Location = new System.Drawing.Point(169, 365);
            this.c_textBox8.Name = "c_textBox8";
            this.c_textBox8.Size = new System.Drawing.Size(218, 22);
            this.c_textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(62, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(555, 663);
            this.Controls.Add(this.Info_gbox);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Data";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Info_gbox.ResumeLayout(false);
            this.Info_gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton New_butt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Save_butt;
        private System.Windows.Forms.GroupBox Info_gbox;
        private System.Windows.Forms.TextBox id_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox a_textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox e_textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cn_textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ln_textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fn_textBox2;
        private System.Windows.Forms.Label label2;
    }
}