using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class About
    {
        [Key]
        public int AbouthId { get; set; }
        public string Title { get; set; }
        public string SubDescription { get; set; }
        public string Detail { get; set; }
    }
}
