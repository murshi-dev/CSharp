namespace ProductsApp
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;

        public Form1()
        {
            InitializeComponent();
            dgv1.SelectionChanged += dgv1_SelectionChanged;
            button3.Click += button3_Click; // Ensure this line is present
            button4.Click += button4_Click;
            _context = new AppDbContext();
            RefreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insert
            var product = new Product
            {
                ProductName = textBox2.Text,
                ProductPrice = decimal.Parse(textBox3.Text),
                StockInHand = int.Parse(textBox4.Text)
            };

            _context.Products.Add(product);
            _context.SaveChanges();
            MessageBox.Show("Successfully Inserted.");
            RefreshDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Refresh
            RefreshDataGridView();
        }






        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(dgv1.SelectedRows[0].Cells["ProductID"].Value);
                var product = _context.Products.Find(selectedID);

                if (product != null)
                {
                    // Update product details
                    product.ProductName = textBox2.Text;
                    product.ProductPrice = decimal.Parse(textBox3.Text);
                    product.StockInHand = int.Parse(textBox4.Text);

                    _context.SaveChanges();
                    MessageBox.Show("Product updated successfully.");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Please select a product to update.");
                }
            }
        }

















        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(dgv1.SelectedRows[0].Cells["ProductID"].Value);
                var product = _context.Products.Find(selectedID);

                if (product != null)
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    MessageBox.Show("Product deleted successfully.");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.");
                }
            }
        }






















        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv1.SelectedRows[0];

                // Populate text boxes with data from selected row
                textBox1.Text = selectedRow.Cells["ProductID"].Value.ToString();
                textBox2.Text = selectedRow.Cells["ProductName"].Value.ToString();
                textBox3.Text = selectedRow.Cells["ProductPrice"].Value.ToString();
                textBox4.Text = selectedRow.Cells["StockInHand"].Value.ToString();
            }
            else
            {
                // Clear text boxes if no row is selected
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }


        private void RefreshDataGridView()
        {
            // Refresh DataGridView
            dgv1.DataSource = _context.Products.ToList();
        }

    }
}

