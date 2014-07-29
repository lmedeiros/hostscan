namespace WindowsFormsApplication1
{
    partial class frmMainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.btnScan = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtIpAddres = new System.Windows.Forms.TextBox();
            this.nupIpAmount = new System.Windows.Forms.NumericUpDown();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHosts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListPcIcons = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIpAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(491, 8);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 35);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(572, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Status";
            // 
            // txtIpAddres
            // 
            this.txtIpAddres.Location = new System.Drawing.Point(41, 15);
            this.txtIpAddres.Name = "txtIpAddres";
            this.txtIpAddres.Size = new System.Drawing.Size(135, 20);
            this.txtIpAddres.TabIndex = 4;
            this.txtIpAddres.Text = "192.168.0.1";
            this.txtIpAddres.TextChanged += new System.EventHandler(this.txtIpAddres_TextChanged);
            // 
            // nupIpAmount
            // 
            this.nupIpAmount.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupIpAmount.Location = new System.Drawing.Point(254, 15);
            this.nupIpAmount.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nupIpAmount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupIpAmount.Name = "nupIpAmount";
            this.nupIpAmount.Size = new System.Drawing.Size(120, 20);
            this.nupIpAmount.TabIndex = 5;
            this.nupIpAmount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupIpAmount.ValueChanged += new System.EventHandler(this.nupIpAmount_ValueChanged);
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(15, 18);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(20, 13);
            this.lblIpAddress.TabIndex = 6;
            this.lblIpAddress.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AMOUNT:";
            // 
            // lstHosts
            // 
            this.lstHosts.CausesValidation = false;
            this.lstHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstHosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstHosts.FullRowSelect = true;
            this.lstHosts.GridLines = true;
            this.lstHosts.HideSelection = false;
            this.lstHosts.LargeImageList = this.imageListPcIcons;
            this.lstHosts.Location = new System.Drawing.Point(0, 49);
            this.lstHosts.MultiSelect = false;
            this.lstHosts.Name = "lstHosts";
            this.lstHosts.Size = new System.Drawing.Size(572, 342);
            this.lstHosts.SmallImageList = this.imageListPcIcons;
            this.lstHosts.StateImageList = this.imageListPcIcons;
            this.lstHosts.TabIndex = 9;
            this.lstHosts.UseCompatibleStateImageBehavior = false;
            this.lstHosts.View = System.Windows.Forms.View.Details;
            this.lstHosts.SelectedIndexChanged += new System.EventHandler(this.lstHosts_SelectedIndexChanged);
            this.lstHosts.DoubleClick += new System.EventHandler(this.lstHosts_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hostname";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 180;
            // 
            // imageListPcIcons
            // 
            this.imageListPcIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPcIcons.ImageStream")));
            this.imageListPcIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPcIcons.Images.SetKeyName(0, "pc");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 49);
            this.label3.TabIndex = 11;
            this.label3.Text = "Please Wait...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstHosts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIpAddress);
            this.Controls.Add(this.nupIpAmount);
            this.Controls.Add(this.txtIpAddres);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMainScreen";
            this.Text = "Host Scanner";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIpAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox txtIpAddres;
        private System.Windows.Forms.NumericUpDown nupIpAmount;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstHosts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageListPcIcons;
        private System.Windows.Forms.Label label3;
    }
}

