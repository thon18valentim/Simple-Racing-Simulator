using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
  [Serializable]
  public class Email
  {
    // Core Email Attributes
    public int Id { get; set; }
    public string Mandatory { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Date { get; set; }

    // Email Visualization Attributes
    public bool Display = false;
    public bool Read = false;

    // Constructor
    public Email(int id, string mandatory, string subject, string body, string date)
    {
      Id = id;
      Mandatory = mandatory;
      Subject = subject;
      Body = body;
      Date = date;
    }

    // Returning if email is displaying
    public bool IsDisplay()
    {
      return Display;
    }
    // Return if email was red
    public bool IsRead()
    {
      return Read;
    }
    // Set Display true or false
    public void setDisplay(bool display)
    {
      this.Display = display;
    }
    // Set Read true or false
    public void setRead(bool read)
    {
      this.Read = read;
    }
  }
}
