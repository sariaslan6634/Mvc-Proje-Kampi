﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class Heading
	{
        [Key]
        public int HeadingID { get; set; }

		[StringLength(50)]
		public string HeadingName { get; set; }

        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; }
		public virtual Category Category { get; set; }

        public ICollection<Content> Contents { get; set; }

		public int? WriteId { get; set; }
		public virtual Writer Writer { get; set; }
    }
}
