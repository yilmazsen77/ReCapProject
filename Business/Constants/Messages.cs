using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Added.";
        public static string NameInvalid = "Name invalid.";
        public static string Listed = "Listed.";
        public static string Error = "Prosess error.";
        public static string CarImageLimit = "Image count limit reached.";
        public static string AuthorizationDenied = "Authorization denied.";
        public static string UserRegistered = "User registered.";
        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login.";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access token created.";
    }
}
