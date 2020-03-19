using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using UserAPI.Model;

namespace UserAPI
{
    public class UserLogic
    {
        private Client_CSharp client { get; set; }
        private bool loggedIn;
        private bool WishIsRegistered;

        public UserLogic()
        {
            this.client = new Client_CSharp();
            this.loggedIn = false;
        }
        public void RegisterUser(User user)
        {
            client.SendUser(user);
        }

        public void RegisterWish(UserWish userWish)
        {
            client.SendWish(userWish); //check if the Link already is added to user's wishlist
            /*if (client.ReciveVerification().Equals(true))// Link is not added
            {
                WishIsRegistered = true;
            }
            else
            {
                WishIsRegistered = false;
            }
            return WishIsRegistered;*/
        }





        public void DeleteWish(UserWish userWish) // the user has selected a wish from her/his wishlist
        {
            client.SendDelete(userWish);

        }
        public List<UserWish> Login(Login login)
        {
            return client.SendLogin(login); // sending to be checked in tier 3
        }
    }
}