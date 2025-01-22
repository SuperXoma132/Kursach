using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа_БОЯП
{
    public static class CurrentUserData
    {
        public static string UserRole {  get; set; }
        public static string UserLogin { get; set; }
        public static string UserId { get; set; }
        public static string UserPassword { get; set; }
        public static string ConnectionString { get; set; } = @"Server = (localdb)\MSSQLLocalDB; Database = usersdb; Trusted_Connection = True;";
    }
}
