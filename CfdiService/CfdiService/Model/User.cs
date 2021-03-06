﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace CfdiService.Model
{
    public enum UserStatusType { Invalid = 0, Unverified = 1, Active = 2, Locked = 3, Deactivated = 4 }

    public class User
    {
        public int UserId { set; get; }
        public int EmployeeId { get; set; }
        public string EmailAddress { get; set; }
        public string DisplayName { get; set; }  // is this needed
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public UserStatusType UserStatus { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime LastPasswordChange { get; set; }
        public int FailedLoginCount { get; set; }
        public bool ForcePasswordReset { get; set; }
        //  public string LanguagePreference { get; set; } ?? 
    }
}