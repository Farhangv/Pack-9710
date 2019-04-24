using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApp.Helpers
{
    public static class HashHelper
    {
        public static byte[] ToSha512Hash(string _rawPassword)
        {
            var data = Encoding.UTF8.GetBytes(_rawPassword);
            byte[] result;
            using (SHA512 sha = new SHA512Managed())
            {
                result = sha.ComputeHash(data);
            }
            return result;
        }
    }
}