using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Diagnostics;

namespace AutoTorrentDownload
{
    public partial class Form1 : Form
    {
        List<Nyaa> NyaaTorrent;
        string url;
        public Form1()
        {
            InitializeComponent();
            NyaaTorrent = new List<Nyaa>();
            url = "https://nyaa.si/";
            addtoList(url+ "?page=rss");
            torrent_list.DisplayMember = "title";
            torrent_list.ValueMember = "ID";
            filter_type.SelectedIndex = 0;
            this.AcceptButton = filter_button;
        }

        private void refresh_torrents_Click(object sender, EventArgs e)
        {
            string rss = url+"?page=rss";
            addtoList(rss);
        }

        private void addtoList(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            NyaaTorrent.Clear();
            int counter = 0;

            foreach (SyndicationItem item in feed.Items)
            {
                Nyaa nyaa = new Nyaa();
                nyaa.title = item.Title.Text;
                string temp = item.Summary.Text.Replace(" ", string.Empty);
                string[] substring = temp.Split('|');
                nyaa.ID = counter;
                nyaa.size = substring[2];
                nyaa.language = substring[3];
                nyaa.infoHash = substring[4];
                nyaa.datetime = item.PublishDate.DateTime.ToString();
                NyaaTorrent.Add(nyaa);
                counter++;
            }
            populateList();
        }

        private void populateList()
        {
            torrent_list.Items.Clear();
            foreach(Nyaa item in NyaaTorrent)
            {
                torrent_list.Items.Add(item);
            }
            torrent_list.ClearSelected();
            torrent_list.Refresh();
            torrent_info.Text = "";
        }

        private void torrent_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                torrent_info.Text = "Title: " + NyaaTorrent[torrent_list.SelectedIndex].title + "\r\n";
                torrent_info.Text += "Language: " + NyaaTorrent[torrent_list.SelectedIndex].language + "\r\n";
                torrent_info.Text += "Size: " + NyaaTorrent[torrent_list.SelectedIndex].size + "\r\n";
                torrent_info.Text += "Date: " + NyaaTorrent[torrent_list.SelectedIndex].datetime;
            }
            catch
            {

            }
        }

        private void download_torrent_Click(object sender, EventArgs e)
        {
            if(torrent_list.SelectedIndex >= 0)
            {
                Process.Start("magnet:?xt=urn:btih:" + NyaaTorrent[torrent_list.SelectedIndex].infoHash);
            }
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            string filtertext = filter_text.Text.Replace(" ", "+");
            string filterURL = String.Format(url + $"?page=rss&c="+ filter_type.SelectedIndex + "_0&q="+filtertext);
            addtoList(filterURL);
        }

        private void tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol1.SelectedIndex == 0)
                this.AcceptButton = filter_button;
        }
    }
}
