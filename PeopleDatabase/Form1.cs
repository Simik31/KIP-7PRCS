using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDatabase
{
  public partial class Form1 : Form
  {
    public List<Person> people = new List<Person>();

    public Form1()
    {
      InitializeComponent();

      people.Add(new Person
      {
        Name = "John",
        Surname = "Doe",
        Age = 38
      });

      people.Add(new Person
      {
        Name = "Jane",
        Surname = "Doe",
        Age = 33
      });
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.personBindingSource.DataSource = people;
    }

    private void grd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      Person person = this.people[e.RowIndex];

      FrmPersonDetail frm = new FrmPersonDetail();
      frm.SelectedPerson = person;
      frm.Show();
    }
  }
}
