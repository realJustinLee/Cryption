namespace WindowsFormsApp1
{
    partial class Cryption
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.tabPagesModeSelect = new System.Windows.Forms.TabControl();
            this.tabPageCer = new System.Windows.Forms.TabPage();
            this.buttonCreatePfx = new System.Windows.Forms.Button();
            this.textBoxCnName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPathMakecret = new System.Windows.Forms.TextBox();
            this.buttonSelectMakecret = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExportCer = new System.Windows.Forms.Button();
            this.textBoxExportCerPath = new System.Windows.Forms.TextBox();
            this.buttonSetExportCerPath = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonExportPfx = new System.Windows.Forms.Button();
            this.textBoxExportKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxExportPfxPath = new System.Windows.Forms.TextBox();
            this.buttonSelectExportPfxPath = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageRSA = new System.Windows.Forms.TabPage();
            this.labelCerName = new System.Windows.Forms.Label();
            this.labelCerMD5 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonGetKeyPair = new System.Windows.Forms.Button();
            this.textBoxPfxKey = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxPfxPath = new System.Windows.Forms.TextBox();
            this.buttonSelectPfx = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonPubCrypt = new System.Windows.Forms.Button();
            this.buttonPrivDecry = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxPrivKey = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxPubKey = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPageMd5Des = new System.Windows.Forms.TabPage();
            this.MD5CheckResult = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonCheckMD5 = new System.Windows.Forms.Button();
            this.buttonImportToMD5 = new System.Windows.Forms.Button();
            this.textBoxImportedToMD5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMD5 = new System.Windows.Forms.TextBox();
            this.buttonMD5calc = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonDesDecode = new System.Windows.Forms.Button();
            this.textBoxImputDesPasswd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxSetDesPasswd = new System.Windows.Forms.TextBox();
            this.buttonDesEncode = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxCrypOrigin = new System.Windows.Forms.TextBox();
            this.textBoxCrypted = new System.Windows.Forms.TextBox();
            this.textBoxDecOrigin = new System.Windows.Forms.TextBox();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonSHA1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA256 = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA512 = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonSHA = new System.Windows.Forms.Button();
            this.tabPageAesSha = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.buttonAesDecode = new System.Windows.Forms.Button();
            this.textBoxImputAesPasswd = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxSetAesPasswd = new System.Windows.Forms.TextBox();
            this.buttonAesEncode = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPagesModeSelect.SuspendLayout();
            this.tabPageCer.SuspendLayout();
            this.tabPageRSA.SuspendLayout();
            this.tabPageMd5Des.SuspendLayout();
            this.tabPageAesSha.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.Color.Purple;
            this.Title.Location = new System.Drawing.Point(129, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(306, 41);
            this.Title.TabIndex = 3;
            this.Title.Text = "加密与解密算法测试";
            // 
            // tabPagesModeSelect
            // 
            this.tabPagesModeSelect.Controls.Add(this.tabPageCer);
            this.tabPagesModeSelect.Controls.Add(this.tabPageRSA);
            this.tabPagesModeSelect.Controls.Add(this.tabPageMd5Des);
            this.tabPagesModeSelect.Controls.Add(this.tabPageAesSha);
            this.tabPagesModeSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPagesModeSelect.Location = new System.Drawing.Point(132, 132);
            this.tabPagesModeSelect.Multiline = true;
            this.tabPagesModeSelect.Name = "tabPagesModeSelect";
            this.tabPagesModeSelect.SelectedIndex = 0;
            this.tabPagesModeSelect.Size = new System.Drawing.Size(438, 411);
            this.tabPagesModeSelect.TabIndex = 4;
            this.tabPagesModeSelect.Tag = "";
            // 
            // tabPageCer
            // 
            this.tabPageCer.Controls.Add(this.buttonCreatePfx);
            this.tabPageCer.Controls.Add(this.textBoxCnName);
            this.tabPageCer.Controls.Add(this.label9);
            this.tabPageCer.Controls.Add(this.textBoxPathMakecret);
            this.tabPageCer.Controls.Add(this.buttonSelectMakecret);
            this.tabPageCer.Controls.Add(this.label5);
            this.tabPageCer.Controls.Add(this.label8);
            this.tabPageCer.Controls.Add(this.buttonExportCer);
            this.tabPageCer.Controls.Add(this.textBoxExportCerPath);
            this.tabPageCer.Controls.Add(this.buttonSetExportCerPath);
            this.tabPageCer.Controls.Add(this.label12);
            this.tabPageCer.Controls.Add(this.buttonExportPfx);
            this.tabPageCer.Controls.Add(this.textBoxExportKey);
            this.tabPageCer.Controls.Add(this.label11);
            this.tabPageCer.Controls.Add(this.textBoxExportPfxPath);
            this.tabPageCer.Controls.Add(this.buttonSelectExportPfxPath);
            this.tabPageCer.Controls.Add(this.label7);
            this.tabPageCer.Controls.Add(this.label6);
            this.tabPageCer.Controls.Add(this.label10);
            this.tabPageCer.Location = new System.Drawing.Point(4, 30);
            this.tabPageCer.Name = "tabPageCer";
            this.tabPageCer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCer.Size = new System.Drawing.Size(430, 377);
            this.tabPageCer.TabIndex = 0;
            this.tabPageCer.Text = "创建证书";
            this.tabPageCer.UseVisualStyleBackColor = true;
            // 
            // buttonCreatePfx
            // 
            this.buttonCreatePfx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCreatePfx.Location = new System.Drawing.Point(337, 80);
            this.buttonCreatePfx.Name = "buttonCreatePfx";
            this.buttonCreatePfx.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePfx.TabIndex = 15;
            this.buttonCreatePfx.Text = "创建";
            this.buttonCreatePfx.UseVisualStyleBackColor = true;
            this.buttonCreatePfx.Click += new System.EventHandler(this.buttonCreatePfx_Click);
            // 
            // textBoxCnName
            // 
            this.textBoxCnName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCnName.Location = new System.Drawing.Point(156, 80);
            this.textBoxCnName.Name = "textBoxCnName";
            this.textBoxCnName.Size = new System.Drawing.Size(175, 23);
            this.textBoxCnName.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(69, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "设置证书签名：";
            // 
            // textBoxPathMakecret
            // 
            this.textBoxPathMakecret.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPathMakecret.Location = new System.Drawing.Point(156, 51);
            this.textBoxPathMakecret.Name = "textBoxPathMakecret";
            this.textBoxPathMakecret.Size = new System.Drawing.Size(175, 23);
            this.textBoxPathMakecret.TabIndex = 4;
            // 
            // buttonSelectMakecret
            // 
            this.buttonSelectMakecret.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectMakecret.Location = new System.Drawing.Point(337, 51);
            this.buttonSelectMakecret.Name = "buttonSelectMakecret";
            this.buttonSelectMakecret.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectMakecret.TabIndex = 3;
            this.buttonSelectMakecret.Text = "浏览";
            this.buttonSelectMakecret.UseVisualStyleBackColor = true;
            this.buttonSelectMakecret.Click += new System.EventHandler(this.buttonSelectMakecret_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(11, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "创建含有私钥的证书";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(38, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Makecret完整路径：";
            // 
            // buttonExportCer
            // 
            this.buttonExportCer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExportCer.Location = new System.Drawing.Point(337, 330);
            this.buttonExportCer.Name = "buttonExportCer";
            this.buttonExportCer.Size = new System.Drawing.Size(75, 23);
            this.buttonExportCer.TabIndex = 25;
            this.buttonExportCer.Text = "导出";
            this.buttonExportCer.UseVisualStyleBackColor = true;
            this.buttonExportCer.Click += new System.EventHandler(this.buttonExportCer_Click);
            // 
            // textBoxExportCerPath
            // 
            this.textBoxExportCerPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExportCerPath.Location = new System.Drawing.Point(156, 301);
            this.textBoxExportCerPath.Name = "textBoxExportCerPath";
            this.textBoxExportCerPath.Size = new System.Drawing.Size(175, 23);
            this.textBoxExportCerPath.TabIndex = 23;
            // 
            // buttonSetExportCerPath
            // 
            this.buttonSetExportCerPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSetExportCerPath.Location = new System.Drawing.Point(337, 301);
            this.buttonSetExportCerPath.Name = "buttonSetExportCerPath";
            this.buttonSetExportCerPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSetExportCerPath.TabIndex = 22;
            this.buttonSetExportCerPath.Text = "浏览";
            this.buttonSetExportCerPath.UseVisualStyleBackColor = true;
            this.buttonSetExportCerPath.Click += new System.EventHandler(this.buttonSetExportCerPath_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(93, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "导出路径：";
            // 
            // buttonExportPfx
            // 
            this.buttonExportPfx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExportPfx.Location = new System.Drawing.Point(337, 205);
            this.buttonExportPfx.Name = "buttonExportPfx";
            this.buttonExportPfx.Size = new System.Drawing.Size(75, 23);
            this.buttonExportPfx.TabIndex = 21;
            this.buttonExportPfx.Text = "导出";
            this.buttonExportPfx.UseVisualStyleBackColor = true;
            this.buttonExportPfx.Click += new System.EventHandler(this.buttonExportPfx_Click);
            // 
            // textBoxExportKey
            // 
            this.textBoxExportKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExportKey.Location = new System.Drawing.Point(156, 205);
            this.textBoxExportKey.Name = "textBoxExportKey";
            this.textBoxExportKey.Size = new System.Drawing.Size(175, 23);
            this.textBoxExportKey.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(52, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "设置Pfx文件密码：";
            // 
            // textBoxExportPfxPath
            // 
            this.textBoxExportPfxPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExportPfxPath.Location = new System.Drawing.Point(156, 176);
            this.textBoxExportPfxPath.Name = "textBoxExportPfxPath";
            this.textBoxExportPfxPath.Size = new System.Drawing.Size(175, 23);
            this.textBoxExportPfxPath.TabIndex = 17;
            // 
            // buttonSelectExportPfxPath
            // 
            this.buttonSelectExportPfxPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectExportPfxPath.Location = new System.Drawing.Point(337, 176);
            this.buttonSelectExportPfxPath.Name = "buttonSelectExportPfxPath";
            this.buttonSelectExportPfxPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectExportPfxPath.TabIndex = 16;
            this.buttonSelectExportPfxPath.Text = "浏览";
            this.buttonSelectExportPfxPath.UseVisualStyleBackColor = true;
            this.buttonSelectExportPfxPath.Click += new System.EventHandler(this.buttonSelectExportPfxPath_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(11, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "导出为CER文件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(11, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "导出为PFX文件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(93, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "导出路径：";
            // 
            // tabPageRSA
            // 
            this.tabPageRSA.Controls.Add(this.labelCerName);
            this.tabPageRSA.Controls.Add(this.labelCerMD5);
            this.tabPageRSA.Controls.Add(this.label27);
            this.tabPageRSA.Controls.Add(this.label20);
            this.tabPageRSA.Controls.Add(this.buttonGetKeyPair);
            this.tabPageRSA.Controls.Add(this.textBoxPfxKey);
            this.tabPageRSA.Controls.Add(this.label21);
            this.tabPageRSA.Controls.Add(this.textBoxPfxPath);
            this.tabPageRSA.Controls.Add(this.buttonSelectPfx);
            this.tabPageRSA.Controls.Add(this.label22);
            this.tabPageRSA.Controls.Add(this.buttonPubCrypt);
            this.tabPageRSA.Controls.Add(this.buttonPrivDecry);
            this.tabPageRSA.Controls.Add(this.label23);
            this.tabPageRSA.Controls.Add(this.textBoxPrivKey);
            this.tabPageRSA.Controls.Add(this.label24);
            this.tabPageRSA.Controls.Add(this.textBoxPubKey);
            this.tabPageRSA.Controls.Add(this.label25);
            this.tabPageRSA.Controls.Add(this.label26);
            this.tabPageRSA.Location = new System.Drawing.Point(4, 30);
            this.tabPageRSA.Name = "tabPageRSA";
            this.tabPageRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRSA.Size = new System.Drawing.Size(430, 377);
            this.tabPageRSA.TabIndex = 1;
            this.tabPageRSA.Text = "RSA加密";
            this.tabPageRSA.UseVisualStyleBackColor = true;
            // 
            // labelCerName
            // 
            this.labelCerName.AutoSize = true;
            this.labelCerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCerName.Location = new System.Drawing.Point(103, 168);
            this.labelCerName.Name = "labelCerName";
            this.labelCerName.Size = new System.Drawing.Size(32, 17);
            this.labelCerName.TabIndex = 53;
            this.labelCerName.Text = "未知";
            // 
            // labelCerMD5
            // 
            this.labelCerMD5.AutoSize = true;
            this.labelCerMD5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCerMD5.Location = new System.Drawing.Point(103, 146);
            this.labelCerMD5.Name = "labelCerMD5";
            this.labelCerMD5.Size = new System.Drawing.Size(32, 17);
            this.labelCerMD5.TabIndex = 52;
            this.labelCerMD5.Text = "未知";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(39, 168);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 17);
            this.label27.TabIndex = 51;
            this.label27.Text = "证书名称：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(35, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 17);
            this.label20.TabIndex = 50;
            this.label20.Text = "证书MD5：";
            // 
            // buttonGetKeyPair
            // 
            this.buttonGetKeyPair.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGetKeyPair.Location = new System.Drawing.Point(337, 80);
            this.buttonGetKeyPair.Name = "buttonGetKeyPair";
            this.buttonGetKeyPair.Size = new System.Drawing.Size(75, 23);
            this.buttonGetKeyPair.TabIndex = 43;
            this.buttonGetKeyPair.Text = "取密钥对";
            this.buttonGetKeyPair.UseVisualStyleBackColor = true;
            this.buttonGetKeyPair.Click += new System.EventHandler(this.buttonGetKeyPair_Click);
            // 
            // textBoxPfxKey
            // 
            this.textBoxPfxKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPfxKey.Location = new System.Drawing.Point(156, 80);
            this.textBoxPfxKey.Name = "textBoxPfxKey";
            this.textBoxPfxKey.Size = new System.Drawing.Size(175, 23);
            this.textBoxPfxKey.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(72, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 17);
            this.label21.TabIndex = 41;
            this.label21.Text = "PFX文件密码：";
            // 
            // textBoxPfxPath
            // 
            this.textBoxPfxPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPfxPath.Location = new System.Drawing.Point(156, 51);
            this.textBoxPfxPath.Name = "textBoxPfxPath";
            this.textBoxPfxPath.Size = new System.Drawing.Size(175, 23);
            this.textBoxPfxPath.TabIndex = 39;
            // 
            // buttonSelectPfx
            // 
            this.buttonSelectPfx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectPfx.Location = new System.Drawing.Point(337, 51);
            this.buttonSelectPfx.Name = "buttonSelectPfx";
            this.buttonSelectPfx.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPfx.TabIndex = 38;
            this.buttonSelectPfx.Text = "浏览";
            this.buttonSelectPfx.UseVisualStyleBackColor = true;
            this.buttonSelectPfx.Click += new System.EventHandler(this.buttonSelectPfx_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Purple;
            this.label22.Location = new System.Drawing.Point(11, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 21);
            this.label22.TabIndex = 36;
            this.label22.Text = "PFX文件的作用";
            // 
            // buttonPubCrypt
            // 
            this.buttonPubCrypt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPubCrypt.Location = new System.Drawing.Point(102, 344);
            this.buttonPubCrypt.Name = "buttonPubCrypt";
            this.buttonPubCrypt.Size = new System.Drawing.Size(150, 23);
            this.buttonPubCrypt.TabIndex = 44;
            this.buttonPubCrypt.Text = "使用公钥加密";
            this.buttonPubCrypt.UseVisualStyleBackColor = true;
            this.buttonPubCrypt.Click += new System.EventHandler(this.buttonPubCrypt_Click);
            // 
            // buttonPrivDecry
            // 
            this.buttonPrivDecry.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPrivDecry.Location = new System.Drawing.Point(262, 344);
            this.buttonPrivDecry.Name = "buttonPrivDecry";
            this.buttonPrivDecry.Size = new System.Drawing.Size(150, 23);
            this.buttonPrivDecry.TabIndex = 49;
            this.buttonPrivDecry.Text = "使用私钥解密";
            this.buttonPrivDecry.UseVisualStyleBackColor = true;
            this.buttonPrivDecry.Click += new System.EventHandler(this.buttonPrivDecry_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(93, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 17);
            this.label23.TabIndex = 40;
            this.label23.Text = "文件路径：";
            // 
            // textBoxPrivKey
            // 
            this.textBoxPrivKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPrivKey.Location = new System.Drawing.Point(102, 266);
            this.textBoxPrivKey.Multiline = true;
            this.textBoxPrivKey.Name = "textBoxPrivKey";
            this.textBoxPrivKey.Size = new System.Drawing.Size(310, 72);
            this.textBoxPrivKey.TabIndex = 48;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(63, 269);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 17);
            this.label24.TabIndex = 47;
            this.label24.Text = "私钥：";
            // 
            // textBoxPubKey
            // 
            this.textBoxPubKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPubKey.Location = new System.Drawing.Point(102, 188);
            this.textBoxPubKey.Multiline = true;
            this.textBoxPubKey.Name = "textBoxPubKey";
            this.textBoxPubKey.Size = new System.Drawing.Size(310, 72);
            this.textBoxPubKey.TabIndex = 45;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Purple;
            this.label25.Location = new System.Drawing.Point(11, 121);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 21);
            this.label25.TabIndex = 37;
            this.label25.Text = "公钥私钥加密";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(63, 191);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 17);
            this.label26.TabIndex = 46;
            this.label26.Text = "公钥：";
            // 
            // tabPageMd5Des
            // 
            this.tabPageMd5Des.Controls.Add(this.MD5CheckResult);
            this.tabPageMd5Des.Controls.Add(this.label19);
            this.tabPageMd5Des.Controls.Add(this.buttonCheckMD5);
            this.tabPageMd5Des.Controls.Add(this.buttonImportToMD5);
            this.tabPageMd5Des.Controls.Add(this.textBoxImportedToMD5);
            this.tabPageMd5Des.Controls.Add(this.label13);
            this.tabPageMd5Des.Controls.Add(this.textBoxMD5);
            this.tabPageMd5Des.Controls.Add(this.buttonMD5calc);
            this.tabPageMd5Des.Controls.Add(this.label14);
            this.tabPageMd5Des.Controls.Add(this.label15);
            this.tabPageMd5Des.Controls.Add(this.buttonDesDecode);
            this.tabPageMd5Des.Controls.Add(this.textBoxImputDesPasswd);
            this.tabPageMd5Des.Controls.Add(this.label16);
            this.tabPageMd5Des.Controls.Add(this.textBoxSetDesPasswd);
            this.tabPageMd5Des.Controls.Add(this.buttonDesEncode);
            this.tabPageMd5Des.Controls.Add(this.label17);
            this.tabPageMd5Des.Controls.Add(this.label18);
            this.tabPageMd5Des.Location = new System.Drawing.Point(4, 30);
            this.tabPageMd5Des.Name = "tabPageMd5Des";
            this.tabPageMd5Des.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMd5Des.Size = new System.Drawing.Size(430, 377);
            this.tabPageMd5Des.TabIndex = 2;
            this.tabPageMd5Des.Text = "MD5和DES";
            this.tabPageMd5Des.UseVisualStyleBackColor = true;
            // 
            // MD5CheckResult
            // 
            this.MD5CheckResult.AutoSize = true;
            this.MD5CheckResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MD5CheckResult.Location = new System.Drawing.Point(205, 188);
            this.MD5CheckResult.Name = "MD5CheckResult";
            this.MD5CheckResult.Size = new System.Drawing.Size(32, 17);
            this.MD5CheckResult.TabIndex = 38;
            this.MD5CheckResult.Text = "未知";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(54, 188);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 17);
            this.label19.TabIndex = 37;
            this.label19.Text = "验证结果：";
            // 
            // buttonCheckMD5
            // 
            this.buttonCheckMD5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCheckMD5.Location = new System.Drawing.Point(337, 185);
            this.buttonCheckMD5.Name = "buttonCheckMD5";
            this.buttonCheckMD5.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckMD5.TabIndex = 36;
            this.buttonCheckMD5.Text = "验证";
            this.buttonCheckMD5.UseVisualStyleBackColor = true;
            this.buttonCheckMD5.Click += new System.EventHandler(this.buttonCheckMD5_Click);
            // 
            // buttonImportToMD5
            // 
            this.buttonImportToMD5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonImportToMD5.Location = new System.Drawing.Point(337, 104);
            this.buttonImportToMD5.Name = "buttonImportToMD5";
            this.buttonImportToMD5.Size = new System.Drawing.Size(75, 23);
            this.buttonImportToMD5.TabIndex = 29;
            this.buttonImportToMD5.Text = "导入";
            this.buttonImportToMD5.UseVisualStyleBackColor = true;
            this.buttonImportToMD5.Click += new System.EventHandler(this.buttonImportToMD5_Click);
            // 
            // textBoxImportedToMD5
            // 
            this.textBoxImportedToMD5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxImportedToMD5.Location = new System.Drawing.Point(117, 104);
            this.textBoxImportedToMD5.Multiline = true;
            this.textBoxImportedToMD5.Name = "textBoxImportedToMD5";
            this.textBoxImportedToMD5.Size = new System.Drawing.Size(214, 75);
            this.textBoxImportedToMD5.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(54, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "验证文本：";
            // 
            // textBoxMD5
            // 
            this.textBoxMD5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMD5.Location = new System.Drawing.Point(117, 51);
            this.textBoxMD5.Multiline = true;
            this.textBoxMD5.Name = "textBoxMD5";
            this.textBoxMD5.Size = new System.Drawing.Size(214, 47);
            this.textBoxMD5.TabIndex = 25;
            // 
            // buttonMD5calc
            // 
            this.buttonMD5calc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMD5calc.Location = new System.Drawing.Point(337, 51);
            this.buttonMD5calc.Name = "buttonMD5calc";
            this.buttonMD5calc.Size = new System.Drawing.Size(75, 23);
            this.buttonMD5calc.TabIndex = 24;
            this.buttonMD5calc.Text = "计算";
            this.buttonMD5calc.UseVisualStyleBackColor = true;
            this.buttonMD5calc.Click += new System.EventHandler(this.buttonMD5calc_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(11, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 21);
            this.label14.TabIndex = 22;
            this.label14.Text = "MD5算法测试";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(62, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "MD5值：";
            // 
            // buttonDesDecode
            // 
            this.buttonDesDecode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDesDecode.Location = new System.Drawing.Point(337, 310);
            this.buttonDesDecode.Name = "buttonDesDecode";
            this.buttonDesDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDesDecode.TabIndex = 35;
            this.buttonDesDecode.Text = "解密";
            this.buttonDesDecode.UseVisualStyleBackColor = true;
            this.buttonDesDecode.Click += new System.EventHandler(this.buttonDesDecode_Click);
            // 
            // textBoxImputDesPasswd
            // 
            this.textBoxImputDesPasswd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxImputDesPasswd.Location = new System.Drawing.Point(117, 310);
            this.textBoxImputDesPasswd.Name = "textBoxImputDesPasswd";
            this.textBoxImputDesPasswd.Size = new System.Drawing.Size(214, 23);
            this.textBoxImputDesPasswd.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(54, 313);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "输入密码：";
            // 
            // textBoxSetDesPasswd
            // 
            this.textBoxSetDesPasswd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSetDesPasswd.Location = new System.Drawing.Point(117, 281);
            this.textBoxSetDesPasswd.Name = "textBoxSetDesPasswd";
            this.textBoxSetDesPasswd.Size = new System.Drawing.Size(214, 23);
            this.textBoxSetDesPasswd.TabIndex = 31;
            // 
            // buttonDesEncode
            // 
            this.buttonDesEncode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDesEncode.Location = new System.Drawing.Point(337, 281);
            this.buttonDesEncode.Name = "buttonDesEncode";
            this.buttonDesEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonDesEncode.TabIndex = 30;
            this.buttonDesEncode.Text = "加密";
            this.buttonDesEncode.UseVisualStyleBackColor = true;
            this.buttonDesEncode.Click += new System.EventHandler(this.buttonDesEncode_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Purple;
            this.label17.Location = new System.Drawing.Point(11, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 21);
            this.label17.TabIndex = 23;
            this.label17.Text = "DES算法测试";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(54, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "设置密码：";
            // 
            // textBoxCrypOrigin
            // 
            this.textBoxCrypOrigin.Location = new System.Drawing.Point(605, 162);
            this.textBoxCrypOrigin.Multiline = true;
            this.textBoxCrypOrigin.Name = "textBoxCrypOrigin";
            this.textBoxCrypOrigin.Size = new System.Drawing.Size(434, 78);
            this.textBoxCrypOrigin.TabIndex = 0;
            // 
            // textBoxCrypted
            // 
            this.textBoxCrypted.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxCrypted.Enabled = false;
            this.textBoxCrypted.Location = new System.Drawing.Point(605, 263);
            this.textBoxCrypted.Multiline = true;
            this.textBoxCrypted.Name = "textBoxCrypted";
            this.textBoxCrypted.Size = new System.Drawing.Size(434, 78);
            this.textBoxCrypted.TabIndex = 5;
            this.textBoxCrypted.TextChanged += new System.EventHandler(this.textBoxCrypted_TextChanged);
            // 
            // textBoxDecOrigin
            // 
            this.textBoxDecOrigin.Location = new System.Drawing.Point(605, 364);
            this.textBoxDecOrigin.Multiline = true;
            this.textBoxDecOrigin.Name = "textBoxDecOrigin";
            this.textBoxDecOrigin.Size = new System.Drawing.Size(434, 78);
            this.textBoxDecOrigin.TabIndex = 6;
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxDecrypted.Enabled = false;
            this.textBoxDecrypted.Location = new System.Drawing.Point(605, 465);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(434, 78);
            this.textBoxDecrypted.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "待加密文本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "加密后的文本";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "待解密/认证文本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "解密/认证后的文本";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(964, 136);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "清空数据";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonSHA1
            // 
            this.radioButtonSHA1.AutoSize = true;
            this.radioButtonSHA1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSHA1.Location = new System.Drawing.Point(57, 177);
            this.radioButtonSHA1.Name = "radioButtonSHA1";
            this.radioButtonSHA1.Size = new System.Drawing.Size(57, 21);
            this.radioButtonSHA1.TabIndex = 0;
            this.radioButtonSHA1.TabStop = true;
            this.radioButtonSHA1.Text = "SHA1";
            this.radioButtonSHA1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSHA256
            // 
            this.radioButtonSHA256.AutoSize = true;
            this.radioButtonSHA256.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSHA256.Location = new System.Drawing.Point(142, 177);
            this.radioButtonSHA256.Name = "radioButtonSHA256";
            this.radioButtonSHA256.Size = new System.Drawing.Size(71, 21);
            this.radioButtonSHA256.TabIndex = 1;
            this.radioButtonSHA256.TabStop = true;
            this.radioButtonSHA256.Text = "SHA256";
            this.radioButtonSHA256.UseVisualStyleBackColor = true;
            // 
            // radioButtonSHA512
            // 
            this.radioButtonSHA512.AutoSize = true;
            this.radioButtonSHA512.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSHA512.Location = new System.Drawing.Point(243, 177);
            this.radioButtonSHA512.Name = "radioButtonSHA512";
            this.radioButtonSHA512.Size = new System.Drawing.Size(71, 21);
            this.radioButtonSHA512.TabIndex = 2;
            this.radioButtonSHA512.TabStop = true;
            this.radioButtonSHA512.Text = "SHA512";
            this.radioButtonSHA512.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Purple;
            this.label28.Location = new System.Drawing.Point(11, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 21);
            this.label28.TabIndex = 3;
            // 
            // buttonSHA
            // 
            this.buttonSHA.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSHA.Location = new System.Drawing.Point(337, 175);
            this.buttonSHA.Name = "buttonSHA";
            this.buttonSHA.Size = new System.Drawing.Size(75, 23);
            this.buttonSHA.TabIndex = 4;
            this.buttonSHA.Text = " 加密";
            this.buttonSHA.UseVisualStyleBackColor = true;
            this.buttonSHA.Click += new System.EventHandler(this.buttonSHA_Click);
            // 
            // tabPageAesSha
            // 
            this.tabPageAesSha.Controls.Add(this.buttonAesDecode);
            this.tabPageAesSha.Controls.Add(this.textBoxImputAesPasswd);
            this.tabPageAesSha.Controls.Add(this.label33);
            this.tabPageAesSha.Controls.Add(this.textBoxSetAesPasswd);
            this.tabPageAesSha.Controls.Add(this.buttonAesEncode);
            this.tabPageAesSha.Controls.Add(this.label34);
            this.tabPageAesSha.Controls.Add(this.label30);
            this.tabPageAesSha.Controls.Add(this.label29);
            this.tabPageAesSha.Controls.Add(this.buttonSHA);
            this.tabPageAesSha.Controls.Add(this.label28);
            this.tabPageAesSha.Controls.Add(this.radioButtonSHA512);
            this.tabPageAesSha.Controls.Add(this.radioButtonSHA256);
            this.tabPageAesSha.Controls.Add(this.radioButtonSHA1);
            this.tabPageAesSha.Location = new System.Drawing.Point(4, 30);
            this.tabPageAesSha.Name = "tabPageAesSha";
            this.tabPageAesSha.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAesSha.Size = new System.Drawing.Size(430, 377);
            this.tabPageAesSha.TabIndex = 4;
            this.tabPageAesSha.Text = "AES和SHA";
            this.tabPageAesSha.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Purple;
            this.label29.Location = new System.Drawing.Point(11, 140);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(106, 21);
            this.label29.TabIndex = 24;
            this.label29.Text = "SHA算法测试";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Purple;
            this.label30.Location = new System.Drawing.Point(11, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(103, 21);
            this.label30.TabIndex = 25;
            this.label30.Text = "AES算法测试";
            // 
            // buttonAesDecode
            // 
            this.buttonAesDecode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAesDecode.Location = new System.Drawing.Point(337, 76);
            this.buttonAesDecode.Name = "buttonAesDecode";
            this.buttonAesDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonAesDecode.TabIndex = 41;
            this.buttonAesDecode.Text = "解密";
            this.buttonAesDecode.UseVisualStyleBackColor = true;
            this.buttonAesDecode.Click += new System.EventHandler(this.buttonAesDecode_Click);
            // 
            // textBoxImputAesPasswd
            // 
            this.textBoxImputAesPasswd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxImputAesPasswd.Location = new System.Drawing.Point(117, 76);
            this.textBoxImputAesPasswd.Name = "textBoxImputAesPasswd";
            this.textBoxImputAesPasswd.Size = new System.Drawing.Size(214, 23);
            this.textBoxImputAesPasswd.TabIndex = 40;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(54, 79);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 17);
            this.label33.TabIndex = 39;
            this.label33.Text = "输入密码：";
            // 
            // textBoxSetAesPasswd
            // 
            this.textBoxSetAesPasswd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSetAesPasswd.Location = new System.Drawing.Point(117, 47);
            this.textBoxSetAesPasswd.Name = "textBoxSetAesPasswd";
            this.textBoxSetAesPasswd.Size = new System.Drawing.Size(214, 23);
            this.textBoxSetAesPasswd.TabIndex = 37;
            // 
            // buttonAesEncode
            // 
            this.buttonAesEncode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAesEncode.Location = new System.Drawing.Point(337, 47);
            this.buttonAesEncode.Name = "buttonAesEncode";
            this.buttonAesEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonAesEncode.TabIndex = 36;
            this.buttonAesEncode.Text = "加密";
            this.buttonAesEncode.UseVisualStyleBackColor = true;
            this.buttonAesEncode.Click += new System.EventHandler(this.buttonAesEncode_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(54, 50);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 17);
            this.label34.TabIndex = 38;
            this.label34.Text = "设置密码：";
            // 
            // Cryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1164, 637);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDecrypted);
            this.Controls.Add(this.textBoxDecOrigin);
            this.Controls.Add(this.textBoxCrypted);
            this.Controls.Add(this.textBoxCrypOrigin);
            this.Controls.Add(this.tabPagesModeSelect);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cryption";
            this.Text = "加密与解密算法测试";
            this.tabPagesModeSelect.ResumeLayout(false);
            this.tabPageCer.ResumeLayout(false);
            this.tabPageCer.PerformLayout();
            this.tabPageRSA.ResumeLayout(false);
            this.tabPageRSA.PerformLayout();
            this.tabPageMd5Des.ResumeLayout(false);
            this.tabPageMd5Des.PerformLayout();
            this.tabPageAesSha.ResumeLayout(false);
            this.tabPageAesSha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabControl tabPagesModeSelect;
        private System.Windows.Forms.TabPage tabPageCer;
        private System.Windows.Forms.TabPage tabPageRSA;
        private System.Windows.Forms.TabPage tabPageMd5Des;
        private System.Windows.Forms.TextBox textBoxCrypOrigin;
        private System.Windows.Forms.TextBox textBoxCrypted;
        private System.Windows.Forms.TextBox textBoxDecOrigin;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSelectMakecret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPathMakecret;
        private System.Windows.Forms.Button buttonCreatePfx;
        private System.Windows.Forms.TextBox textBoxCnName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxExportPfxPath;
        private System.Windows.Forms.Button buttonSelectExportPfxPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonExportPfx;
        private System.Windows.Forms.TextBox textBoxExportKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonExportCer;
        private System.Windows.Forms.TextBox textBoxExportCerPath;
        private System.Windows.Forms.Button buttonSetExportCerPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonGetKeyPair;
        private System.Windows.Forms.TextBox textBoxPfxKey;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxPfxPath;
        private System.Windows.Forms.Button buttonSelectPfx;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button buttonPrivDecry;
        private System.Windows.Forms.TextBox textBoxPrivKey;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxPubKey;
        private System.Windows.Forms.Button buttonPubCrypt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button buttonImportToMD5;
        private System.Windows.Forms.TextBox textBoxImportedToMD5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxMD5;
        private System.Windows.Forms.Button buttonMD5calc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonDesDecode;
        private System.Windows.Forms.TextBox textBoxImputDesPasswd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxSetDesPasswd;
        private System.Windows.Forms.Button buttonDesEncode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonCheckMD5;
        private System.Windows.Forms.Label MD5CheckResult;
        private System.Windows.Forms.Label labelCerName;
        private System.Windows.Forms.Label labelCerMD5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabPage tabPageAesSha;
        private System.Windows.Forms.Button buttonSHA;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RadioButton radioButtonSHA512;
        private System.Windows.Forms.RadioButton radioButtonSHA256;
        private System.Windows.Forms.RadioButton radioButtonSHA1;
        private System.Windows.Forms.Button buttonAesDecode;
        private System.Windows.Forms.TextBox textBoxImputAesPasswd;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxSetAesPasswd;
        private System.Windows.Forms.Button buttonAesEncode;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
    }
}

