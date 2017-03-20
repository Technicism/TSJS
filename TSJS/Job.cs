using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSJS {
  class Job {
    public string id;
    public string cargo;
    public string sourceCity;
    public string sourceCompany;
    public string destinationCity;
    public string destinationCompany;
    public int distanceKilometres;
    public int distanceMiles;

    private const double KILOMETRES_TO_MILES = 0.621371;

    public Job(string job) {
      if (job.Contains("job_offer_data")) {
        id = Main.BetweenExclusive(job, "job_offer_data : ", " {");
        cargo = Main.BetweenExclusive(job, "cargo: ", "\r\n");
        if (cargo.Split('.').Count() == 2) {
          cargo = cargo.Split('.')[1];
        }
        string target = Main.BetweenExclusive(job, "target: \"", "\"");
        if (target.Split('.').Count() == 2) {
          destinationCity = target.Split('.')[1];
          destinationCompany = target.Split('.')[0];
        }
        distanceKilometres = int.Parse(Main.BetweenExclusive(job, "shortest_distance_km: ", "\r\n"));
        distanceMiles = (int)(Math.Round(distanceKilometres * KILOMETRES_TO_MILES));
      } else if (job.Contains("delivery_log_entry")) {
        id = Main.BetweenExclusive(job, "delivery_log_entry : ", " {");
        cargo = Main.BetweenExclusive(job, "params[3]: \"cargo.", "\"");
        string source = Main.BetweenExclusive(job, "params[1]: \"", "\"");
        if (source.Split('.').Count() == 4) {
          sourceCity = source.Split('.')[3];
          sourceCompany = source.Split('.')[2];
        }
        string destination = Main.BetweenExclusive(job, "params[2]: \"", "\"");
        if (source.Split('.').Count() == 4) {
          destinationCity = destination.Split('.')[3];
          destinationCompany = destination.Split('.')[2];
        }
        distanceKilometres = int.Parse(Main.BetweenExclusive(job, "params[6]: ", "\r\n"));
        distanceMiles = (int)(Math.Round(distanceKilometres * KILOMETRES_TO_MILES));
      }  
    }

    public void AddSource(string source) {
      sourceCity = source.Split('.')[3];
      sourceCompany = source.Split('.')[2];
    }

    public bool IsValid() {
      if (ToString().Contains('"') || destinationCity == null || sourceCity == null) {
        return false;
      }
      return true;
    }

    public override string ToString() {
      return sourceCity + " " + sourceCompany + " " + destinationCity + " " + destinationCompany + " " + cargo;
    }
  }
}
