﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using System;
using System.Globalization;
using System.Web;
using System.Web.SessionState;

namespace MixERP.Net.Common.Helpers
{
    public static class SessionHelper
    {
        public static void AddSessionKey(string key, object value)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            HttpSessionState session = HttpContext.Current.Session;
            {
                if (session != null)
                {
                    if (session[key] == null)
                    {
                        session[key] = value;
                    }
                    else
                    {
                        session.Add(key, value);
                    }
                }
            }
        }

        public static string GetCity()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["City"]);
        }

        public static string GetCountry()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["Country"]);
        }

        public static CultureInfo GetCulture()
        {
            return LocalizationHelper.GetCurrentCulture();
        }

        public static string GetEmail()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["Email"]);
        }

        public static string GetFax()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["Fax"]);
        }

        public static long GetLogOnId()
        {
            return Conversion.TryCastLong(HttpContext.Current.Session["LogOnId"]);
        }

        public static string GetNickname()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["NickName"]);
        }

        public static int GetOfficeId()
        {
            return Conversion.TryCastInteger(HttpContext.Current.Session["OfficeId"]);
        }

        public static string GetOfficeName()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["OfficeName"]);
        }

        public static string GetPanNumber()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["PanNumber"]);
        }

        public static string GetPhone()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["Phone"]);
        }

        public static DateTime GetRegistrationDate()
        {
            return Conversion.TryCastDate(HttpContext.Current.Session["RegistrationDate"]);
        }

        public static string GetRegistrationNumber()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["RegistrationNumber"]);
        }

        public static string GetRole()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["Role"]);
        }

        public static string GetSessionValueByKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return string.Empty;
            }

            HttpSessionState session = HttpContext.Current.Session;
            {
                if (session != null)
                {
                    if (session[key] != null)
                    {
                        return Conversion.TryCastString(session[key]);
                    }
                }
            }

            return string.Empty;
        }

        public static DateTime GetSignInTimestamp()
        {
            return Conversion.TryCastDate(HttpContext.Current.Session["SignInTimestamp"]);
        }
        public static string GetState()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["State"]);
        }

        public static string GetStreet()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["Street"]);
        }

        public static string GetUrl()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["Url"]);
        }

        public static int GetUserId()
        {
            return Conversion.TryCastInteger(HttpContext.Current.Session["UserId"]);
        }

        public static string GetUserName()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["UserName"]);
        }

        public static string GetZipCode()
        {
            return Conversion.TryCastString(HttpContext.Current.Session["ZipCode"]);
        }

        public static bool IsAdmin()
        {
            return Conversion.TryCastBoolean(HttpContext.Current.Session["IsAdmin"]);
        }

        public static bool IsSystem()
        {
            return Conversion.TryCastBoolean(HttpContext.Current.Session["IsSystem"]);
        }
    }
}