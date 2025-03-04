using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db 
        {

            get
            {
                // Isso verifica se tem objeto dentro de campo DB se não tiver instancia DB;
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                       "banco_sqlite_compras.db3"); 

                    _db = new SQLiteDatabaseHelper(path);
                }
                return _db;
            }
        }
        

       


        public App()
        {
            

            InitializeComponent();

            // MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
