﻿using BookManagementDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementDomain.Models.Entities
{
    public class Book: IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }

        public string ISBN { get; set; }
        public DateTime Created { get; set; }
    }
}
