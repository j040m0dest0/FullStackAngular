using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entiti
{
    public class Base : Notifica
    {
        [Display(Name= "Código")]
        public int Id { get; set; }

        [Display(Name= "Name")]
        public string Name { get; set; }
    }
}
