﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Tms.IServices.UserInfo
{
    public class ResponseLoginDto
    {
        public string Id { get; set; }

        public string UserName { get; set; }


        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
