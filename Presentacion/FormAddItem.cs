using dominio;
using negocio;
using System;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace Presentacion
{
    public partial class FormAddItem : Form
    {
        private OpenFileDialog file = null;
        private Items item = null;
        public FormAddItem()
        {
            InitializeComponent();
            Text = "Add Item";
        }
        public FormAddItem(Items item)
        {
            InitializeComponent();
            this.item = item;
            Text = "Modify Item";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ItemNegocio negocio = new ItemNegocio();
            try
            {
                eraseProvider();
                if (validateFields())
                {
                    if (item == null)
                        item = new Items();

                    item.Name = txtName.Text;
                    item.ItemCode = txtCode.Text;
                    item.Description = txtDescription.Text;
                    item.UrlImage = txtUrlImage.Text;
                    item.Price = decimal.Parse(txtPrice.Text);
                    item.TradeDesciption = (Trademarks)cbxTrademark.SelectedItem;
                    item.CategoryDescription = (Category)cbxCategory.SelectedItem;

                    if (item.Id != 0)
                    {
                        negocio.modify(item);
                        MessageBox.Show("Modificado Exitosamente");
                    }
                    else
                    {
                        negocio.add(item);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    if(file!=null && !(txtUrlImage.Text.ToUpper().Contains("HTTP")))
                        File.Copy(file.FileName, ConfigurationManager.AppSettings["images-folder"] + file.SafeFileName);


                    Close();


                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
            TrademarkNegocio tradeNegocio = new TrademarkNegocio();
            CategoryNegocio categoryNegocio = new CategoryNegocio();
            try
            {
                cbxTrademark.DataSource = tradeNegocio.listar();
                cbxTrademark.ValueMember = "TradeId";
                cbxTrademark.DisplayMember = "TradeDescription";

                cbxCategory.DataSource = categoryNegocio.listar();
                cbxCategory.ValueMember = "CategoryId";
                cbxCategory.DisplayMember = "CategoryDescription";

                if (item != null)
                {

                    txtCode.Text = item.ItemCode;
                    txtName.Text = item.Name;
                    txtDescription.Text = item.Description;
                    txtUrlImage.Text = item.UrlImage;
                    txtPrice.Text = item.Price.ToString();
                    cbxCategory.SelectedValue = item.CategoryDescription.CategoryId;
                    cbxTrademark.SelectedValue = item.TradeDesciption.TradeId;
                    if (!string.IsNullOrEmpty(txtUrlImage.Text))
                        loadImage(txtUrlImage.Text);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        public void loadImage(string image)
        {
            try
            {
                pbxAddImage.Load(image);
            }
            catch (Exception)
            {

                pbxAddImage.Load("https://i0.wp.com/elfutbolito.mx/wp-content/uploads/2019/04/image-not-found.png?ssl=1");
            }
        }

        private void txtUrlImage_Leave(object sender, EventArgs e)
        {
            loadImage(txtUrlImage.Text);
        }
        private bool validateFields()
        {
            bool ok = true;
            if (txtCode.Text == "")
            {
                errorProviderCode.SetError(txtCode, "Enter a Code");
                ok = false;
            }
            if (txtName.Text == "")
            {
                errorProviderCode.SetError(txtName, "Enter a Name");
                ok = false;
            }
            if (txtDescription.Text == "")
            {
                errorProviderCode.SetError(txtDescription, "Enter a Description");
                ok = false;
            }
            if (txtUrlImage.Text == "")
            {
                errorProviderCode.SetError(txtUrlImage, "Enter an Url Image");
                ok = false;
            }
            if (txtPrice.Text == "")
            {
                errorProviderCode.SetError(txtPrice, "Enter a decimal Price");
                ok = false;
            }
            if (!onlyNumbers(txtPrice.Text))
            {
                errorProviderCode.SetError(txtPrice, "Enter Only decimal Numbers");
                ok = false;
            }
            return ok;
        }
        private bool onlyNumbers(string chain)
        {
            decimal val = 0;
            if (Decimal.TryParse(chain, out val))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        private void eraseProvider()
        {
            errorProviderCode.SetError(txtCode, "");
            errorProviderCode.SetError(txtName, "");
            errorProviderCode.SetError(txtDescription, "");
            errorProviderCode.SetError(txtUrlImage, "");
            errorProviderCode.SetError(txtPrice, "");
        }
        private void btnAddImage_Click_1(object sender, EventArgs e)
        {
            file= new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtUrlImage.Text = file.FileName;
                loadImage(file.FileName);

            }

        }
    }
}
