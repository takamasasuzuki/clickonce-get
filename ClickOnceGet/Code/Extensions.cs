﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Web;
using Microsoft.AspNet.Identity;

namespace ClickOnceGet
{
    public static class Extensions
    {
        public static string ToMD5(this string text)
        {
            var md5Bytes = new MD5Cng().ComputeHash(Encoding.UTF8.GetBytes(text));
            return BitConverter.ToString(md5Bytes).Replace("-", "").ToLower();
        }

        public static string GetHashedUserId(this IPrincipal principal)
        {
            if (principal == null) return null;
            var claimsIdentty = principal.Identity as ClaimsIdentity;
            if (claimsIdentty == null) return null;
            return claimsIdentty.FindFirstValue(CustomClaimTypes.HasedUserId);
        }
    }
}