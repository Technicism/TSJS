using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSJS {
  class Company {
    public string id;
    public string city;
    public string name;
    public bool discovered;
    public HashSet<string> offers = new HashSet<string>();

    public Company(string company) {
      id = Main.BetweenExclusive(company, "company : ", " {");
      int count = int.Parse(Main.BetweenExclusive(company, "job_offer: ", "\r\n"));
      for (int i = 0; i < count; i++) {
        string offer = Main.BetweenExclusive(company, "job_offer[" + i + "]: ", "\r\n");
        offers.Add(offer);
      }
      discovered = bool.Parse(Main.BetweenExclusive(company, "discovered: ", "\r\n"));
    }

    public override string ToString() {
      string str = id + " " + discovered;
      foreach (string offer in offers) {
        str += "  " + offer + "\r\n";
      }
      return str;
    }
  }
}
