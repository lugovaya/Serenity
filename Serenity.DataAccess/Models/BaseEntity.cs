﻿using System.ComponentModel.DataAnnotations;

namespace Serenity.DataAccess.Models
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }

    public class BaseEntity : BaseEntity<int>
    {
    }
}