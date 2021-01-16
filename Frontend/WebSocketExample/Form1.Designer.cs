
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
            this.lblUrl = new System.Windows.Forms.Label();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblConnectedStatus
            // 
            this.lblConnectedStatus.Name = "lblConnectedStatus";
            this.lblConnectedStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubProjectToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // githubProjectToolStripMenuItem
            // 
            this.githubProjectToolStripMenuItem.Name = "githubProjectToolStripMenuItem";
            this.githubProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.githubProjectToolStripMenuItem.Text = "&GitHub Project";
            this.githubProjectToolStripMenuItem.Click += new System.EventHandler(this.GithubProjectToolStripMenuItem_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.BackColor = System.Drawing.SystemColors.Info;
            this.lblConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(0, 24);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(800, 25);
            this.lblConnection.TabIndex = 3;
            this.lblConnection.Text = "lblConnection";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panUrl
            // 
            this.panUrl.Controls.Add(this.txtServer);
            this.panUrl.Controls.Add(this.lblUrl);
            this.panUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panUrl.Location = new System.Drawing.Point(0, 49);
            this.panUrl.Name = "panUrl";
            this.panUrl.Padding = new System.Windows.Forms.Padding(3);
            this.panUrl.Size = new System.Drawing.Size(800, 30);
            this.panUrl.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Location = new System.Drawing.Point(170, 3);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(627, 20);
            this.txtServer.TabIndex = 1;
            // 
            // lblUrl
            // 
            this.lblUrl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUrl.Location = new System.Drawing.Point(3, 3);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(167, 24);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "lblUrl";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panPort
            // 
            this.panPort.Controls.Add(this.txtPort);
            this.panPort.Controls.Add(this.lblPort);
            this.panPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPort.Location = new System.Drawing.Point(0, 79);
            this.panPort.Name = "panPort";
            this.panPort.Padding = new System.Windows.Forms.Padding(3);
            this.panPort.Size = new System.Drawing.Size(800, 30);
            this.panPort.TabIndex = 6;
            // 
            // txtPort
            // 
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPort.Location = new System.Drawing.Point(170, 3);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(81, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8080";
            this.txtPort.Validating += new System.ComponentModel.CancelEventHandler(this.TextPort_Validating);
            // 
            // lblPort
            // 
            this.lblPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPort.Location = new System.Drawing.Point(3, 3);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(167, 24);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "lblPort";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.cmdDisconnect);
            this.panButtons.Controls.Add(this.cmdConnect);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panButtons.Location = new System.Drawing.Point(0, 109);
            this.panButtons.Name = "panButtons";
            this.panButtons.Padding = new System.Windows.Forms.Padding(3);
            this.panButtons.Size = new System.Drawing.Size(800, 30);
            this.panButtons.TabIndex = 7;
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.AutoSize = true;
            this.cmdDisconnect.Location = new System.Drawing.Point(362, 4);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(91, 23);
            this.cmdDisconnect.TabIndex = 1;
            this.cmdDisconnect.Text = "cmdDisconnect";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            this.cmdDisconnect.Click += new System.EventHandler(this.CmdConnect_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.AutoSize = true;
            this.cmdConnect.Location = new System.Drawing.Point(94, 7);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(77, 23);
            this.cmdConnect.TabIndex = 0;
            this.cmdConnect.Text = "cmdConnect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.CmdConnect_Click);
            // 
            // lblSend
            // 
            this.lblSend.BackColor = System.Drawing.SystemColors.Info;
            this.lblSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSend.Location = new System.Drawing.Point(0, 139);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(800, 25);
            this.lblSend.TabIndex = 8;
            this.lblSend.Text = "lblSend";
            this.lblSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panSend
            // 
            this.panSend.Controls.Add(this.txtSend);
            this.panSend.Controls.Add(this.cmdSend);
            this.panSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSend.Location = new System.Drawing.Point(0, 164);
            this.panSend.Name = "panSend";
            this.panSend.Padding = new System.Windows.Forms.Padding(3);
            this.panSend.Size = new System.Drawing.Size(800, 50);
            this.panSend.TabIndex = 9;
            // 
            // txtSend
            // 
            this.txtSend.AcceptsReturn = true;
            this.txtSend.AcceptsTab = true;
            this.txtSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSend.Location = new System.Drawing.Point(3, 3);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSend.Size = new System.Drawing.Size(697, 44);
            this.txtSend.TabIndex = 5;
            // 
            // cmdSend
            // 
            this.cmdSend.AutoSize = true;
            this.cmdSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdSend.Location = new System.Drawing.Point(700, 3);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(97, 44);
            this.cmdSend.TabIndex = 4;
            this.cmdSend.Text = "cmdSend";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.CmdSend_Click);
            // 
            // lblMessageLog
            // 
            this.lblMessageLog.BackColor = System.Drawing.SystemColors.Info;
            this.lblMessageLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessageLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageLog.Location = new System.Drawing.Point(0, 214);
            this.lblMessageLog.Name = "lblMessageLog";
            this.lblMessageLog.Size = new System.Drawing.Size(800, 25);
            this.lblMessageLog.TabIndex = 10;
            this.lblMessageLog.Text = "lblMessageLog";
            this.lblMessageLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 239);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(800, 189);
            this.txtLog.TabIndex = 11;
            this.txtLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WebSocket Example";
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
        private System.Windows.Forms.Label lblUrl;
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

