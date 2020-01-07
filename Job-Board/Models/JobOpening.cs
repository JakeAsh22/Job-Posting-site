using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string ContactInfo { get; set; }

    public JobOpening(string title, string description, string contactInfo)
    {
        Title = title;
        Description = description;
        ContactInfo = contactInfo;
    }
  }
}