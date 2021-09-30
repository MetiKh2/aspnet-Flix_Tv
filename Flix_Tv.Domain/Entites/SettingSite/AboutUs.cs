﻿using Flix_Tv.Domain.Entites.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flix_Tv.Domain.Entites.SettingSite
{
   public class AboutUs:BaseEntity
    {  
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }
        public string Text { get; set; }

    }
}
