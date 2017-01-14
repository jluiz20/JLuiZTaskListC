using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using JLuiZTaskListC.Models;

namespace JLuiZTaskListC.Controllers
{
    /// <summary>
    /// The controller responsible for handling task data
    /// </summary>
    public class TaskItemsController : ApiController
    {
        private MyContext db = new MyContext();
         /// <summary>
         /// Returns all the task unfiltered
         /// </summary>
         /// <returns></returns>
        // GET: api/TaskItems
        public IQueryable<TaskItem> GetTaskItems()
        {
            return db.TaskItems;
        }


        /// <summary>
        /// Get only the tasks with the desired status
        /// </summary>
        /// <param name="done">The desired status</param>
        /// <returns></returns>
        // GET: api/TaskItems
        public IQueryable<TaskItem> GetTaskItemsByStatus(bool done)
        {
            return from b in db.TaskItems
                   where b.Done == done
                   select b; 
        }


        /// <summary>
        /// Get an specific task by it's Id.
        /// </summary>
        /// <param name="id">The of the task desired</param>
        /// <returns></returns>
        // GET: api/TaskItems/5
        [ResponseType(typeof(TaskItem))]
        public IHttpActionResult GetTaskItem(int id)
        {
            TaskItem taskItem = db.TaskItems.Find(id);
            if (taskItem == null)
            {
                return NotFound();
            }

            return Ok(taskItem);
        }

       

        /// <summary>
        /// Updates the task
        /// </summary>
        /// <param name="id"> the id to be replaced</param>
        /// <param name="taskItem">the complete task to update</param>
        /// <returns></returns>
        // PUT: api/TaskItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTaskItem(int id, TaskItem taskItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taskItem.Id)
            {
                return BadRequest();
            }

            db.Entry(taskItem).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(taskItem);// StatusCode(HttpStatusCode.NoContent);
        }

        // PUT: api/TaskItems/5
        /// <summary>
        /// Updates the status to done or undone of an specific task
        /// </summary>
        /// <param name="id">The task that shall be updated</param>
        /// <param name="status">The new status of the task</param>
        /// <returns></returns>
        [ResponseType(typeof(TaskItem))]
        public IHttpActionResult PostTaskItemUpdateStatus(int id, bool done)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TaskItem taskItem = db.TaskItems.Find(id);
            if (taskItem == null)
            {
                return NotFound();
            }

            //Changes the status
            taskItem.Done = done;

            db.Entry(taskItem).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(taskItem); //StatusCode(HttpStatusCode.NoContent);
        }



        /// <summary>
        /// Inserts a new Task in the list
        /// </summary>
        /// <param name="taskItem">The task to be added</param>
        /// <returns></returns>
        // POST: api/TaskItems
        [ResponseType(typeof(TaskItem))]
        public IHttpActionResult PostTaskItem(TaskItem taskItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TaskItems.Add(taskItem);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = taskItem.Id }, taskItem);
        }

        

        /// <summary>
        /// Deletes a specific task by the ID
        /// </summary>
        /// <param name="id">The Id that shall be deleted</param>
        /// <returns></returns>
        // DELETE: api/TaskItems/5
        [ResponseType(typeof(TaskItem))]
        public IHttpActionResult DeleteTaskItem(int id)
        {
            TaskItem taskItem = db.TaskItems.Find(id);
            if (taskItem == null)
            {
                return NotFound();
            }

            db.TaskItems.Remove(taskItem);
            db.SaveChanges();

            return Ok(taskItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TaskItemExists(int id)
        {
            return db.TaskItems.Count(e => e.Id == id) > 0;
        }
    }
}