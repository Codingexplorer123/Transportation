using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationEntity
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; } = new HashSet<User>();

        // Hashset kullandim siralama onemli degil stackoverflowda listeye gore daha performansli oldugu soyleniyor.Birde tabi ayni degerde iki 
        //veriyi listeye eklemiyor.Burdaki kullanicilarda birbirinden farkli olacak.
        //https://stackoverflow.com/questions/4558754/define-what-is-a-hashset
    }
}
