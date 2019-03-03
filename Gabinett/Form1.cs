using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Gabinett
{
    public partial class Pacjenci : MaterialSkin.Controls.MaterialForm
    {
        public Pacjenci()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Pacjenci' table. You can move, or remove it, as needed.
            this.pacjenciTableAdapter.Fill(this.databaseDataSet.Pacjenci);
            Edit(false);
        }
        private void Edit(bool value)
        {
            txtImieNazwisko.Enabled = value;
            txtPesel.Enabled = value;
            txtNumerTel.Enabled = value;
            txtAdres.Enabled = value;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                //Aktualizacja bazy danych do sql database
                Edit(false);
                pacjenciBindingSource.EndEdit();
                pacjenciTableAdapter.Update(databaseDataSet.Pacjenci);
                dataGridView.Refresh();
                txtImieNazwisko.Focus();
                MessageBox.Show("Dane zostały poprawnie zapisane.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                databaseDataSet.Pacjenci.RejectChanges();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                //Dodawanie nowego obiektu do binding source
                Edit(true);
                databaseDataSet.Pacjenci.AddPacjenciRow(databaseDataSet.Pacjenci.NewPacjenciRow());
                pacjenciBindingSource.MoveLast();
                txtImieNazwisko.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                databaseDataSet.Pacjenci.RejectChanges();
            }
        }
       
        private void btnEdytuj_Click(object sender, EventArgs e)
        { //pozwal na edycje w sql data base
            Edit(true);
            txtImieNazwisko.Focus();
        }
        private void btnAnuluj_Click(object sender, EventArgs e)
        {        //anuluje wykonywana czynnosc

            Edit(true);
            txtImieNazwisko.Focus();
        }

     

        private void Pacjenci_KeyDown(object sender, KeyEventArgs e)
        {
            //Usuwanie pacjentów  z sql database
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    pacjenciBindingSource.RemoveCurrent();
            }
        }
    }
}
