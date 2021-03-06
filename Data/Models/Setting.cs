using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Data
{
    public class Setting
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string DefaultLanguage { get; set; }
        public string Logo { get; set; }
        public List<Culture> Cultures { get; set; }
        public Setting()
        {
            Cultures = new List<Culture>();
        }
    }
}