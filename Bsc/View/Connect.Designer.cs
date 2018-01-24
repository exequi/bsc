namespace Bsc.View
{
    partial class Connect
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
            this.lb_connects = new System.Windows.Forms.ListBox();
            this.btn_setfolder = new System.Windows.Forms.Button();
            this.btn_deletefolder = new System.Windows.Forms.Button();
            this.btn_addmater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_connects
            // 
            this.lb_connects.FormattingEnabled = true;
            this.lb_connects.ItemHeight = 18;
            this.lb_connects.Location = new System.Drawing.Point(32, 28);
            this.lb_connects.Name = "lb_connects";
            this.lb_connects.Size = new System.Drawing.Size(1038, 418);
            this.lb_connects.TabIndex = 0;
            // 
            // btn_setfolder
            // 
            this.btn_setfolder.Location = new System.Drawing.Point(827, 477);
            this.btn_setfolder.Name = "btn_setfolder";
            this.btn_setfolder.Size = new System.Drawing.Size(75, 33);
            this.btn_setfolder.TabIndex = 1;
            this.btn_setfolder.Text = "设置";
            this.btn_setfolder.UseVisualStyleBackColor = true;
            // 
            // btn_deletefolder
            // 
            this.btn_deletefolder.Location = new System.Drawing.Point(946, 477);
            this.btn_deletefolder.Name = "btn_deletefolder";
            this.btn_deletefolder.Size = new System.Drawing.Size(75, 33);
            this.btn_deletefolder.TabIndex = 2;
            this.btn_deletefolder.Text = "删除";
            this.btn_deletefolder.UseVisualStyleBackColor = true;
            // 
            // btn_addmater
            // 
            this.btn_addmater.Location = new System.Drawing.Point(686, 477);
            this.btn_addmater.Name = "btn_addmater";
            this.btn_addmater.Size = new System.Drawing.Size(97, 33);
            this.btn_addmater.TabIndex = 3;
            this.btn_addmater.Text = "添加主机";
            this.btn_addmater.UseVisualStyleBackColor = true;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 536);
            this.Controls.Add(this.btn_addmater);
            this.Controls.Add(this.btn_deletefolder);
            this.Controls.Add(this.btn_setfolder);
            this.Controls.Add(this.lb_connects);
            this.Name = "Connect";
            this.Text = "Connect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_connects;
        private System.Windows.Forms.Button btn_setfolder;
        private System.Windows.Forms.Button btn_deletefolder;
        private System.Windows.Forms.Button btn_addmater;
    }
}