﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entites.Concrete
{
    //Çıplak Class Kalmasın
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }



    }
}
