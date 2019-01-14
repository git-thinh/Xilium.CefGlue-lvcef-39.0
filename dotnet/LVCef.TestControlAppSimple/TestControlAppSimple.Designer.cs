namespace TestControlAppSimple
{
    partial class TestControlAppSimpleForm
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
            this.lvCefControl1 = new LVCef.Control.LVCefControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDevTool = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCefControl1
            // 
            this.lvCefControl1.Location = new System.Drawing.Point(12, 41);
            this.lvCefControl1.Name = "lvCefControl1";
            this.lvCefControl1.Size = new System.Drawing.Size(725, 341);
            this.lvCefControl1.TabIndex = 0;
            this.lvCefControl1.Text = "lvCefControl1";
            this.lvCefControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(688, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Navigate to Dummy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TestControlAppSimpleForm_Click);
            // 
            // btnDevTool
            // 
            this.btnDevTool.Location = new System.Drawing.Point(119, 3);
            this.btnDevTool.Name = "btnDevTool";
            this.btnDevTool.Size = new System.Drawing.Size(61, 23);
            this.btnDevTool.TabIndex = 3;
            this.btnDevTool.Text = "DevTool";
            this.btnDevTool.UseVisualStyleBackColor = true;
            this.btnDevTool.Click += new System.EventHandler(this.btnDevTool_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(186, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(55, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Location = new System.Drawing.Point(247, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(435, 20);
            this.txtUrl.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnDevTool);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 35);
            this.panel1.TabIndex = 6;

            // TestControlAppSimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 513);
            this.Name = "TestControlAppSimpleForm";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.TestControlAppSimpleForm_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { lvCefControl1,  panel1});
            // 

        }

        #endregion

        private LVCef.Control.LVCefControl lvCefControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDevTool;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Panel panel1;
    }
}

