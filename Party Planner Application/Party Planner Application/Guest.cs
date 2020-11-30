using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner_Application
{
    class Guest : User
    {
        private bool acceptInvitation;

        public bool AcceptInvitation
        {
            get { return acceptInvitation; }
            set { acceptInvitation = value; }
        }

    }
}
