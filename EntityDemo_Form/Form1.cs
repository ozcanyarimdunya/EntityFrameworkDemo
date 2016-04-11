using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDemo_Form
{
    public partial class Form1 : Form
    {
        DemoModel db = new DemoModel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void Listele()
        {
            var liste = from k in db.People
                orderby k.id ascending
                select new
                {
                    Id = k.id,
                    Name = k.name
                };
            dtGrid.DataSource = liste.ToList();
        }

        private void Temizle()
        {
            txtKaydet.Text = "";
            txtAra.Text = "";
            txtDegistir.Text = "";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.name = txtKaydet.Text;
            db.People.Add(p);
            db.SaveChanges();
            Temizle();
            Listele();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtGrid.CurrentRow.Cells["Id"].Value.ToString());
            var person = db.People.FirstOrDefault(x => x.id == id);
            person.name = txtDegistir.Text;
            db.SaveChanges();
            Temizle();
            Listele();
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDegistir.Text = dtGrid.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtGrid.CurrentRow.Cells["Id"].Value.ToString());
            var person = db.People.FirstOrDefault(x => x.id == id);
            db.People.Remove(person);
            db.SaveChanges();
            Temizle();
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string text = txtAra.Text;
            var liste = from p in db.People
                where p.name.Contains(text)
                orderby p.id ascending
                select p;
            dtGrid.DataSource = liste.ToList();
        }

    }
}
