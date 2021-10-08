
namespace BrawlhallaPingChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EUbutton = new System.Windows.Forms.Button();
            this.USEbutton = new System.Windows.Forms.Button();
            this.USWbutton = new System.Windows.Forms.Button();
            this.BRZbutton = new System.Windows.Forms.Button();
            this.SEAbutton = new System.Windows.Forms.Button();
            this.AUSbutton = new System.Windows.Forms.Button();
            this.JPNbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QuickPingButton = new System.Windows.Forms.Button();
            this.TenPingsButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.resetAVG = new System.Windows.Forms.Button();
            this.SmallByteButton = new System.Windows.Forms.Button();
            this.BigByteButton = new System.Windows.Forms.Button();
            this.BiggestByteButton = new System.Windows.Forms.Button();
            this.pingLabel = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.quiPing = new System.Windows.Forms.Label();
            this.tenPing = new System.Windows.Forms.Label();
            this.tenPingAvg = new System.Windows.Forms.Label();
            this.quiPingAvg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tenPingHigh = new System.Windows.Forms.Label();
            this.quiPingHigh = new System.Windows.Forms.Label();
            this.tenPingsLoss = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.byteCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // EUbutton
            // 
            this.EUbutton.Location = new System.Drawing.Point(12, 12);
            this.EUbutton.Name = "EUbutton";
            this.EUbutton.Size = new System.Drawing.Size(75, 23);
            this.EUbutton.TabIndex = 0;
            this.EUbutton.Text = "EU";
            this.toolTip1.SetToolTip(this.EUbutton, "Europe (Amsterdam)");
            this.EUbutton.UseVisualStyleBackColor = true;
            this.EUbutton.Click += new System.EventHandler(this.EUbutton_Click);
            // 
            // USEbutton
            // 
            this.USEbutton.Location = new System.Drawing.Point(12, 41);
            this.USEbutton.Name = "USEbutton";
            this.USEbutton.Size = new System.Drawing.Size(75, 23);
            this.USEbutton.TabIndex = 1;
            this.USEbutton.Text = "US-E";
            this.toolTip1.SetToolTip(this.USEbutton, "US-East (Atlanta)");
            this.USEbutton.UseVisualStyleBackColor = true;
            this.USEbutton.Click += new System.EventHandler(this.USEbutton_Click);
            // 
            // USWbutton
            // 
            this.USWbutton.Location = new System.Drawing.Point(12, 70);
            this.USWbutton.Name = "USWbutton";
            this.USWbutton.Size = new System.Drawing.Size(75, 23);
            this.USWbutton.TabIndex = 2;
            this.USWbutton.Text = "US-W";
            this.toolTip1.SetToolTip(this.USWbutton, "US-West (California)");
            this.USWbutton.UseVisualStyleBackColor = true;
            this.USWbutton.Click += new System.EventHandler(this.USWbutton_Click);
            // 
            // BRZbutton
            // 
            this.BRZbutton.Location = new System.Drawing.Point(12, 99);
            this.BRZbutton.Name = "BRZbutton";
            this.BRZbutton.Size = new System.Drawing.Size(75, 23);
            this.BRZbutton.TabIndex = 3;
            this.BRZbutton.Text = "BRZ";
            this.toolTip1.SetToolTip(this.BRZbutton, "Brazil (?)");
            this.BRZbutton.UseVisualStyleBackColor = true;
            this.BRZbutton.Click += new System.EventHandler(this.BRZbutton_Click);
            // 
            // SEAbutton
            // 
            this.SEAbutton.Location = new System.Drawing.Point(12, 128);
            this.SEAbutton.Name = "SEAbutton";
            this.SEAbutton.Size = new System.Drawing.Size(75, 23);
            this.SEAbutton.TabIndex = 4;
            this.SEAbutton.Text = "SEA";
            this.toolTip1.SetToolTip(this.SEAbutton, "Southeast Asia (Singapore)");
            this.SEAbutton.UseVisualStyleBackColor = true;
            this.SEAbutton.Click += new System.EventHandler(this.SEAbutton_Click);
            // 
            // AUSbutton
            // 
            this.AUSbutton.Location = new System.Drawing.Point(12, 157);
            this.AUSbutton.Name = "AUSbutton";
            this.AUSbutton.Size = new System.Drawing.Size(75, 23);
            this.AUSbutton.TabIndex = 5;
            this.AUSbutton.Text = "AUS";
            this.toolTip1.SetToolTip(this.AUSbutton, "Australia (?)");
            this.AUSbutton.UseVisualStyleBackColor = true;
            this.AUSbutton.Click += new System.EventHandler(this.AUSbutton_Click);
            // 
            // JPNbutton
            // 
            this.JPNbutton.Location = new System.Drawing.Point(12, 186);
            this.JPNbutton.Name = "JPNbutton";
            this.JPNbutton.Size = new System.Drawing.Size(73, 23);
            this.JPNbutton.TabIndex = 6;
            this.JPNbutton.Text = "JPN";
            this.toolTip1.SetToolTip(this.JPNbutton, "Japan (?)");
            this.JPNbutton.UseVisualStyleBackColor = true;
            this.JPNbutton.Click += new System.EventHandler(this.JPNbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(202, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 95);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 235);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Change";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Server: none";
            // 
            // QuickPingButton
            // 
            this.QuickPingButton.Location = new System.Drawing.Point(220, 128);
            this.QuickPingButton.Name = "QuickPingButton";
            this.QuickPingButton.Size = new System.Drawing.Size(78, 23);
            this.QuickPingButton.TabIndex = 13;
            this.QuickPingButton.Text = "Quick ping";
            this.toolTip1.SetToolTip(this.QuickPingButton, "Quickly pings the server with no delay");
            this.QuickPingButton.UseVisualStyleBackColor = true;
            this.QuickPingButton.Click += new System.EventHandler(this.QuickPingButton_Click);
            // 
            // TenPingsButton
            // 
            this.TenPingsButton.Location = new System.Drawing.Point(341, 128);
            this.TenPingsButton.Name = "TenPingsButton";
            this.TenPingsButton.Size = new System.Drawing.Size(79, 23);
            this.TenPingsButton.TabIndex = 14;
            this.TenPingsButton.Text = "12 pings";
            this.toolTip1.SetToolTip(this.TenPingsButton, "Pings the server 12 times over a short period of time\r\nand returns the current, a" +
        "verage, highest pings as well \r\nas packet both in numeric and visual form");
            this.TenPingsButton.UseVisualStyleBackColor = true;
            this.TenPingsButton.Click += new System.EventHandler(this.TenPingsButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(447, 439);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 19);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "© nikolaS";
            this.toolTip1.SetToolTip(this.linkLabel1, "My Twitter!");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // resetAVG
            // 
            this.resetAVG.Location = new System.Drawing.Point(370, 437);
            this.resetAVG.Name = "resetAVG";
            this.resetAVG.Size = new System.Drawing.Size(71, 23);
            this.resetAVG.TabIndex = 19;
            this.resetAVG.Text = "Reset data";
            this.toolTip1.SetToolTip(this.resetAVG, "Resets data from previous pings");
            this.resetAVG.UseVisualStyleBackColor = true;
            this.resetAVG.Click += new System.EventHandler(this.resetAVG_Click);
            // 
            // SmallByteButton
            // 
            this.SmallByteButton.Location = new System.Drawing.Point(433, 325);
            this.SmallByteButton.Name = "SmallByteButton";
            this.SmallByteButton.Size = new System.Drawing.Size(71, 23);
            this.SmallByteButton.TabIndex = 48;
            this.SmallByteButton.Text = "32 bytes";
            this.toolTip1.SetToolTip(this.SmallByteButton, "Resets data from previous pings");
            this.SmallByteButton.UseVisualStyleBackColor = true;
            this.SmallByteButton.Click += new System.EventHandler(this.SmallByteButton_Click);
            // 
            // BigByteButton
            // 
            this.BigByteButton.Location = new System.Drawing.Point(433, 354);
            this.BigByteButton.Name = "BigByteButton";
            this.BigByteButton.Size = new System.Drawing.Size(71, 23);
            this.BigByteButton.TabIndex = 49;
            this.BigByteButton.Text = "64 bytes";
            this.toolTip1.SetToolTip(this.BigByteButton, "Resets data from previous pings");
            this.BigByteButton.UseVisualStyleBackColor = true;
            this.BigByteButton.Click += new System.EventHandler(this.BigByteButton_Click);
            // 
            // BiggestByteButton
            // 
            this.BiggestByteButton.Location = new System.Drawing.Point(433, 383);
            this.BiggestByteButton.Name = "BiggestByteButton";
            this.BiggestByteButton.Size = new System.Drawing.Size(71, 23);
            this.BiggestByteButton.TabIndex = 51;
            this.BiggestByteButton.Text = "128 bytes";
            this.toolTip1.SetToolTip(this.BiggestByteButton, "Resets data from previous pings");
            this.BiggestByteButton.UseVisualStyleBackColor = true;
            this.BiggestByteButton.Click += new System.EventHandler(this.BiggestByteButton_Click);
            // 
            // pingLabel
            // 
            this.pingLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pingLabel.Location = new System.Drawing.Point(175, 159);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(44, 19);
            this.pingLabel.TabIndex = 16;
            this.pingLabel.Text = "Ping:";
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avgLabel.Location = new System.Drawing.Point(175, 185);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(36, 19);
            this.avgLabel.TabIndex = 18;
            this.avgLabel.Text = "Avg:";
            // 
            // quiPing
            // 
            this.quiPing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quiPing.Location = new System.Drawing.Point(220, 159);
            this.quiPing.Name = "quiPing";
            this.quiPing.Size = new System.Drawing.Size(78, 19);
            this.quiPing.TabIndex = 20;
            this.quiPing.Text = "N/A";
            this.quiPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenPing
            // 
            this.tenPing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenPing.Location = new System.Drawing.Point(341, 159);
            this.tenPing.Name = "tenPing";
            this.tenPing.Size = new System.Drawing.Size(79, 19);
            this.tenPing.TabIndex = 21;
            this.tenPing.Text = "N/A";
            this.tenPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenPingAvg
            // 
            this.tenPingAvg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenPingAvg.Location = new System.Drawing.Point(341, 185);
            this.tenPingAvg.Name = "tenPingAvg";
            this.tenPingAvg.Size = new System.Drawing.Size(79, 19);
            this.tenPingAvg.TabIndex = 24;
            this.tenPingAvg.Text = "N/A";
            this.tenPingAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quiPingAvg
            // 
            this.quiPingAvg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quiPingAvg.Location = new System.Drawing.Point(220, 185);
            this.quiPingAvg.Name = "quiPingAvg";
            this.quiPingAvg.Size = new System.Drawing.Size(78, 19);
            this.quiPingAvg.TabIndex = 23;
            this.quiPingAvg.Text = "N/A";
            this.quiPingAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(358, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox2.Location = new System.Drawing.Point(374, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox3.Location = new System.Drawing.Point(391, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox4.Location = new System.Drawing.Point(358, 283);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 10);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox5.Location = new System.Drawing.Point(374, 283);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 10);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox6.Location = new System.Drawing.Point(391, 283);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 10);
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox7.Location = new System.Drawing.Point(358, 299);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 10);
            this.pictureBox7.TabIndex = 33;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox8.Location = new System.Drawing.Point(374, 299);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 10);
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox9.Location = new System.Drawing.Point(391, 299);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 10);
            this.pictureBox9.TabIndex = 35;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox10.Location = new System.Drawing.Point(358, 315);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(10, 10);
            this.pictureBox10.TabIndex = 36;
            this.pictureBox10.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "High";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox11.Location = new System.Drawing.Point(374, 315);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(10, 10);
            this.pictureBox11.TabIndex = 38;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::BrawlhallaPingChecker.Properties.Resources.Untitled;
            this.pictureBox12.Location = new System.Drawing.Point(391, 315);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(10, 10);
            this.pictureBox12.TabIndex = 39;
            this.pictureBox12.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(175, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Loss [%]";
            // 
            // tenPingHigh
            // 
            this.tenPingHigh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenPingHigh.Location = new System.Drawing.Point(341, 212);
            this.tenPingHigh.Name = "tenPingHigh";
            this.tenPingHigh.Size = new System.Drawing.Size(79, 19);
            this.tenPingHigh.TabIndex = 42;
            this.tenPingHigh.Text = "N/A";
            this.tenPingHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quiPingHigh
            // 
            this.quiPingHigh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quiPingHigh.Location = new System.Drawing.Point(220, 212);
            this.quiPingHigh.Name = "quiPingHigh";
            this.quiPingHigh.Size = new System.Drawing.Size(78, 19);
            this.quiPingHigh.TabIndex = 41;
            this.quiPingHigh.Text = "N/A";
            this.quiPingHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenPingsLoss
            // 
            this.tenPingsLoss.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tenPingsLoss.Location = new System.Drawing.Point(341, 239);
            this.tenPingsLoss.Name = "tenPingsLoss";
            this.tenPingsLoss.Size = new System.Drawing.Size(79, 19);
            this.tenPingsLoss.TabIndex = 45;
            this.tenPingsLoss.Text = "N/A";
            this.tenPingsLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(236, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "//";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(9, 435);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(75, 23);
            this.InfoButton.TabIndex = 47;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // byteCount
            // 
            this.byteCount.AutoSize = true;
            this.byteCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.byteCount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.byteCount.Location = new System.Drawing.Point(12, 281);
            this.byteCount.Name = "byteCount";
            this.byteCount.Size = new System.Drawing.Size(50, 15);
            this.byteCount.TabIndex = 50;
            this.byteCount.Text = "32 bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 466);
            this.Controls.Add(this.BiggestByteButton);
            this.Controls.Add(this.byteCount);
            this.Controls.Add(this.BigByteButton);
            this.Controls.Add(this.SmallByteButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.tenPingsLoss);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tenPingHigh);
            this.Controls.Add(this.quiPingHigh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tenPingAvg);
            this.Controls.Add(this.quiPingAvg);
            this.Controls.Add(this.tenPing);
            this.Controls.Add(this.quiPing);
            this.Controls.Add(this.resetAVG);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.pingLabel);
            this.Controls.Add(this.TenPingsButton);
            this.Controls.Add(this.QuickPingButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JPNbutton);
            this.Controls.Add(this.AUSbutton);
            this.Controls.Add(this.SEAbutton);
            this.Controls.Add(this.BRZbutton);
            this.Controls.Add(this.USWbutton);
            this.Controls.Add(this.USEbutton);
            this.Controls.Add(this.EUbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ping Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EUbutton;
        private System.Windows.Forms.Button USEbutton;
        private System.Windows.Forms.Button USWbutton;
        private System.Windows.Forms.Button BRZbutton;
        private System.Windows.Forms.Button SEAbutton;
        private System.Windows.Forms.Button AUSbutton;
        private System.Windows.Forms.Button JPNbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button QuickPingButton;
        private System.Windows.Forms.Button TenPingsButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Button resetAVG;
        private System.Windows.Forms.Label quiPing;
        private System.Windows.Forms.Label tenPing;
        private System.Windows.Forms.Label tenPingAvg;
        private System.Windows.Forms.Label quiPingAvg;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tenPingHigh;
        private System.Windows.Forms.Label quiPingHigh;
        private System.Windows.Forms.Label tenPingsLoss;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button SmallByteButton;
        private System.Windows.Forms.Button BigByteButton;
        private System.Windows.Forms.Label byteCount;
        private System.Windows.Forms.Button BiggestByteButton;
    }
}

