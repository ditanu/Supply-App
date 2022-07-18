using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paw_project2._0
{
    public partial class AddContract : Form
    {
        private List<Contract> contracts;
        private List<Provider> providers;


        public AddContract(List<Contract> contracts, List<Provider> providers)
        {
            this.contracts = contracts;
            this.providers = providers;
            InitializeComponent();
            tbValidity.KeyPress += new KeyPressEventHandler(verifCifre_KeyPress);
            tbWorth.KeyPress += new KeyPressEventHandler(verifCifre_KeyPress);
        }

        private void verifCifre_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            foreach (Provider provider in providers)
            {
                cbProvider.Items.Add(provider.Name);
            }
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            if (cbProvider.Text == "")
                errorProvider1.SetError(cbProvider, "Introduceti un provider!");
            else
           if (tbValidity.Text == "")
                errorProvider1.SetError(tbValidity, "Introduceti valididatea contractului");
           if (tbWorth.Text == "")
                errorProvider1.SetError(tbValidity, "Introduceti valoarea contractului");

            else
            {
                errorProvider1.Clear();
                try
                {
                    Provider provider = new Provider();
                    foreach (Provider p in providers)
                    {
                        if (cbProvider.Text == p.Name)
                        {
                            provider = p;
                        }
                    }

                    DateTime date = dtpSigningDate.Value;
                    long validity = Convert.ToInt32(tbValidity.Text);
                    long worth = Convert.ToInt32(tbWorth.Text);

                    Contract c = new Contract(provider, date,validity, worth);
                    MessageBox.Show("Contract adaugat cu succes!");
                    contracts.Add(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbWorth.Clear();
                    tbValidity.Clear();
                }
            }
        }
    }
}
