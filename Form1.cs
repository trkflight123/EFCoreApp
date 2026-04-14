using EFCoreInfrastructure.Data;

namespace EFCoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                dataGridView1.DataSource = dbContext.Categories.ToList();
            }
        }
        }
    }

