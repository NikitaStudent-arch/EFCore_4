using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_4.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string? Bio { get; set; }
        public string? AvatarUrl { get; set; }
        public int UserId { get; set; }
        // 1 : 1
        //Navigation property
        public virtual User? User { get; set; }
    }
}
