﻿using System;
using System.Collections.Generic;

#nullable disable

namespace app.Models
{
    public partial class Document
    {
        public Document()
        {
            Authors = new HashSet<Author>();
        }

        public long IdDocument { get; set; }
        public string Source { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long IdDocumentType { get; set; }
        public bool Published { get; set; }

        public virtual DocumentType IdDocumentTypeNavigation { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}