using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JsonDispatcher
{
    public partial class MainForm : Form
    {
        private List<Item> items = new List<Item>();
        private Item selectedItem;
        private const string FilePath = @"/Users/ksenia/Downloads/WinFormsApp2/JsonDispatcher/data.json";

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            InitializeGrid();
            
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
        }
        
        private void LoadData()
        {
            items = JsonHandler.LoadData(FilePath);
            if (items.Count == 0)
            {
                MessageBox.Show("The data was not loaded from the file.");
            }
            dataGridView.DataSource = items;
        }
        
        private void InitializeGrid()
        {
            dataGridView.Columns["Price"].DefaultCellStyle.Format = "C";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                items.Add(editForm.Item);
                SaveData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                EditForm editForm = new EditForm(selectedItem);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    SaveData();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }
        
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                selectedItem = (Item)dataGridView.SelectedRows[0].DataBoundItem;
                Console.WriteLine("Item selected: " + selectedItem.Name);
            }
            else
            {
                selectedItem = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;

            var selectedItem = dataGridView.SelectedRows[0].DataBoundItem as Item;
            items.Remove(selectedItem);
            SaveData();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchQuery = txtSearch.Text.ToLower();
            var searchResults = items.Where(x => x.Name.ToLower().Contains(searchQuery) || x.Quantity.ToString().Contains(searchQuery)).ToList();
            dataGridView.DataSource = searchResults;
        }
        
        private void SaveData()
        {
            JsonHandler.SaveData(items, FilePath);
            dataGridView.DataSource = null;
            dataGridView.DataSource = items;
        }
        
        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
