using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MsmqManager.Web.Models
{
    public class QueueModel
    {
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int AmountMessages { get; set; }
        public string Name { get; set; }

        public QueueModel(string name, int amountMessages)
        {
            this.Name = name;
            this.AmountMessages = amountMessages;
        }
    }
}