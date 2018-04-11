namespace CoffeeShopHue
{
    partial class FrmCoffeeSystem
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
            this.Menu_System = new System.Windows.Forms.MenuStrip();
            this.Status_System = new System.Windows.Forms.StatusStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.accountManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loggingSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_System.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_System
            // 
            this.Menu_System.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem});
            this.Menu_System.Location = new System.Drawing.Point(0, 0);
            this.Menu_System.Name = "Menu_System";
            this.Menu_System.Size = new System.Drawing.Size(882, 24);
            this.Menu_System.TabIndex = 0;
            this.Menu_System.Text = "menuStrip1";
            // 
            // Status_System
            // 
            this.Status_System.Location = new System.Drawing.Point(0, 389);
            this.Status_System.Name = "Status_System";
            this.Status_System.Size = new System.Drawing.Size(882, 22);
            this.Status_System.TabIndex = 1;
            this.Status_System.Text = "statusStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator2,
            this.accountManagerToolStripMenuItem,
            this.toolStripSeparator3,
            this.loggingSystemToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // accountManagerToolStripMenuItem
            // 
            this.accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            this.accountManagerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.accountManagerToolStripMenuItem.Text = "Account Manager";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // loggingSystemToolStripMenuItem
            // 
            this.loggingSystemToolStripMenuItem.Name = "loggingSystemToolStripMenuItem";
            this.loggingSystemToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loggingSystemToolStripMenuItem.Text = "Logging System";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FrmCoffeeSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 411);
            this.Controls.Add(this.Status_System);
            this.Controls.Add(this.Menu_System);
            this.MainMenuStrip = this.Menu_System;
            this.Name = "FrmCoffeeSystem";
            this.Text = "Coffee Shop Hue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu_System.ResumeLayout(false);
            this.Menu_System.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_System;
        private System.Windows.Forms.StatusStrip Status_System;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem accountManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loggingSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

