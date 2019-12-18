using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class PlaylistForm : Form
    {
        List<SongModel> _songModels = new List<SongModel>();
        sqliteDataAccess databaseConnection = new sqliteDataAccess();
        Form form = new Form();
        public PlaylistForm()
        {
            InitializeComponent();
            LoadSongList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           ;
        }
        private void LoadSongList()
        {
            _songModels = sqliteDataAccess.LoadSong();
            SongList();
        }
        private void SongList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _songModels;
            listBox1.DisplayMember = "Title";
        }
    }
}
