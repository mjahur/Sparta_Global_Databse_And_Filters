using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Social
{
    public class Group
    {
        public int groupID
        {
            get => default(int);
            set
            {
            }
        }

        public string groupName
        {
            get => default(string);
            set
            {
            }
        }

        public string ParentOrganisation
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
    }
}