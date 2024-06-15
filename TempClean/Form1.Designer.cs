namespace TempClean
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNrmlCln = new System.Windows.Forms.Button();
            this.btnMnlCln = new System.Windows.Forms.Button();
            this.chkDpCln = new System.Windows.Forms.CheckBox();
            this.chk3rdCln = new System.Windows.Forms.CheckBox();
            this.chkMemDmpCln = new System.Windows.Forms.CheckBox();
            this.lblFreSpc = new System.Windows.Forms.Label();
            this.PBMain = new System.Windows.Forms.ProgressBar();
            this.lblAbt3rd = new System.Windows.Forms.Label();
            this.lblAbtMemDmp = new System.Windows.Forms.Label();
            this.pnlMnlCln = new System.Windows.Forms.Panel();
            this.chkminidump = new System.Windows.Forms.CheckBox();
            this.chkMemDMP = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkEdge = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.chkAcrobat = new System.Windows.Forms.CheckBox();
            this.chkOffice = new System.Windows.Forms.CheckBox();
            this.chkWinInstaller = new System.Windows.Forms.CheckBox();
            this.chkWinUpdates = new System.Windows.Forms.CheckBox();
            this.chkWinLogs = new System.Windows.Forms.CheckBox();
            this.chkPackageCache = new System.Windows.Forms.CheckBox();
            this.chkWinDefender = new System.Windows.Forms.CheckBox();
            this.chkINetCache = new System.Windows.Forms.CheckBox();
            this.chkPrefetch = new System.Windows.Forms.CheckBox();
            this.chkWebcache = new System.Windows.Forms.CheckBox();
            this.chkLocalTemp = new System.Windows.Forms.CheckBox();
            this.chkWinTemp = new System.Windows.Forms.CheckBox();
            this.pboxManual = new System.Windows.Forms.PictureBox();
            this.linklblCredits = new System.Windows.Forms.LinkLabel();
            this.linklblGithub = new System.Windows.Forms.LinkLabel();
            this.pbCredits = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pboxNormal = new System.Windows.Forms.PictureBox();
            this.toolTip3rdparty = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMemDmp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipWinTemp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLocalTemp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipWebcache = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPrefetch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipINetCache = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDefender = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPackageCache = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogs = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpdates = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInstaller = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOffice = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAcrobat = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipChrome = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEdge = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipJava = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMEMORYDMP = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipminidump = new System.Windows.Forms.ToolTip(this.components);
            this.btnClean = new System.Windows.Forms.Button();
            this.pnlMnlCln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNrmlCln
            // 
            this.btnNrmlCln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(100)))));
            this.btnNrmlCln.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(166)))));
            this.btnNrmlCln.FlatAppearance.BorderSize = 0;
            this.btnNrmlCln.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(100)))));
            this.btnNrmlCln.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(63)))));
            this.btnNrmlCln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNrmlCln.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNrmlCln.ForeColor = System.Drawing.Color.White;
            this.btnNrmlCln.Location = new System.Drawing.Point(0, 71);
            this.btnNrmlCln.Name = "btnNrmlCln";
            this.btnNrmlCln.Size = new System.Drawing.Size(255, 29);
            this.btnNrmlCln.TabIndex = 0;
            this.btnNrmlCln.Text = "Normal clean";
            this.btnNrmlCln.UseVisualStyleBackColor = false;
            this.btnNrmlCln.Click += new System.EventHandler(this.btnNrmlCln_Click);
            // 
            // btnMnlCln
            // 
            this.btnMnlCln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnMnlCln.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(166)))));
            this.btnMnlCln.FlatAppearance.BorderSize = 0;
            this.btnMnlCln.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(166)))));
            this.btnMnlCln.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(63)))));
            this.btnMnlCln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMnlCln.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMnlCln.ForeColor = System.Drawing.Color.White;
            this.btnMnlCln.Location = new System.Drawing.Point(0, 105);
            this.btnMnlCln.Name = "btnMnlCln";
            this.btnMnlCln.Size = new System.Drawing.Size(255, 29);
            this.btnMnlCln.TabIndex = 1;
            this.btnMnlCln.Text = "Manual clean";
            this.btnMnlCln.UseVisualStyleBackColor = false;
            this.btnMnlCln.Click += new System.EventHandler(this.btnMnlCln_Click);
            // 
            // chkDpCln
            // 
            this.chkDpCln.AutoSize = true;
            this.chkDpCln.BackColor = System.Drawing.Color.Transparent;
            this.chkDpCln.Location = new System.Drawing.Point(272, 62);
            this.chkDpCln.Name = "chkDpCln";
            this.chkDpCln.Size = new System.Drawing.Size(15, 14);
            this.chkDpCln.TabIndex = 2;
            this.chkDpCln.UseVisualStyleBackColor = false;
            // 
            // chk3rdCln
            // 
            this.chk3rdCln.AutoSize = true;
            this.chk3rdCln.BackColor = System.Drawing.Color.Transparent;
            this.chk3rdCln.Location = new System.Drawing.Point(402, 62);
            this.chk3rdCln.Name = "chk3rdCln";
            this.chk3rdCln.Size = new System.Drawing.Size(15, 14);
            this.chk3rdCln.TabIndex = 3;
            this.chk3rdCln.UseVisualStyleBackColor = false;
            // 
            // chkMemDmpCln
            // 
            this.chkMemDmpCln.AutoSize = true;
            this.chkMemDmpCln.BackColor = System.Drawing.Color.Transparent;
            this.chkMemDmpCln.Location = new System.Drawing.Point(583, 62);
            this.chkMemDmpCln.Name = "chkMemDmpCln";
            this.chkMemDmpCln.Size = new System.Drawing.Size(15, 14);
            this.chkMemDmpCln.TabIndex = 4;
            this.chkMemDmpCln.UseVisualStyleBackColor = false;
            // 
            // lblFreSpc
            // 
            this.lblFreSpc.AutoSize = true;
            this.lblFreSpc.BackColor = System.Drawing.Color.Transparent;
            this.lblFreSpc.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreSpc.ForeColor = System.Drawing.Color.White;
            this.lblFreSpc.Location = new System.Drawing.Point(429, 203);
            this.lblFreSpc.Name = "lblFreSpc";
            this.lblFreSpc.Size = new System.Drawing.Size(158, 25);
            this.lblFreSpc.TabIndex = 6;
            this.lblFreSpc.Text = "Selected: 1,04 GB";
            this.lblFreSpc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PBMain
            // 
            this.PBMain.Location = new System.Drawing.Point(315, 323);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(401, 23);
            this.PBMain.TabIndex = 7;
            // 
            // lblAbt3rd
            // 
            this.lblAbt3rd.AutoSize = true;
            this.lblAbt3rd.BackColor = System.Drawing.Color.Transparent;
            this.lblAbt3rd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbt3rd.ForeColor = System.Drawing.Color.Cyan;
            this.lblAbt3rd.Location = new System.Drawing.Point(388, 59);
            this.lblAbt3rd.Name = "lblAbt3rd";
            this.lblAbt3rd.Size = new System.Drawing.Size(14, 17);
            this.lblAbt3rd.TabIndex = 8;
            this.lblAbt3rd.Text = "?";
            // 
            // lblAbtMemDmp
            // 
            this.lblAbtMemDmp.AutoSize = true;
            this.lblAbtMemDmp.BackColor = System.Drawing.Color.Transparent;
            this.lblAbtMemDmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbtMemDmp.ForeColor = System.Drawing.Color.Cyan;
            this.lblAbtMemDmp.Location = new System.Drawing.Point(569, 59);
            this.lblAbtMemDmp.Name = "lblAbtMemDmp";
            this.lblAbtMemDmp.Size = new System.Drawing.Size(14, 17);
            this.lblAbtMemDmp.TabIndex = 9;
            this.lblAbtMemDmp.Text = "?";
            // 
            // pnlMnlCln
            // 
            this.pnlMnlCln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlMnlCln.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMnlCln.Controls.Add(this.chkminidump);
            this.pnlMnlCln.Controls.Add(this.chkMemDMP);
            this.pnlMnlCln.Controls.Add(this.chkJava);
            this.pnlMnlCln.Controls.Add(this.chkEdge);
            this.pnlMnlCln.Controls.Add(this.chkChrome);
            this.pnlMnlCln.Controls.Add(this.chkAcrobat);
            this.pnlMnlCln.Controls.Add(this.chkOffice);
            this.pnlMnlCln.Controls.Add(this.chkWinInstaller);
            this.pnlMnlCln.Controls.Add(this.chkWinUpdates);
            this.pnlMnlCln.Controls.Add(this.chkWinLogs);
            this.pnlMnlCln.Controls.Add(this.chkPackageCache);
            this.pnlMnlCln.Controls.Add(this.chkWinDefender);
            this.pnlMnlCln.Controls.Add(this.chkINetCache);
            this.pnlMnlCln.Controls.Add(this.chkPrefetch);
            this.pnlMnlCln.Controls.Add(this.chkWebcache);
            this.pnlMnlCln.Controls.Add(this.chkLocalTemp);
            this.pnlMnlCln.Controls.Add(this.chkWinTemp);
            this.pnlMnlCln.Controls.Add(this.pboxManual);
            this.pnlMnlCln.Location = new System.Drawing.Point(260, 0);
            this.pnlMnlCln.Name = "pnlMnlCln";
            this.pnlMnlCln.Size = new System.Drawing.Size(513, 198);
            this.pnlMnlCln.TabIndex = 10;
            this.pnlMnlCln.Visible = false;
            // 
            // chkminidump
            // 
            this.chkminidump.AutoSize = true;
            this.chkminidump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkminidump.Location = new System.Drawing.Point(397, 158);
            this.chkminidump.Name = "chkminidump";
            this.chkminidump.Size = new System.Drawing.Size(15, 14);
            this.chkminidump.TabIndex = 19;
            this.chkminidump.UseVisualStyleBackColor = false;
            // 
            // chkMemDMP
            // 
            this.chkMemDMP.AutoSize = true;
            this.chkMemDMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkMemDMP.Location = new System.Drawing.Point(11, 158);
            this.chkMemDMP.Name = "chkMemDMP";
            this.chkMemDMP.Size = new System.Drawing.Size(15, 14);
            this.chkMemDMP.TabIndex = 15;
            this.chkMemDMP.UseVisualStyleBackColor = false;
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkJava.Location = new System.Drawing.Point(397, 126);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(15, 14);
            this.chkJava.TabIndex = 14;
            this.chkJava.UseVisualStyleBackColor = false;
            // 
            // chkEdge
            // 
            this.chkEdge.AutoSize = true;
            this.chkEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkEdge.Location = new System.Drawing.Point(319, 126);
            this.chkEdge.Name = "chkEdge";
            this.chkEdge.Size = new System.Drawing.Size(15, 14);
            this.chkEdge.TabIndex = 13;
            this.chkEdge.UseVisualStyleBackColor = false;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkChrome.Location = new System.Drawing.Point(228, 126);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(15, 14);
            this.chkChrome.TabIndex = 12;
            this.chkChrome.UseVisualStyleBackColor = false;
            // 
            // chkAcrobat
            // 
            this.chkAcrobat.AutoSize = true;
            this.chkAcrobat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkAcrobat.Location = new System.Drawing.Point(132, 126);
            this.chkAcrobat.Name = "chkAcrobat";
            this.chkAcrobat.Size = new System.Drawing.Size(15, 14);
            this.chkAcrobat.TabIndex = 11;
            this.chkAcrobat.UseVisualStyleBackColor = false;
            // 
            // chkOffice
            // 
            this.chkOffice.AutoSize = true;
            this.chkOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkOffice.Location = new System.Drawing.Point(11, 126);
            this.chkOffice.Name = "chkOffice";
            this.chkOffice.Size = new System.Drawing.Size(15, 14);
            this.chkOffice.TabIndex = 10;
            this.chkOffice.UseVisualStyleBackColor = false;
            // 
            // chkWinInstaller
            // 
            this.chkWinInstaller.AutoSize = true;
            this.chkWinInstaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkWinInstaller.Location = new System.Drawing.Point(397, 94);
            this.chkWinInstaller.Name = "chkWinInstaller";
            this.chkWinInstaller.Size = new System.Drawing.Size(15, 14);
            this.chkWinInstaller.TabIndex = 9;
            this.chkWinInstaller.UseVisualStyleBackColor = false;
            // 
            // chkWinUpdates
            // 
            this.chkWinUpdates.AutoSize = true;
            this.chkWinUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkWinUpdates.Location = new System.Drawing.Point(319, 94);
            this.chkWinUpdates.Name = "chkWinUpdates";
            this.chkWinUpdates.Size = new System.Drawing.Size(15, 14);
            this.chkWinUpdates.TabIndex = 8;
            this.chkWinUpdates.UseVisualStyleBackColor = false;
            // 
            // chkWinLogs
            // 
            this.chkWinLogs.AutoSize = true;
            this.chkWinLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkWinLogs.Location = new System.Drawing.Point(228, 94);
            this.chkWinLogs.Name = "chkWinLogs";
            this.chkWinLogs.Size = new System.Drawing.Size(15, 14);
            this.chkWinLogs.TabIndex = 7;
            this.chkWinLogs.UseVisualStyleBackColor = false;
            // 
            // chkPackageCache
            // 
            this.chkPackageCache.AutoSize = true;
            this.chkPackageCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkPackageCache.Location = new System.Drawing.Point(132, 94);
            this.chkPackageCache.Name = "chkPackageCache";
            this.chkPackageCache.Size = new System.Drawing.Size(15, 14);
            this.chkPackageCache.TabIndex = 6;
            this.chkPackageCache.UseVisualStyleBackColor = false;
            // 
            // chkWinDefender
            // 
            this.chkWinDefender.AutoSize = true;
            this.chkWinDefender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkWinDefender.Location = new System.Drawing.Point(11, 94);
            this.chkWinDefender.Name = "chkWinDefender";
            this.chkWinDefender.Size = new System.Drawing.Size(15, 14);
            this.chkWinDefender.TabIndex = 5;
            this.chkWinDefender.UseVisualStyleBackColor = false;
            // 
            // chkINetCache
            // 
            this.chkINetCache.AutoSize = true;
            this.chkINetCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkINetCache.Location = new System.Drawing.Point(397, 62);
            this.chkINetCache.Name = "chkINetCache";
            this.chkINetCache.Size = new System.Drawing.Size(15, 14);
            this.chkINetCache.TabIndex = 4;
            this.chkINetCache.UseVisualStyleBackColor = false;
            // 
            // chkPrefetch
            // 
            this.chkPrefetch.AutoSize = true;
            this.chkPrefetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkPrefetch.Location = new System.Drawing.Point(319, 62);
            this.chkPrefetch.Name = "chkPrefetch";
            this.chkPrefetch.Size = new System.Drawing.Size(15, 14);
            this.chkPrefetch.TabIndex = 3;
            this.chkPrefetch.UseVisualStyleBackColor = false;
            // 
            // chkWebcache
            // 
            this.chkWebcache.AutoSize = true;
            this.chkWebcache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkWebcache.Location = new System.Drawing.Point(228, 62);
            this.chkWebcache.Name = "chkWebcache";
            this.chkWebcache.Size = new System.Drawing.Size(15, 14);
            this.chkWebcache.TabIndex = 2;
            this.chkWebcache.UseVisualStyleBackColor = false;
            // 
            // chkLocalTemp
            // 
            this.chkLocalTemp.AutoSize = true;
            this.chkLocalTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkLocalTemp.Location = new System.Drawing.Point(132, 62);
            this.chkLocalTemp.Name = "chkLocalTemp";
            this.chkLocalTemp.Size = new System.Drawing.Size(15, 14);
            this.chkLocalTemp.TabIndex = 1;
            this.chkLocalTemp.UseVisualStyleBackColor = false;
            // 
            // chkWinTemp
            // 
            this.chkWinTemp.AutoSize = true;
            this.chkWinTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.chkWinTemp.Location = new System.Drawing.Point(11, 62);
            this.chkWinTemp.Name = "chkWinTemp";
            this.chkWinTemp.Size = new System.Drawing.Size(15, 14);
            this.chkWinTemp.TabIndex = 0;
            this.chkWinTemp.UseVisualStyleBackColor = false;
            // 
            // pboxManual
            // 
            this.pboxManual.Image = global::TempClean.Properties.Resources.tc3;
            this.pboxManual.Location = new System.Drawing.Point(0, 0);
            this.pboxManual.Name = "pboxManual";
            this.pboxManual.Size = new System.Drawing.Size(492, 198);
            this.pboxManual.TabIndex = 20;
            this.pboxManual.TabStop = false;
            // 
            // linklblCredits
            // 
            this.linklblCredits.ActiveLinkColor = System.Drawing.Color.Red;
            this.linklblCredits.AutoSize = true;
            this.linklblCredits.BackColor = System.Drawing.Color.Transparent;
            this.linklblCredits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblCredits.LinkColor = System.Drawing.Color.White;
            this.linklblCredits.Location = new System.Drawing.Point(2, 339);
            this.linklblCredits.Name = "linklblCredits";
            this.linklblCredits.Size = new System.Drawing.Size(49, 17);
            this.linklblCredits.TabIndex = 12;
            this.linklblCredits.TabStop = true;
            this.linklblCredits.Text = "Credits";
            this.linklblCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCredits_LinkClicked);
            // 
            // linklblGithub
            // 
            this.linklblGithub.AutoSize = true;
            this.linklblGithub.BackColor = System.Drawing.Color.Transparent;
            this.linklblGithub.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblGithub.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linklblGithub.Location = new System.Drawing.Point(102, 339);
            this.linklblGithub.Name = "linklblGithub";
            this.linklblGithub.Size = new System.Drawing.Size(49, 17);
            this.linklblGithub.TabIndex = 13;
            this.linklblGithub.TabStop = true;
            this.linklblGithub.Text = "Github";
            this.linklblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblGithub_LinkClicked);
            // 
            // pbCredits
            // 
            this.pbCredits.BackgroundImage = global::TempClean.Properties.Resources.tc4;
            this.pbCredits.Location = new System.Drawing.Point(260, 0);
            this.pbCredits.Name = "pbCredits";
            this.pbCredits.Size = new System.Drawing.Size(513, 360);
            this.pbCredits.TabIndex = 14;
            this.pbCredits.TabStop = false;
            this.pbCredits.Visible = false;
            // 
            // pboxNormal
            // 
            this.pboxNormal.Image = global::TempClean.Properties.Resources.tc2;
            this.pboxNormal.Location = new System.Drawing.Point(260, 0);
            this.pboxNormal.Name = "pboxNormal";
            this.pboxNormal.Size = new System.Drawing.Size(513, 317);
            this.pboxNormal.TabIndex = 15;
            this.pboxNormal.TabStop = false;
            // 
            // toolTip3rdparty
            // 
            this.toolTip3rdparty.IsBalloon = true;
            this.toolTip3rdparty.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3rdparty.ToolTipTitle = "About 3rd party clean";
            // 
            // toolTipMemDmp
            // 
            this.toolTipMemDmp.IsBalloon = true;
            this.toolTipMemDmp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMemDmp.ToolTipTitle = "About memory dumps clean";
            // 
            // toolTipWinTemp
            // 
            this.toolTipWinTemp.IsBalloon = true;
            // 
            // toolTipLocalTemp
            // 
            this.toolTipLocalTemp.IsBalloon = true;
            // 
            // toolTipWebcache
            // 
            this.toolTipWebcache.IsBalloon = true;
            // 
            // toolTipPrefetch
            // 
            this.toolTipPrefetch.IsBalloon = true;
            // 
            // toolTipINetCache
            // 
            this.toolTipINetCache.IsBalloon = true;
            // 
            // toolTipDefender
            // 
            this.toolTipDefender.IsBalloon = true;
            // 
            // toolTipPackageCache
            // 
            this.toolTipPackageCache.IsBalloon = true;
            // 
            // toolTipLogs
            // 
            this.toolTipLogs.IsBalloon = true;
            // 
            // toolTipUpdates
            // 
            this.toolTipUpdates.IsBalloon = true;
            // 
            // toolTipInstaller
            // 
            this.toolTipInstaller.IsBalloon = true;
            // 
            // toolTipOffice
            // 
            this.toolTipOffice.IsBalloon = true;
            // 
            // toolTipAcrobat
            // 
            this.toolTipAcrobat.IsBalloon = true;
            // 
            // toolTipChrome
            // 
            this.toolTipChrome.IsBalloon = true;
            // 
            // toolTipEdge
            // 
            this.toolTipEdge.IsBalloon = true;
            // 
            // toolTipJava
            // 
            this.toolTipJava.IsBalloon = true;
            // 
            // toolTipMEMORYDMP
            // 
            this.toolTipMEMORYDMP.IsBalloon = true;
            // 
            // toolTipminidump
            // 
            this.toolTipminidump.IsBalloon = true;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.Black;
            this.btnClean.Location = new System.Drawing.Point(439, 246);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(153, 56);
            this.btnClean.TabIndex = 17;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::TempClean.Properties.Resources.tc1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(773, 360);
            this.Controls.Add(this.pbCredits);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lblFreSpc);
            this.Controls.Add(this.pnlMnlCln);
            this.Controls.Add(this.linklblGithub);
            this.Controls.Add(this.linklblCredits);
            this.Controls.Add(this.PBMain);
            this.Controls.Add(this.btnMnlCln);
            this.Controls.Add(this.btnNrmlCln);
            this.Controls.Add(this.chk3rdCln);
            this.Controls.Add(this.lblAbt3rd);
            this.Controls.Add(this.chkMemDmpCln);
            this.Controls.Add(this.chkDpCln);
            this.Controls.Add(this.lblAbtMemDmp);
            this.Controls.Add(this.pboxNormal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexsitt TempClean";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMnlCln.ResumeLayout(false);
            this.pnlMnlCln.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNormal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNrmlCln;
        private System.Windows.Forms.Button btnMnlCln;
        private System.Windows.Forms.CheckBox chkDpCln;
        private System.Windows.Forms.CheckBox chk3rdCln;
        private System.Windows.Forms.CheckBox chkMemDmpCln;
        private System.Windows.Forms.Label lblFreSpc;
        private System.Windows.Forms.ProgressBar PBMain;
        private System.Windows.Forms.Label lblAbt3rd;
        private System.Windows.Forms.Label lblAbtMemDmp;
        private System.Windows.Forms.Panel pnlMnlCln;
        private System.Windows.Forms.CheckBox chkLocalTemp;
        private System.Windows.Forms.CheckBox chkWinTemp;
        private System.Windows.Forms.CheckBox chkminidump;
        private System.Windows.Forms.CheckBox chkMemDMP;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkEdge;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.CheckBox chkAcrobat;
        private System.Windows.Forms.CheckBox chkOffice;
        private System.Windows.Forms.CheckBox chkWinInstaller;
        private System.Windows.Forms.CheckBox chkWinUpdates;
        private System.Windows.Forms.CheckBox chkWinLogs;
        private System.Windows.Forms.CheckBox chkPackageCache;
        private System.Windows.Forms.CheckBox chkWinDefender;
        private System.Windows.Forms.CheckBox chkINetCache;
        private System.Windows.Forms.CheckBox chkPrefetch;
        private System.Windows.Forms.CheckBox chkWebcache;
        private System.Windows.Forms.LinkLabel linklblCredits;
        private System.Windows.Forms.LinkLabel linklblGithub;
        private System.Windows.Forms.PictureBox pbCredits;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pboxManual;
        private System.Windows.Forms.PictureBox pboxNormal;
        private System.Windows.Forms.ToolTip toolTip3rdparty;
        private System.Windows.Forms.ToolTip toolTipMemDmp;
        private System.Windows.Forms.ToolTip toolTipWinTemp;
        private System.Windows.Forms.ToolTip toolTipLocalTemp;
        private System.Windows.Forms.ToolTip toolTipWebcache;
        private System.Windows.Forms.ToolTip toolTipPrefetch;
        private System.Windows.Forms.ToolTip toolTipINetCache;
        private System.Windows.Forms.ToolTip toolTipDefender;
        private System.Windows.Forms.ToolTip toolTipPackageCache;
        private System.Windows.Forms.ToolTip toolTipLogs;
        private System.Windows.Forms.ToolTip toolTipUpdates;
        private System.Windows.Forms.ToolTip toolTipInstaller;
        private System.Windows.Forms.ToolTip toolTipOffice;
        private System.Windows.Forms.ToolTip toolTipAcrobat;
        private System.Windows.Forms.ToolTip toolTipChrome;
        private System.Windows.Forms.ToolTip toolTipEdge;
        private System.Windows.Forms.ToolTip toolTipJava;
        private System.Windows.Forms.ToolTip toolTipMEMORYDMP;
        private System.Windows.Forms.ToolTip toolTipminidump;
        private System.Windows.Forms.Button btnClean;
    }
}

