using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExoApi.Models
{
    [Table("tb_usuarios")]
    public class Usuario
    {
        [Key]
        [Column("cd_usuario")]
        public int id { get; set; }
        
        [Column("ds_email")]
        public string email { get; set; }

        [Column("ds_senha")]
        public string senha { get; set; }
        
    }
}