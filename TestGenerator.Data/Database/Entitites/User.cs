using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.Data.Database.Entitites
{
    [Table("USERS")]
    public class User
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [DisplayName("USER_ID")]
        public int UserID { get; set; }

        [Required]
        [DisplayName("REGISTRATION_NUMBER")]
        public string RegistrationNumber { get; set; }

        [Required]
        [DisplayName("USER_CI")]
        public string UserCI { get; set; }

        [Required]
        [DisplayName("NAMES")]
        public string Names { get; set; }

        [Required]
        [DisplayName("FIRST_NAME")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("LAST_NAME")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("CLASSROOM")]
        public char Classroom { get; set; }

        public byte[] Image { get; set; }
    }
}
