using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SosialMediaId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

    }
}
