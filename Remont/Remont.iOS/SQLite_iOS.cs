using System;
using Xamarin.Forms;
using System.IO;
using Remont.iOS;
using Remont.Services;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace Remont.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            // ���������� ���� � ��
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // ����� ����������
            var path = Path.Combine(libraryPath, sqliteFilename);

            return path;
        }
    }
}