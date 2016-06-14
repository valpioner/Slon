using Slon.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slon.Model
{
    public class User
    {
        public int Id { get; set; }
        
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public byte[] Img { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        public bool IsEmailVerified { get; set; }

        [Required]
        public UserGender GenderId { get; set; }
        
        [Required]
        public UserRole RoleId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}