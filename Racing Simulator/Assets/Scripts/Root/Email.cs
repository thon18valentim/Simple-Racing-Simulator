using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    
  public class Email
  {
    public int Id { get; set; }
    public string Mandatory { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Date { get; set; }

    // Constructor
    public Email(int id, string mandatory, string subject, string body, string date)
    {
      Id = id;
      Mandatory = mandatory;
      Subject = subject;
      Body = body;
      Date = date;
    }
  }
}
