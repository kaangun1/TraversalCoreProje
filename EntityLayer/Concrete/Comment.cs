using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Comment
{
    [Key] 
    public int CommentID { get; set; }
    public string CommentUser { get; set; }
    public DataType? CommentDate { get; set; }
    public string VommentContent { get; set; }
    public bool CommentState { get; set; }
    public int DestinationID { get; set; }
    public Destination Destination { get; set; }
}