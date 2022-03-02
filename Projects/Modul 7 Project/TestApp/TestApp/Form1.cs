using Business;
using Data.Model;
namespace TestApp
{
    public partial class Form1 : Form
    {
        private MovieBusiness movieBusiness = new MovieBusiness();
        private WatcherBusiness watcherBusiness = new WatcherBusiness();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie()
            {
                Name = "Spider-man",
                Stars = 5
            };
            movieBusiness.Add(movie);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            moviesDGV.DataSource = movieBusiness.GetAll();
            moviesDGV.ReadOnly = true;
            moviesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGVWatchers.DataSource = watcherBusiness.GetAll();
            DGVWatchers.ReadOnly = true;
            DGVWatchers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnAddW_Click(object sender, EventArgs e)
        {
            Watcher watcher = new Watcher()
            {
                Name = "Ryan",
                Age = 12
            };
            watcherBusiness.Add(watcher);

        }
    }
}