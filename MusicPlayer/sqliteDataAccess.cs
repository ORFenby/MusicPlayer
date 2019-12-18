using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using Dapper;

namespace MusicPlayer
{
    public class sqliteDataAccess
    {
        //connection will be open and ensures the connection closes if the application was to crash or error.
        public static List<SongModel> LoadSong()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SongModel>("SELECT * FROM Music", new DynamicParameters());
                return output.ToList();
            }
        }
        public void SaveSong(SongModel songModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Music (Title, Album, Artist, Path) values (@Title, @Album, @Artist, @Path)", songModel);
            }
        }
        private static string LoadConnectionString(string id = "ConnectionDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        
        public static string GetPath(string songName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string output = cnn.QuerySingle("SELECT Path FROM Music WHERE Title = '" + songName + "'");
                return output;
            }
        }






    }
}

