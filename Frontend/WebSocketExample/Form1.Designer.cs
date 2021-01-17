
namespace WebSocketExample
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblConnectedStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConnection = new System.Windows.Forms.Label();
            this.panUrl = new System.Windows.Forms.Panel();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.panPort = new System.Windows.Forms.Panel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.panButtons = new System.Windows.Forms.Panel();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.lblSend = new System.Windows.Forms.Label();
            this.panSend = new System.Windows.Forms.Panel();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.lblMessageLog = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panUrl.SuspendLayout();
            this.panPort.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.panSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnectedStatus});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblConnectedStatus
            // 
            this.lblConnectedStatus.Name = "lblConnectedStatus";
            resources.ApplyResources(this.lblConnectedStatus, "lblConnectedStatus");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubProjectToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // githubProjectToolStripMenuItem
            // 
            this.githubProjectToolStripMenuItem.Name = "githubProjectToolStripMenuItem";
            resources.ApplyResources(this.githubProjectToolStripMenuItem, "githubProjectToolStripMenuItem");
            this.githubProjectToolStripMenuItem.Click += new System.EventHandler(this.GithubProjectToolStripMenuItem_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lblConnection, "lblConnection");
            this.lblConnection.Name = "lblConnection";
            // 
            // panUrl
            // 
            this.panUrl.Controls.Add(this.txtServer);
            this.panUrl.Controls.Add(this.lblServer);
            resources.ApplyResources(this.panUrl, "panUrl");
            this.panUrl.Name = "panUrl";
            // 
            // txtServer
            // 
            resources.ApplyResources(this.txtServer, "txtServer");
            this.txtServer.Name = "txtServer";
            // 
            // lblServer
            // 
            resources.ApplyResources(this.lblServer, "lblServer");
            this.lblServer.Name = "lblServer";
            // 
            // panPort
            // 
            this.panPort.Controls.Add(this.txtPort);
            this.panPort.Controls.Add(this.lblPort);
            resources.ApplyResources(this.panPort, "panPort");
            this.panPort.Name = "panPort";
            // 
            // txtPort
            // 
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.Name = "txtPort";
            this.txtPort.Validating += new System.ComponentModel.CancelEventHandler(this.TextPort_Validating);
            // 
            // lblPort
            // 
            resources.ApplyResources(this.lblPort, "lblPort");
            this.lblPort.Name = "lblPort";
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.cmdDisconnect);
            this.panButtons.Controls.Add(this.cmdConnect);
            resources.ApplyResources(this.panButtons, "panButtons");
            this.panButtons.Name = "panButtons";
            // 
            // cmdDisconnect
            // 
            resources.ApplyResources(this.cmdDisconnect, "cmdDisconnect");
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            this.cmdDisconnect.Click += new System.EventHandler(this.CmdConnect_Click);
            // 
            // cmdConnect
            // 
            resources.ApplyResources(this.cmdConnect, "cmdConnect");
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.CmdConnect_Click);
            // 
            // lblSend
            // 
            this.lblSend.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lblSend, "lblSend");
            this.lblSend.Name = "lblSend";
            // 
            // panSend
            // 
            this.panSend.Controls.Add(this.txtSend);
            this.panSend.Controls.Add(this.cmdSend);
            resources.ApplyResources(this.panSend, "panSend");
            this.panSend.Name = "panSend";
            // 
            // txtSend
            // 
            this.txtSend.AcceptsReturn = true;
            this.txtSend.AcceptsTab = true;
            resources.ApplyResources(this.txtSend, "txtSend");
            this.txtSend.Name = "txtSend";
            // 
            // cmdSend
            // 
            resources.ApplyResources(this.cmdSend, "cmdSend");
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.CmdSend_Click);
            // 
            // lblMessageLog
            // 
            this.lblMessageLog.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lblMessageLog, "lblMessageLog");
            this.lblMessageLog.Name = "lblMessageLog";
            // 
            // txtLog
            // 
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblMessageLog);
            this.Controls.Add(this.panSend);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.panPort);
            this.Controls.Add(this.panUrl);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panUrl.ResumeLayout(false);
            this.panUrl.PerformLayout();
            this.panPort.ResumeLayout(false);
            this.panPort.PerformLayout();
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.panSend.ResumeLayout(false);
            this.panSend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectedStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubProjectToolStripMenuItem;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Panel panUrl;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Panel panPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button cmdDisconnect;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Panel panSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Label lblMessageLog;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}

