using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paw_project2._0
{
    public partial class AddMaterial : Form
    {
        List<Material> materials;
        public AddMaterial(List<Material> materials)
        {
            this.materials = materials; 
            InitializeComponent();
            tbPrice.KeyPress += new KeyPressEventHandler(verifCifre_KeyPress);

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
            if (tbPrice.Text == "")
                errorProvider1.SetError(tbPrice, "Introduceti pretul");
          
            else
            {
                errorProvider1.Clear();
                try
                {
                    string name = tbName.Text;
                    int price = Convert.ToInt32(tbPrice.Text);
                 
                    Material m = new Material(name, price);
                    MessageBox.Show("Material adaugat cu succes!");
                    materials.Add(m);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbName.Clear(); 
                    tbPrice.Clear();
                }
            }
        }

    }
}
