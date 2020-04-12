using SQLite;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBN.Models
{
   public class Account
    {
        [PrimaryKey]
        private string Nume { get; set;}
        private string Data { get; set; }
        private string Informatii { get; set; }
        private string Localitate { get; set; }


}
}
