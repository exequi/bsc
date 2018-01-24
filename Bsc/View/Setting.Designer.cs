namespace Bsc.View
{
    partial class Setting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_createaccount = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_up_rightnow = new System.Windows.Forms.CheckBox();
            this.cb_authup = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_down_interval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_up_interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apiurl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_list_auto = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_createaccount);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账户";
            // 
            // btn_createaccount
            // 
            this.btn_createaccount.Location = new System.Drawing.Point(344, 41);
            this.btn_createaccount.Name = "btn_createaccount";
            this.btn_createaccount.Size = new System.Drawing.Size(103, 33);
            this.btn_createaccount.TabIndex = 12;
            this.btn_createaccount.Text = "创建机器";
            this.btn_createaccount.UseVisualStyleBackColor = true;
            this.btn_createaccount.Click += new System.EventHandler(this.btn_createaccount_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(119, 93);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(190, 28);
            this.txt_password.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "密码";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(119, 45);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(190, 28);
            this.txt_username.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "机器名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_up_rightnow);
            this.groupBox2.Controls.Add(this.cb_authup);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_down_interval);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_up_interval);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_apiurl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(32, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1169, 198);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "常规";
            // 
            // cb_up_rightnow
            // 
            this.cb_up_rightnow.AutoSize = true;
            this.cb_up_rightnow.Location = new System.Drawing.Point(466, 149);
            this.cb_up_rightnow.Name = "cb_up_rightnow";
            this.cb_up_rightnow.Size = new System.Drawing.Size(196, 22);
            this.cb_up_rightnow.TabIndex = 16;
            this.cb_up_rightnow.Text = "文件修改后立即上传";
            this.cb_up_rightnow.UseVisualStyleBackColor = true;
            // 
            // cb_authup
            // 
            this.cb_authup.AutoSize = true;
            this.cb_authup.Location = new System.Drawing.Point(466, 102);
            this.cb_authup.Name = "cb_authup";
            this.cb_authup.Size = new System.Drawing.Size(106, 22);
            this.cb_authup.TabIndex = 15;
            this.cb_authup.Text = "开机启动";
            this.cb_authup.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "分钟";
            // 
            // txt_down_interval
            // 
            this.txt_down_interval.Location = new System.Drawing.Point(184, 143);
            this.txt_down_interval.Name = "txt_down_interval";
            this.txt_down_interval.Size = new System.Drawing.Size(107, 28);
            this.txt_down_interval.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "刷新下载间隔:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "分钟";
            // 
            // txt_up_interval
            // 
            this.txt_up_interval.Location = new System.Drawing.Point(184, 93);
            this.txt_up_interval.Name = "txt_up_interval";
            this.txt_up_interval.Size = new System.Drawing.Size(107, 28);
            this.txt_up_interval.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "定时上传间隔:";
            // 
            // txt_apiurl
            // 
            this.txt_apiurl.Location = new System.Drawing.Point(184, 45);
            this.txt_apiurl.Name = "txt_apiurl";
            this.txt_apiurl.Size = new System.Drawing.Size(821, 28);
            this.txt_apiurl.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "服务器:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1098, 626);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(103, 33);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "保存";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_list_auto);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(32, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1169, 158);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "备份下载";
            // 
            // cb_list_auto
            // 
            this.cb_list_auto.FormattingEnabled = true;
            this.cb_list_auto.Items.AddRange(new object[] {
            "新建文件",
            "更新文件",
            "删除文件"});
            this.cb_list_auto.Location = new System.Drawing.Point(160, 55);
            this.cb_list_auto.Name = "cb_list_auto";
            this.cb_list_auto.Size = new System.Drawing.Size(120, 96);
            this.cb_list_auto.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "自动处理操作";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 671);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_createaccount;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_down_interval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_up_interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apiurl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox cb_list_auto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cb_authup;
        private System.Windows.Forms.CheckBox cb_up_rightnow;
    }
}