using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Titan.Core.Domain.Entities;
using Titan.Data;

namespace Titan.WinForms.Views
{
    public partial class CustomerView : DevExpress.XtraEditors.XtraForm
    {
        private readonly TitanContext _context;
        public Customer EditCustomer = null;
        public CustomerView(TitanContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private async void simpleButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditCustomer == null)
                {
                    var customer = new Customer();
                    customer.Code = textEditCode.Text;
                    customer.Definition = textEditDefinition.Text;
                    customer.Definition2 = textEditDefinition2.Text;
                    customer.Address1 = textEditAddress1.Text;
                    customer.Address2 = textEditAddress2.Text;
                    customer.District = textEditDistrict.Text;
                    customer.Town = textEditTown.Text;
                    customer.City = textEditCity.Text;
                    customer.Country = textEditCountry.Text;
                    customer.PhoneNumber = textEditPhoneNumber.Text;
                    customer.EmailAddress = textEditEmailAddress.Text;
                    customer.TaxNumber = textEditTaxNumber.Text;
                    customer.TaxOffice = textEditTaxOffice.Text;
                    customer.IsCompany = checkEditIsCompany.Checked ? false : true;
                    customer.TckNo = textEditTckNo.Text;
                    customer.Name = textEditName.Text;
                    customer.Surname = textEditSurname.Text;
                    customer.SpeCode = textEditSpeCode.Text;
                    customer.SpeCode2 = textEditSpeCode2.Text;
                    customer.SpeCode3 = textEditSpeCode3.Text;
                    customer.SpeCode4 = textEditSpeCode4.Text;
                    customer.SpeCode5 = textEditSpeCode5.Text;
                    customer.CyphCode = textEditCyphCode.Text;
                    customer.Incharge = textEditIncharge.Text;

                    _context.Customers.Add(customer);
                    await _context.SaveChangesAsync();

                    XtraMessageBox.Show("Kayıt başarıyla oluşturuldu.");
                }
                else
                {
                    EditCustomer.Code = textEditCode.Text;
                    EditCustomer.Definition = textEditDefinition.Text;
                    EditCustomer.Definition2 = textEditDefinition2.Text;
                    EditCustomer.Address1 = textEditAddress1.Text;
                    EditCustomer.Address2 = textEditAddress2.Text;
                    EditCustomer.District = textEditDistrict.Text;
                    EditCustomer.Town = textEditTown.Text;
                    EditCustomer.City = textEditCity.Text;
                    EditCustomer.Country = textEditCountry.Text;
                    EditCustomer.PhoneNumber = textEditPhoneNumber.Text;
                    EditCustomer.EmailAddress = textEditEmailAddress.Text;
                    EditCustomer.TaxNumber = textEditTaxNumber.Text;
                    EditCustomer.TaxOffice = textEditTaxOffice.Text;
                    EditCustomer.IsCompany = checkEditIsCompany.Checked ? false : true;
                    EditCustomer.TckNo = textEditTckNo.Text;
                    EditCustomer.Name = textEditName.Text;
                    EditCustomer.Surname = textEditSurname.Text;
                    EditCustomer.SpeCode = textEditSpeCode.Text;
                    EditCustomer.SpeCode2 = textEditSpeCode2.Text;
                    EditCustomer.SpeCode3 = textEditSpeCode3.Text;
                    EditCustomer.SpeCode4 = textEditSpeCode4.Text;
                    EditCustomer.SpeCode5 = textEditSpeCode5.Text;
                    EditCustomer.CyphCode = textEditCyphCode.Text;
                    EditCustomer.Incharge = textEditIncharge.Text;
                    await _context.SaveChangesAsync();
                    XtraMessageBox.Show("Kayıt başarıyla güncellendi.");
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            if (EditCustomer != null)
            {
                textEditCode.Text = EditCustomer.Code;
                textEditDefinition.Text = EditCustomer.Definition;
                textEditDefinition2.Text = EditCustomer.Definition2;
                textEditAddress1.Text = EditCustomer.Address1;
                textEditAddress2.Text = EditCustomer.Address2;
                textEditDistrict.Text = EditCustomer.District;
                textEditTown.Text = EditCustomer.Town;
                textEditCity.Text = EditCustomer.City;
                textEditCountry.Text = EditCustomer.Country;
                textEditPhoneNumber.Text = EditCustomer.PhoneNumber;
                textEditEmailAddress.Text = EditCustomer.EmailAddress;
                textEditTaxNumber.Text = EditCustomer.TaxNumber;
                textEditTaxOffice.Text = EditCustomer.TaxOffice;
                checkEditIsCompany.Checked = EditCustomer.IsCompany ? false : true;
                textEditTckNo.Text = EditCustomer.TckNo;
                textEditName.Text = EditCustomer.Name;
                textEditSurname.Text = EditCustomer.Surname;
                textEditSpeCode.Text = EditCustomer.SpeCode;
                textEditSpeCode2.Text = EditCustomer.SpeCode2;
                textEditSpeCode3.Text = EditCustomer.SpeCode3;
                textEditSpeCode4.Text = EditCustomer.SpeCode4;
                textEditSpeCode5.Text = EditCustomer.SpeCode5;
                textEditCyphCode.Text = EditCustomer.CyphCode;
                textEditIncharge.Text = EditCustomer.Incharge;
            }
        }
    }
}