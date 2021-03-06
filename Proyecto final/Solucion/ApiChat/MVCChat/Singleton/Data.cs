﻿using MVCChat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCChat.Singleton
{
    public class Data
    {
        private static Data _instancia = null;
        public static Data Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Data();
                }
                return _instancia;
            }
        }
        public ApiService RocketChat = new ApiService("https://localhost:44347/RocketChat/User/");//44347 //53386

    }
}