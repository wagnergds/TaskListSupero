namespace TaskListSupero.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TaskListSupero.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskListSupero.Models.TaskListSuperoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskListSupero.Models.TaskListSuperoContext context)
        {
            Task[] tasks =
            {
                new Task {Title = "Projeto Gerenciador de Tarefa", Description = "Criar Gerenciador de Tarefas", DueDate = DateTime.Parse("03/06/2019"), Status = true}
            };

            context.Tasks.AddOrUpdate(t => t.Description, tasks);
        }
    }
}
