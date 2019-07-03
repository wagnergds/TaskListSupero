using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskListSupero.Models;

namespace TaskListSupero.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Task, TaskViewModel>().ReverseMap();
            });
        }
    }
}