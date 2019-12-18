using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;




namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        List<SongModel> _songModels = new List<SongModel>();
        sqliteDataAccess databaseConnection = new sqliteDataAccess();
        PlaylistForm PlaylistForm = new PlaylistForm();
        public MusicPlayer()
        {
            InitializeComponent();
            IdleTimer.Start();

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void IdleTimer_Tick(object sender, EventArgs e)
        {
            int ThirtySeconds = 30000; //To avoid using magic numbers
            if (GetIdleTime() > ThirtySeconds) WindowState = FormWindowState.Minimized;
        }

        //Shuffles songs currently added to MusicList
        private void ShuffleBTN_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            MusicList.SelectedIndex = random.Next(0, MusicList.Items.Count);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LastUserInput lastUserInput);
        internal struct LastUserInput
        {
            public int cbSize;
            public int dwTime;
        }

        private static int GetIdleTime()
        {
            LastUserInput LastUserAction = new LastUserInput();
            LastUserAction.cbSize = (int)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            GetLastInputInfo(ref LastUserAction);
            return ((int)Environment.TickCount - LastUserAction.dwTime);
        }

        private void OpenFolderBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            List<SongModel> songs = new List<SongModel>();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    SongModel songViewModel = new SongModel();
                    TagLib.File tagfile = TagLib.File.Create(file);
                    songViewModel.Path = file;
                    songViewModel.Artist = tagfile.Tag.FirstAlbumArtist;
                    songViewModel.Album = tagfile.Tag.Album;
                    songViewModel.Title = tagfile.Tag.Title;
                    databaseConnection.SaveSong(songViewModel);

                }
            }
            LoadSongList();
        }
        private void LoadSongList()
        {
            _songModels = sqliteDataAccess.LoadSong();
            SongList();
        }
        private void SongList()
        {
            MusicList.DataSource = null;
            MusicList.DataSource = _songModels;
            MusicList.DisplayMember = "Title";
        }

        private void MusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PlayBTN_Click(object sender, EventArgs e)
        {
            SongModel song = (SongModel)MusicList.SelectedItem;
            MP3MediaPLayer.URL = song.Path;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSongList();

        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
            if (MusicList.SelectedIndex < MusicList.Items.Count - 1) //checks to make sure song user has song selected
            {
                MusicList.SelectedIndex = MusicList.SelectedIndex + 1;
                SongModel song = (SongModel)MusicList.SelectedItem;
                MP3MediaPLayer.URL = song.Path;
            }
        }

        private void PreviousBTN_Click(object sender, EventArgs e)
        {
            if (MusicList.SelectedIndex > 0)
            {
                MusicList.SelectedIndex = MusicList.SelectedIndex - 1;
                SongModel song = (SongModel)MusicList.SelectedItem;
                MP3MediaPLayer.URL = song.Path;
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            
            MusicList.SelectedItems.Clear();
            for (int i = 0; i <= MusicList.Items.Count - 1; i++)
            {
                SongModel song = (SongModel)MusicList.Items[i];
                if (song.Title.ToString().ToLower().Contains(SearchBox.Text.ToLower()))
                {
                    MusicList.SetSelected(i, true);
                }
                
            }
        }

        private void CrtPlayListBTN_Click(object sender, EventArgs e)
        {
            PlaylistForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
