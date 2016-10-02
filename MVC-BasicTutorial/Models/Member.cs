using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_BasicTutorial.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberAddress { get; set; }
        public int MemberAge { get; set; }

    }
}