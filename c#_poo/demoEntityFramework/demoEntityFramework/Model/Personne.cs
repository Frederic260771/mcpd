using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace demoEntityFramework.Model
{
    [Table("personne")]
    internal class Personne
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [Column]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]  
        [Column("age")]
        [Range(0,130)]
        public int Age { get; set; }

        [Phone]
        [Column("Phone")]
        [StringLength(10)]
        public string Phone { get; set; }

        public string Email { get; set; }

        public Personne() { }

        public Personne (string firstname,string lastname,int age,string phone,string email)
        { 
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Id}  firstname"; 
                }




    }
}
