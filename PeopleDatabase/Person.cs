using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDatabase
{
  [DataObject]
  public class Person
  {
    public string Name { get; set; }
    public string Surname { get; set; }

    private int _Age;
    public int Age {
      get => this._Age;
      set => this._Age = Math.Max(value, 0); }

    public string GetNameSurname()
    {
      return Surname + ", " + Name;
    }
  }
}
