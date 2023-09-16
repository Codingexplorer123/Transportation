using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationEntity
{
    public class MyUser :IdentityUser
    {
       
        public long TCNo { get; set; }

    }
}
