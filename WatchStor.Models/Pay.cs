﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchStor.Models
{
    public class Pay
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title {  get; set; }
        [Required]
        public DateTime Time {  get; set; }
        [Required]
        public int price {  get; set; }
        

    }
}
