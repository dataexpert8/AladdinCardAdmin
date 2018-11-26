using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasketWebPanel.ViewModels
{
    public class AddBoxViewModel : BaseViewModel
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        
        public SelectList Categories { get; internal set; }

        public int Category_Id { get; set; }

    }

    public class Video
    {
        [Url]
        public string VideoUrl { get; set; }
    }
}