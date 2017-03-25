using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DCPortfolio.Models;



namespace DCPortfolio.Models
{
    public class IndexVM
    {


        public string Nome { get; set; }
        public string Morada { get; set; }
        public List<Users> UserList { get; set; }
        public List<Portfolios> PortfolioList { get; set; }
        public List<Categories> CategoriesList { get; set; }
    }

    public class Users
    {
        public string UName { get; set; }
        public string Email { get; set; }
        public string Ubio { get; set; }
    }

    public class Portfolios
    {
        public int PFid { get; set; }
        public string PFTitle { get; set; }
        public string PFDescription { get; set; }
        public int PFCategoryId { get; set; }
        public string PFCategory { get; set; }
        public string PFUserId { get; set; }
        public string PFImage { get; set; }
        public string PFImagedescription { get; set; }
        public string PFContent { get; internal set; }

        public class ExampleClass
        {
            // This attributes allows your HTML Content to be sent up
            [AllowHtml, UIHint("tinymce_jquery_full")]
            public string PFContent { get; set; }

            public ExampleClass()
            {

            }
        }


}
    public class Categories
    {
        public string CatName { get; set; }
        public string CatDescription { get; set; }

    }

    
}