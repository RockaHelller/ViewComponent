using System.ComponentModel.DataAnnotations;

namespace OneToMany.Areas.Admin.ViewModels.Category
{
    public class CategoryCreateVM
    {
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
