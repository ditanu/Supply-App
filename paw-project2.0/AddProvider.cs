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
    public partial class AddProvider : Form
    {
        private List<Material> materials = new List<Material>();
        private List<Provider> providers = new List<Provider>();
        public AddProvider(List<Material> materials, List<Provider> providers)
        {
            InitializeComponent();
            this.materials = materials;
            this.providers = providers;
            tbFounded.KeyPress += new KeyPressEventHandler(verifCifre_KeyPress);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
                errorProvider1.SetError(tbName, "Introduceti numele!");
            else
          if (tbFounded.Text == "")
                errorProvider1.SetError(tbFounded, "Introduceti anul!");
            else
            if (clbMaterials.CheckedItems.Count == 0)
                errorProvider1.SetError(clbMaterials, "Introduceti materiale");

            else
            {
                errorProvider1.Clear();
                try
                {
                    string name = tbName.Text;
                    int founded = Convert.ToInt32(tbFounded.Text);
                    List<Material> selectedMaterials = new List<Material>();

                    foreach (string s in clbMaterials.CheckedItems)
                    {
                        foreach (Material mat in materials)
                        {
                            if (s == mat.Name)
                            {
                                selectedMaterials.Add(mat);
                            }
                        }
                    }

                    Provider p = new Provider(name, founded, selectedMaterials);
                    MessageBox.Show("Provider adaugat cu succes!");
                    providers.Add(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbName.Clear();
                    tbFounded.Clear();
                    clbMaterials.ClearSelected();
                }
            }
        }

        private void AddProvider_Load(object sender, EventArgs e)
        {
            foreach (Material material in materials)
            {
                clbMaterials.Items.Add(material.Name);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
