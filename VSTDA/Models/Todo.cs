using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VSTDA.Models
{

    public class Todo
    {

        public Todo() { }
        //Properties

        public int Id { get; set; }

        [Required]
        public string Task { get; set; }

        [Required]
        public string Priority { get; set; }

    }

}