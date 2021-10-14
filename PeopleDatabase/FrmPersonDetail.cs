using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleDatabase.Extensions;

namespace PeopleDatabase
{
  public partial class FrmPersonDetail : Form
  {
    public FrmPersonDetail()
    {
      InitializeComponent();
    }

    public Person SelectedPerson
    {
      get
      {
        return this.propertyGrid.SelectedObject as Person;
      }
      set
      {
        this.propertyGrid.SelectedObject = value;
        this.personBindingSource.DataSource = value;
        this.txtNameSurname.Text = value.GetNameSurname("; ");
      }
    }
  }
}
