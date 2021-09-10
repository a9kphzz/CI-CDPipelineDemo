using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LoginDemoforAWS.Context
{
    [Keyless]
    [Table("UserInfo")]
    public partial class UserInfo
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(20)]
        public string PassWord { get; set; }
    }
}
