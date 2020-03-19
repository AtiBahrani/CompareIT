﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class Wishlist
    {
        public Wishlist()
        {
            AddWish(new UserWish { URL = "link is this", ID = Username, Title = "iujhghjk" });
        }
        public string Username { get; set; }
        public List<UserWish> wishlist { get; set; } = new List<UserWish>();

        public void AddWish(UserWish wish)
        {
            wishlist.Add(wish);
        }
        public void DeleteWish(UserWish wish)
        {
            wishlist.Remove(wish);
        }

    }
}
