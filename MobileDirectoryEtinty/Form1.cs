using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileDirectoryEtinty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonDal _personDal=new PersonDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPersons();
        }

        private void LoadPersons()
        {
            dgwDirectory.DataSource = _personDal.Get();
        }

        private void btnPesonAdd_Click(object sender, EventArgs e)
        {
            _personDal.Add(new Person
            {
                FirstName = tbxFirstNameAdd.Text,
                LastName = tbxLastNameAdd.Text,
                GSM = Convert.ToInt32(tbxNumberAdd.Text)
            });
            LoadPersons();
            MessageBox.Show("Added");
        }

        private void dgwDirectory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxFirstNameUpdate.Text = dgwDirectory.CurrentRow.Cells[1].Value.ToString();
            tbxLastNameUpdate.Text = dgwDirectory.CurrentRow.Cells[2].Value.ToString();
            tbxNumberUpdate.Text = dgwDirectory.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnPersonUpdate_Click(object sender, EventArgs e)
        {
            _personDal.Update(new Person
            {
                Id = Convert.ToInt32(dgwDirectory.CurrentRow.Cells[0].Value),
                FirstName = tbxFirstNameUpdate.Text,
                LastName = tbxLastNameUpdate.Text,
                GSM = Convert.ToInt32(tbxNumberUpdate.Text)
            });
            LoadPersons();
            MessageBox.Show("Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _personDal.Delete(new Person
            {
                Id = Convert.ToInt32(dgwDirectory.CurrentRow.Cells[0].Value)
            });
            LoadPersons();
            MessageBox.Show("Deleted!");
        }
    }
}
