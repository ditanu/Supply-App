using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paw_project2._0
{
    public partial class MainForm : Form
    {
        private List<Contract> contracts = new List<Contract>();
        private List<Provider> providers = new List<Provider>();
        private List<Material> materials = new List<Material>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void addMaterial_Click(object sender, EventArgs e)
        {
            AddMaterial addMaterial = new AddMaterial(materials);
            addMaterial.Show();
        }

        private void btnSeeMaterials_Click(object sender, EventArgs e)
        {
            lvMaterials.Items.Clear();
            foreach (Material m in materials)
            {
                ListViewItem listViewItem = new ListViewItem(m.Name);
                listViewItem.SubItems.Add(m.Price.ToString());
                lvMaterials.Items.Add(listViewItem);
            }
        }

        private void addProvider_Click(object sender, EventArgs e)
        {
            AddProvider addProvider = new AddProvider(materials, providers);
            addProvider.Show();
        }

        private void tbSeeProviders_Click(object sender, EventArgs e)
        {
            lvProviders.Items.Clear();
            foreach (Provider p in providers)
            {
                ListViewItem listViewItem = new ListViewItem(p.Name);
                listViewItem.SubItems.Add(p.Founded.ToString());
                listViewItem.SubItems.Add(p.AfisareMateriale());
                lvProviders.Items.Add(listViewItem);
            }
        }

        private void addContract_Click(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract(contracts, providers);
            addContract.Show();
        }

        private void btnSeeContracts_Click(object sender, EventArgs e)
        {
            lvContracts.Items.Clear();
            foreach (Contract c in contracts)
            {
                ListViewItem listViewItem = new ListViewItem(c.Provider.Name);
                listViewItem.SubItems.Add(c.SignDate.ToString());
                listViewItem.SubItems.Add(c.Validity.ToString());
                listViewItem.SubItems.Add(c.Worth.ToString());
                lvContracts.Items.Add(listViewItem);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportToolStripMenuItem.ForeColor = Color.Black;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File | *.csv";
            saveFileDialog.Title = "Export CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("\"Id \", \"Provider name\", \"Signing date\", \"Validity\", \"Worth\"");


                    foreach (Contract contract in contracts)
                    {
                        writer.WriteLine($"\"{contract.Id}\",\"{contract.Provider.Name}\",\"{contract.SignDate}\",\"{contract.Validity}\",\"{contract.Worth}\"");
                    }
                }
            }
        }

        private void saveTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Contract c in contracts)
                {
                    sw.WriteLine(c.ToString());
                }
                sw.Close();
            }
        }

        private void saveBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // BinaryFormatter bf = new BinaryFormatter();
            // FileStream fs = new FileStream("fisier.dat", FileMode.Create,
            //FileAccess.Write);
            // //bf.Serialize(fs, textBox1.Text);
            // bf.Serialize(fs, contracts);
            // fs.Close();
            // lvContracts.Clear();

            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere materiale (.mtr)|.mtr";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Contract> lista = new List<Contract>();
                foreach (ListViewItem lv in lvContracts.Items)
                    lista.Add((Contract)lv.Tag);

                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);

                serializator.Serialize(fisier, lista);
                fisier.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }


        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }
    }
}
