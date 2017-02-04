using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicModelForm.Models
{
    public class StudentModel
    {
        [Required]
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Tutor { get; set; }
        public List<SubjectModel> Subjects { get; set; }
    }

    public class SubjectModel
    {
        [Required]
        public string Subject { get; set; }
    }
}