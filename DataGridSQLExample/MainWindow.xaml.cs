using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace DataGridSQLExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataTable dt= new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=NYENDWAJ\\SQLEXPRESS;Initial Catalog=_Customers;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select CustomerID, firstName as [First Name], lastName as [Last Name], age as Age, country as Country from customers", conn);
            da.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;


        }


    }
}
