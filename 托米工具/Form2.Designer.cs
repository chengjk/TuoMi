namespace 托米工具
{
    partial class Form2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择字典ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建字典表CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.如何使用UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.grpDict = new System.Windows.Forms.GroupBox();
            this.grpDir = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.AllowDrop = true;
            this.btnTest.Location = new System.Drawing.Point(316, 86);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(101, 65);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Go！";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sdfToolStripMenuItem
            // 
            this.sdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择字典ToolStripMenuItem,
            this.选择目录ToolStripMenuItem,
            this.退出QToolStripMenuItem});
            this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            this.sdfToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.sdfToolStripMenuItem.Text = "文件(&F)";
            // 
            // 选择字典ToolStripMenuItem
            // 
            this.选择字典ToolStripMenuItem.Name = "选择字典ToolStripMenuItem";
            this.选择字典ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.选择字典ToolStripMenuItem.Text = "选择字典(&O)";
            this.选择字典ToolStripMenuItem.Click += new System.EventHandler(this.选择字典ToolStripMenuItem_Click);
            // 
            // 选择目录ToolStripMenuItem
            // 
            this.选择目录ToolStripMenuItem.Name = "选择目录ToolStripMenuItem";
            this.选择目录ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.选择目录ToolStripMenuItem.Text = "选择目录(&D)";
            this.选择目录ToolStripMenuItem.Click += new System.EventHandler(this.选择目录ToolStripMenuItem_Click);
            // 
            // 退出QToolStripMenuItem
            // 
            this.退出QToolStripMenuItem.Name = "退出QToolStripMenuItem";
            this.退出QToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.退出QToolStripMenuItem.Text = "退出(&Q)";
            this.退出QToolStripMenuItem.Click += new System.EventHandler(this.退出QToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建字典表CToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 新建字典表CToolStripMenuItem
            // 
            this.新建字典表CToolStripMenuItem.Name = "新建字典表CToolStripMenuItem";
            this.新建字典表CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建字典表CToolStripMenuItem.Text = "新建字典表(&C)";
            this.新建字典表CToolStripMenuItem.Click += new System.EventHandler(this.新建字典表CToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.如何使用UToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 如何使用UToolStripMenuItem
            // 
            this.如何使用UToolStripMenuItem.Name = "如何使用UToolStripMenuItem";
            this.如何使用UToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.如何使用UToolStripMenuItem.Text = "如何使用（&U）";
            this.如何使用UToolStripMenuItem.Click += new System.EventHandler(this.如何使用UToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.关于AToolStripMenuItem.Text = "关于托米(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Location = new System.Drawing.Point(316, 59);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(60, 16);
            this.chkReverse.TabIndex = 9;
            this.chkReverse.Text = "反托米";
            this.chkReverse.UseVisualStyleBackColor = true;
            // 
            // grpDict
            // 
            this.grpDict.AllowDrop = true;
            this.grpDict.BackgroundImage = global::托米工具.Properties.Resources.tm0;
            this.grpDict.Location = new System.Drawing.Point(165, 35);
            this.grpDict.Name = "grpDict";
            this.grpDict.Size = new System.Drawing.Size(108, 116);
            this.grpDict.TabIndex = 8;
            this.grpDict.TabStop = false;
            this.grpDict.DragDrop += new System.Windows.Forms.DragEventHandler(this.grpDict_DragDrop);
            this.grpDict.DragEnter += new System.Windows.Forms.DragEventHandler(this.grpDict_DragEnter);
            // 
            // grpDir
            // 
            this.grpDir.AllowDrop = true;
            this.grpDir.BackgroundImage = global::托米工具.Properties.Resources.fm0;
            this.grpDir.Location = new System.Drawing.Point(17, 35);
            this.grpDir.Name = "grpDir";
            this.grpDir.Size = new System.Drawing.Size(105, 116);
            this.grpDir.TabIndex = 7;
            this.grpDir.TabStop = false;
            this.grpDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.grpDir_DragDrop);
            this.grpDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.grpDir_DragEnter);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(17, 157);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(400, 72);
            this.txtInfo.TabIndex = 12;
            this.txtInfo.Text = "进度信息：请先备份数据！";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.chkReverse);
            this.Controls.Add(this.grpDict);
            this.Controls.Add(this.grpDir);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "托米工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择字典ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建字典表CToolStripMenuItem;
       
        private System.Windows.Forms.GroupBox grpDir;
        private System.Windows.Forms.GroupBox grpDict;
        private System.Windows.Forms.ToolStripMenuItem 如何使用UToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.RichTextBox txtInfo;
    }
}

