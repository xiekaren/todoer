namespace ToDoList.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoList.DAL.ToDoListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ToDoList.DAL.ToDoListContext";
        }

        protected override void Seed(ToDoList.DAL.ToDoListContext context)
        {
            var taskItems = new List<TaskItem>
            {
                new TaskItem { ScheduledTime =DateTime.Parse("2010-09-01"), Description = "Clean room", IsCompleted = false},
                new TaskItem { ScheduledTime =DateTime.Parse("2010-09-01"), Description = "Study", IsCompleted = false},
                new TaskItem { ScheduledTime =DateTime.Parse("2010-09-01"), Description = "Walk dog", IsCompleted = false}
            };

            taskItems.ForEach(s => context.TaskItems.AddOrUpdate(t => t.TaskItemID, s));
            context.SaveChanges();
        }
    }
}
