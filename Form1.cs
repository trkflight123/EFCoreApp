using EFCoreDomain.Models;
using EFCoreInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

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
            GetCategories();
        }

        private void GetCategories()
        {
            using var dbContext = new AppDbContext();
            dataGridView1.DataSource = dbContext.Categories.OrderBy(c => Name).ToList();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using var dbContext = new AppDbContext();

            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                dataGridView1.DataSource = dbContext.Categories.ToList();
                return;
            }

            dataGridView1.DataSource = dbContext.Categories.Where(c => c.Name.ToLower().Contains(txtSearch.Text.ToLower().Trim())).ToList();

        }

        //CRUD - CREATE
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var dbContext = new AppDbContext();
            var category = new Category();
            category.Name = txtName.Text.Trim();
            category.Description = txtDescription.Text.Trim();

            dbContext.Categories.Add(category);
            dbContext.SaveChanges();

            MessageBox.Show("Category added successfully!");

            GetCategories();
        }

        // CRUDE - UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using var dbContext = new AppDbContext();

            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid category ID");
                return;
            }

            Guid categoryId = Guid.Parse(txtId.Text.Trim());
            var category = dbContext.Categories.Find(categoryId);
            category.Name = txtName.Text.Trim();
            category.Description = txtDescription.Text.Trim();

        }

        //CRUDE - DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using var dbContext = new AppDbContext();

            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid category ID");
                return;
            }

            Guid categoryId = Guid.Parse(txtId.Text.Trim());
            var category = dbContext.Categories.Find(categoryId);

            if (category != null)
            {
                MessageBox.Show("Category deleted successfully!");
                return;
            }

            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells["Id"].Value?.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value?.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value?.ToString() ?? "{needs updating";
            }
        }
    }
}

