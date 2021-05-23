using System;
using OnionArchitecture.Domain.Enums;

namespace OnionArchitecture.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string SmsCode { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime UpdateAt { get; set; }
        public int RetryCount { get; set; }
        public GeneralStatus Status { get; set; }
    }
}