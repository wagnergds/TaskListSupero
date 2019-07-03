using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskListSupero.Models
{
    public class TaskViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Data Prevista")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }

        public bool Status { get; set; }

        [Display(Name = "Descriçao")]
        public string Description { get; set; }
        
    }
}