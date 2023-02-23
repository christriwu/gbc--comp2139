using System.ComponentModel.DataAnnotations;

namespace Assignment_1.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage = "Item Name required")]
        public string? ItemName { get; set; }
        [Required(ErrorMessage = "Item Description required")]
        public string? ItemDescription { get; set; }

        [Required(ErrorMessage = "Minimum Cost/Bid amount required")]
        public double? MinCost { get; set; }

        [Required(ErrorMessage = "Opening Date required")]
        public DateTime? OpeningDate { get; set; }
        [Required(ErrorMessage = "Closing Date required")]
        public DateTime? ClosingDate { get; set; }
        [Required(ErrorMessage = "Asset condition required")]
        public string? Condition { get; set; }
        [Required(ErrorMessage = "Item Category required")]
        public string? Category { get; set; }
        [Required(ErrorMessage = "Item Image required")]
        public string? Image { get; set; }

    }
}
