using System;
using System.ComponentModel.DataAnnotations;

namespace FriendOrganizer.Model
{
    public class ProgrammingLanguage
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
    }
}
