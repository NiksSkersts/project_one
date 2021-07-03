﻿using System;
using System.Collections.Generic;

#nullable disable

namespace server.Models
{
    public partial class User
    {
        public User()
        {
            Quotes = new HashSet<Quote>();
            RecipeUserIndices = new HashSet<RecipeUserIndex>();
            SocialMediaRefs = new HashSet<SocialMediaRef>();
        }

        public Guid IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long? IdEmail { get; set; }
        public long? IdPicture { get; set; }

        public virtual UserEmail IdEmailNavigation { get; set; }
        public virtual Picture IdPictureNavigation { get; set; }
        public virtual UserLoginDatum UserLoginDatum { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<RecipeUserIndex> RecipeUserIndices { get; set; }
        public virtual ICollection<SocialMediaRef> SocialMediaRefs { get; set; }
    }
}
