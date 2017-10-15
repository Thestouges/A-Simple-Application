namespace AutoTorrentDownload
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
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.nyaa_tab = new System.Windows.Forms.TabPage();
            this.filter_button = new System.Windows.Forms.Button();
            this.filter_text = new System.Windows.Forms.TextBox();
            this.filter_type = new System.Windows.Forms.ComboBox();
            this.download_torrent = new System.Windows.Forms.Button();
            this.torrent_info = new System.Windows.Forms.RichTextBox();
            this.torrent_list = new System.Windows.Forms.ListBox();
            this.refresh_torrents = new System.Windows.Forms.Button();
            this.tabcontrol1.SuspendLayout();
            this.nyaa_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.nyaa_tab);
            this.tabcontrol1.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(756, 379);
            this.tabcontrol1.TabIndex = 0;
            this.tabcontrol1.SelectedIndexChanged += new System.EventHandler(this.tabcontrol1_SelectedIndexChanged);
            // 
            // nyaa_tab
            // 
            this.nyaa_tab.Controls.Add(this.filter_button);
            this.nyaa_tab.Controls.Add(this.filter_text);
            this.nyaa_tab.Controls.Add(this.filter_type);
            this.nyaa_tab.Controls.Add(this.download_torrent);
            this.nyaa_tab.Controls.Add(this.torrent_info);
            this.nyaa_tab.Controls.Add(this.torrent_list);
            this.nyaa_tab.Controls.Add(this.refresh_torrents);
            this.nyaa_tab.Location = new System.Drawing.Point(4, 22);
            this.nyaa_tab.Name = "nyaa_tab";
            this.nyaa_tab.Padding = new System.Windows.Forms.Padding(3);
            this.nyaa_tab.Size = new System.Drawing.Size(748, 353);
            this.nyaa_tab.TabIndex = 0;
            this.nyaa_tab.Text = "Nyaa.si";
            this.nyaa_tab.UseVisualStyleBackColor = true;
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(254, 319);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(67, 24);
            this.filter_button.TabIndex = 14;
            this.filter_button.Text = "Filter";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // filter_text
            // 
            this.filter_text.Location = new System.Drawing.Point(93, 323);
            this.filter_text.Name = "filter_text";
            this.filter_text.Size = new System.Drawing.Size(146, 20);
            this.filter_text.TabIndex = 13;
            // 
            // filter_type
            // 
            this.filter_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_type.FormattingEnabled = true;
            this.filter_type.Items.AddRange(new object[] {
            "All categories",
            "Anime",
            "Audio",
            "Literature",
            "Live Action",
            "Pictures",
            "Software"});
            this.filter_type.Location = new System.Drawing.Point(10, 323);
            this.filter_type.MaxDropDownItems = 7;
            this.filter_type.Name = "filter_type";
            this.filter_type.Size = new System.Drawing.Size(77, 21);
            this.filter_type.TabIndex = 12;
            // 
            // download_torrent
            // 
            this.download_torrent.Location = new System.Drawing.Point(663, 323);
            this.download_torrent.Name = "download_torrent";
            this.download_torrent.Size = new System.Drawing.Size(67, 25);
            this.download_torrent.TabIndex = 11;
            this.download_torrent.Text = "Download";
            this.download_torrent.UseVisualStyleBackColor = true;
            this.download_torrent.Click += new System.EventHandler(this.download_torrent_Click);
            // 
            // torrent_info
            // 
            this.torrent_info.Location = new System.Drawing.Point(254, 7);
            this.torrent_info.Name = "torrent_info";
            this.torrent_info.ReadOnly = true;
            this.torrent_info.Size = new System.Drawing.Size(476, 306);
            this.torrent_info.TabIndex = 10;
            this.torrent_info.Text = "";
            // 
            // torrent_list
            // 
            this.torrent_list.FormattingEnabled = true;
            this.torrent_list.HorizontalScrollbar = true;
            this.torrent_list.Location = new System.Drawing.Point(10, 11);
            this.torrent_list.Name = "torrent_list";
            this.torrent_list.Size = new System.Drawing.Size(229, 303);
            this.torrent_list.TabIndex = 9;
            this.torrent_list.SelectedIndexChanged += new System.EventHandler(this.torrent_list_SelectedIndexChanged);
            // 
            // refresh_torrents
            // 
            this.refresh_torrents.Location = new System.Drawing.Point(543, 323);
            this.refresh_torrents.Name = "refresh_torrents";
            this.refresh_torrents.Size = new System.Drawing.Size(106, 24);
            this.refresh_torrents.TabIndex = 8;
            this.refresh_torrents.Text = "Refresh Torrents";
            this.refresh_torrents.UseVisualStyleBackColor = true;
            this.refresh_torrents.Click += new System.EventHandler(this.refresh_torrents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 378);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "Form1";
            this.Text = "TrackTorrent";
            this.tabcontrol1.ResumeLayout(false);
            this.nyaa_tab.ResumeLayout(false);
            this.nyaa_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage nyaa_tab;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.TextBox filter_text;
        private System.Windows.Forms.ComboBox filter_type;
        private System.Windows.Forms.Button download_torrent;
        private System.Windows.Forms.RichTextBox torrent_info;
        private System.Windows.Forms.ListBox torrent_list;
        private System.Windows.Forms.Button refresh_torrents;
    }
}

