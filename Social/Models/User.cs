using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Social
{
    public class User
    {
        public string password
        {
            get => default(string);
            set
            {
            }
        }

        public int userID
        {
            get => default(int);
            set
            {
            }
        }

        public string username
        {
            get => default(string);
            set
            {
            }
        }

        public Universe universe
        {
            get => default(Universe);
            set
            {
            }
        }

        public Description description
        {
            get => default(Description);
            set
            {
            }
        }

        public Group group
        {
            get => default(Group);
            set
            {
            }
        }
    }
}