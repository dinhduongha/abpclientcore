﻿
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Bamboo.AbpHelper;
//using System.ComponentModel.DataAnnotations;

namespace Bamboo.AbpHelper.Dto
{
    [Serializable]
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class RegisterInput/* : IValidatableObject*/
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string CaptchaResponse { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (!string.IsNullOrEmpty(UserName))
        //    {
        //        if (!UserName.Equals(EmailAddress) && ValidationHelper.IsEmail(UserName))
        //        {
        //            yield return new ValidationResult("Username cannot be an email address unless it's the same as your email address!");
        //        }
        //    }
        //}
    }
}
