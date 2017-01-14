using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JLuiZTaskListC.Models
{
    public class MyContext: DbContext
    {
        public MyContext() : base("name=MyContext")
        {
        }

        public System.Data.Entity.DbSet<JLuiZTaskListC.Models.TaskItem> TaskItems { get; set; }
    }
}