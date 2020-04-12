using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using EventBN.Droid;
using System.IO;
using SQLite;
using SQLite.Net;
using System.Reflection;

[assembly: Dependency(typeof(SqliteService))]
namespace EventBN.Droid
{

    public class SqliteService : ISQLite
    {

        public SqliteService() { }

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            
            string filename = "MyDb.db";
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string dbPath = Path.Combine(folderPath, filename);
            
           
            if (!File.Exists(dbPath))
            {

                using (var binaryReader = new BinaryReader(Android.App.Application.Context.Assets.Open(filename)))
                {
                    using (var binaryWriter = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
                    {
                        byte[] buffer = new byte[2048];
                        int length = 0;
                        while ((length = binaryReader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            binaryWriter.Write(buffer, 0, length);
                        }
                    }
                }
            }


            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, dbPath);

            return conn;


        }

    }

}