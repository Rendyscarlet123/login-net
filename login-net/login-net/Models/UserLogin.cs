﻿namespace login_net.Models
{
    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}
