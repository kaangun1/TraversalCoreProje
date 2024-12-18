using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Contact
{
    [Key]
    public int CotactID { get; set; }
    public string Description { get; set; }
    public string Mail { get; set; }
    public string Adress { get; set; }
    public string Phone { get; set; }
    public string MapLocation { get; set; }
    public bool Status { get; set; }
}