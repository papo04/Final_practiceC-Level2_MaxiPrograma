using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Presentacion
{
    public partial class MainWindow : Form

    {
        private List<Items> itemList; 
        public MainWindow()
        {
            InitializeComponent();
            Text = "Trabajo Práctico Final";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            load();
            hideColumns();
            cbxField.Items.Add("Item Code");
            cbxField.Items.Add("Item");
            cbxField.Items.Add("Price");
        }
        private void load()
        {
            ItemNegocio negocio = new ItemNegocio();
            itemList = negocio.listar();
            dgvItems.DataSource = itemList;

        }
        private void hideColumns()
        {
            dgvItems.Columns["Id"].Visible = false;
            dgvItems.Columns["urlImage"].Visible = false;
            dgvItems.Columns["Description"].Visible = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FormAddItem AddForm = new FormAddItem();
            AddForm.ShowDialog();
            load();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Items selected;
            selected = (Items)dgvItems.CurrentRow.DataBoundItem;
            FormAddItem AddForm = new FormAddItem(selected);
            AddForm.ShowDialog();
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemNegocio negocio = new ItemNegocio();
            Items item;
            try
            {
                DialogResult result = MessageBox.Show("Are you shure you want to delete this item?", "Item delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    item = (Items)dgvItems.CurrentRow.DataBoundItem;
                    negocio.delete(item);
                    load();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void loadImage(string image)
        {
            try
            {
                pbxMainImage.Load(image);
            }
            catch (Exception)
            {

                pbxMainImage.Load("https://i0.wp.com/elfutbolito.mx/wp-content/uploads/2019/04/image-not-found.png?ssl=1");
            }
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvItems.CurrentRow.DataBoundItem != null)
            {
                Items selected = (Items)dgvItems.CurrentRow.DataBoundItem;
                loadImage(selected.UrlImage);
                if(selected.Description!="")
                {
                    txtDescriptionReadOnly.Text = "Description:" + Environment.NewLine + selected.Description;
                }
                else
                {
                    txtDescriptionReadOnly.Text = "No Description";
                }
            }
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cbxField.SelectedItem.ToString();
            if(option == "Item Code" || option == "Item")
            {
                cbxStandar.Items.Clear();
                cbxStandar.Items.Add("Start with:");
                cbxStandar.Items.Add("Ends with:");
                cbxStandar.Items.Add("Contain:");
            }else
            {
                cbxStandar.Items.Clear();
                cbxStandar.Items.Add("Greater than:");
                cbxStandar.Items.Add("Lower than:");
                cbxStandar.Items.Add("Equal to:");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ItemNegocio negocio = new ItemNegocio();
            try
            {
                if (validateFilter())
                    return;

                string field = cbxField.SelectedItem.ToString();
                string standar = cbxStandar.SelectedItem.ToString();
                string filter = txtFilter.Text;

                dgvItems.DataSource = negocio.filtrate(field, standar, filter);
            }
            catch (Exception)
            {

                throw;
            }
        }
       private bool validateFilter()
        {
            if(cbxField.SelectedIndex < 0)
            {
                MessageBox.Show("enter a Field Option");
                return true;
            }
            if(cbxStandar.SelectedIndex<0)
            {
                MessageBox.Show("Enter a Standar Option");
                return true;
            }
            if(cbxField.SelectedItem.ToString()=="Price")
            {
                if(txtFilter.Text =="")
                {
                    load();
                }

                if(string.IsNullOrEmpty(txtFilter.Text))
                {
                    MessageBox.Show("Enter a number in the filter");
                    return true;
                }
                
                if(!(onlyNumbers(txtFilter.Text)))
                {
                    MessageBox.Show("Only Number Please");
                    return true;
                }
                
            }
            return false;
        }
        private bool onlyNumbers(string chain)
        {
            foreach(char caracter in chain)
            {
                if (!(char.IsNumber(caracter) || caracter == '.'))
                    return false;
            }
            return true;
        }
    }

}
