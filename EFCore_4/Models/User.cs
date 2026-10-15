using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_4.Models
{
    public class User
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        // 1 : 1
        //Navigation property
        public virtual Profile? Profile { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }
    }
}
