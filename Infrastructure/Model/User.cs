using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Model
{
    [Table("user")]
    [Comment("用户信息")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public string Id { get; set; }

        [StringLength(20)]
        [Column("account")]
        [Comment("账号")]
        public string Account { get; set; }

        [Required]
        [StringLength(30)]
        [Column("username")]
        [Comment("用户名")]
        public string UserName { get; set; }

        [Required]
        [StringLength(30)]
        [Column("pwd")]
        [Comment("密码")]
        public string Pwd { get; set; }
    }
}
