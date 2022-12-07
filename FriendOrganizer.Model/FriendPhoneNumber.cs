using System;
using System.ComponentModel.DataAnnotations;

namespace FriendOrganizer.Model
{
    public class FriendPhoneNumber
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Phone]
        [Required]
        public string Number { get; set; }
        public Guid FriendId { get; set; }
        public Friend Friend { get; set; }
    }
}
