using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace FriendOrganizer.Model
{
    public class Meeting
    {
        public Meeting()
        {
            Friends = new Collection<Friend>();
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(120)]
        public string Title { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public ICollection<Friend> Friends { get; set; }
    }

    
}
