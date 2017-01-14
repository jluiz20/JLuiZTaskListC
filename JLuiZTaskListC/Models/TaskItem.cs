using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JLuiZTaskListC.Models
{
    [Table("TaskItem")]
    public class TaskItem
    {
        /// <summary>
        /// The id of the task
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        /// <summary>
        /// Title of the task
        /// </summary>
        [Required]
        [MaxLength(255), MinLength(1)]
        public String Title { get; set; }

        /// <summary>
        /// Aditional description to the task
        /// </summary>
        [MaxLength(1024), MinLength(0)]
        public String Description { get; set; }

        /// <summary>
        /// Indicates that the Task is done or not
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// The date that the task is due
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The date that the task was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

    }
}