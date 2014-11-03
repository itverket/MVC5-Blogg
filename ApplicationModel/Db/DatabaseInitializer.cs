using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using ApplicationModel.Models;

namespace ApplicationModel.Db
{
    public class DatabaseInitializer : IDatabaseInitializer<ApplicationContext>
    {
        public void InitializeDatabase(ApplicationContext context)
        {
            context.AboutInformation.AddOrUpdate(new AboutInformation
            {
                AboutInformationId = 1,
                AboutMe = "ASP.NET MVC er fett!",
                BirthDate = new DateTime(1990, 1, 1),
                FirstName = "Bloggmann",
                LastName = "H"
            });

            context.Posts.AddOrUpdate(new Post
            {
                PostId = 1,
                Created = DateTime.Now,
                Edited = DateTime.Now,
                Title = "Mitt første blogg-innlegg",
                Introduction = "...og selvfølgelig er det lorem ipsum",
                Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Comments = new List<Comment>()
            });

            context.SaveChanges();
        }
    }
}