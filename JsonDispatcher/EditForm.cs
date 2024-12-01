namespace JsonDispatcher
{
    public partial class EditForm : Form
    {
        public Item Item { get; set; }

        public EditForm(Item? item = null)
        {
            InitializeComponent();
            Item = item ?? new Item();
            txtName.Text = Item.Name;
            txtQuantity.Text = Item.Quantity.ToString();
            txtPrice.Text = Item.Price.ToString("0.##");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            Item.Name = txtName.Text;
            Item.Quantity = int.Parse(txtQuantity.Text);
            Item.Price = decimal.Parse(txtPrice.Text);
            DialogResult = DialogResult.OK;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}