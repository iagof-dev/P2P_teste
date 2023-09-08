namespace P2P_teste
{
    partial class profile
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
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.lbl_actualname = new System.Windows.Forms.Label();
            this.txtbox_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Saveall = new System.Windows.Forms.Button();
            this.num_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome de usuário:";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(51, 58);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(120, 20);
            this.txtbox_username.TabIndex = 2;
            // 
            // lbl_actualname
            // 
            this.lbl_actualname.AutoSize = true;
            this.lbl_actualname.Location = new System.Drawing.Point(48, 9);
            this.lbl_actualname.Name = "lbl_actualname";
            this.lbl_actualname.Size = new System.Drawing.Size(64, 13);
            this.lbl_actualname.TabIndex = 3;
            this.lbl_actualname.Text = "Nome atual:";
            // 
            // txtbox_ip
            // 
            this.txtbox_ip.Location = new System.Drawing.Point(51, 129);
            this.txtbox_ip.Name = "txtbox_ip";
            this.txtbox_ip.Size = new System.Drawing.Size(120, 20);
            this.txtbox_ip.TabIndex = 6;
            this.txtbox_ip.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port:";
            // 
            // btn_Saveall
            // 
            this.btn_Saveall.Location = new System.Drawing.Point(42, 225);
            this.btn_Saveall.Name = "btn_Saveall";
            this.btn_Saveall.Size = new System.Drawing.Size(342, 40);
            this.btn_Saveall.TabIndex = 7;
            this.btn_Saveall.Text = "save";
            this.btn_Saveall.UseVisualStyleBackColor = true;
            this.btn_Saveall.Click += new System.EventHandler(this.btn_Saveall_Click);
            // 
            // num_port
            // 
            this.num_port.Location = new System.Drawing.Point(51, 185);
            this.num_port.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_port.Name = "num_port";
            this.num_port.Size = new System.Drawing.Size(120, 20);
            this.num_port.TabIndex = 9;
            this.num_port.Value = new decimal(new int[] {
            4220,
            0,
            0,
            0});
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 387);
            this.Controls.Add(this.num_port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Saveall);
            this.Controls.Add(this.txtbox_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_actualname);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.label1);
            this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Label lbl_actualname;
        private System.Windows.Forms.TextBox txtbox_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Saveall;
        private System.Windows.Forms.NumericUpDown num_port;
    }
}