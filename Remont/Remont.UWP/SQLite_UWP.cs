using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using Remont.UWP;
using Remont.Services;

[assembly: Dependency(typeof(SQLite_UWP))]
namespace Remont.UWP
{
    public class SQLite_UWP : ISQLite
    {
        public SQLite_UWP() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            // ��� ������� � ������ ���������� API Windows.Storage
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            return path;
        }
    }
}