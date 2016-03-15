using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisSession.BusinessLayer
{
    public static class ApplicationSession
    {
        private static string _userName = "userName";
        private static string _email = "email";
        private static string _loginDate = "loginDate";

        public static void Init(string userName, string email)
        {
            Set(_userName, userName);
            Set(_email, email);
            Set(_loginDate, DateTime.Now);
        }

        public static string UserName
        {
            get
            {
                return Get<string>(_userName);
            }
            set
            {
                Set(_userName, value);
            }
        }

        public static string Email
        {
            get
            {
                return Get<string>(_email);
            }
            set
            {
                Set(_email, value);
            }
        }

        public static DateTime StartDate
        {
            get
            {
                return Get<DateTime>(_loginDate);
            }
            set
            {
                Set(_loginDate, value);
            }
        }

        private static T Get<T>(string key)
        {
            return (T) HttpContext.Current.Session[key];
        }

        private static void Set(string key, object value)
        {
            HttpContext.Current.Session[key] = value;
        }
    }
}