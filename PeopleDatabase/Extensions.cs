using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDatabase.Extensions
{
  public static class Extensions
  {
    public static string GetNameSurname(this Person p)
    {
      return GetNameSurname(p, " ");
    }

    public static string GetNameSurname(this Person p, string separator)
    {
      return p.Name + separator + p.Surname;
    }
  }
}
