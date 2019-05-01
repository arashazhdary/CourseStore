﻿using CourseStore.Core.Domain.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseStore.Core.Domain.Dtos
{
    public class CustomerDto
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام 100 کاراکتر است.")]
        public virtual string FirstName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام خانوادگی 100 کاراکتر است.")]
        public virtual string LastName { get; set; }

        [Required]
        [RegularExpression(@"^(.+)@(.+)$", ErrorMessage = "ایمیل وارد شده قابل قبول نمی‌باشد.")]
        public virtual string Email { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public virtual CustomerStatus Status { get; set; }

        public virtual DateTime? StatusExpirationDate { get; set; }

        public virtual decimal MoneySpent { get; set; }

        public virtual IList<PurchasedCourseDto> PurchasedCourses { get; set; }
    }
}