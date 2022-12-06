namespace CinmaTickets.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "Movie Image")]

        public string ImageURL { get; set; }
        [Display(Name = "Start Date")]

        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]

        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<Actor_Movie> Actor_Movie { get; set; } = new List<Actor_Movie>();
        [ForeignKey("Producer")]
        public int ProducerId { get; set; }
        public virtual Producer Producer { get; set; }
        [ForeignKey("Cinema")]
        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }


    }
}
