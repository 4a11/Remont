using System;
using Remont.Droid;
using System.IO;
using Xamarin.Forms;
using Remont.Services;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Remont.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}