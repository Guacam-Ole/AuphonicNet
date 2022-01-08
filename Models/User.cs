using Newtonsoft.Json;
using System;

namespace AuphonicApi.Models
{
    public class User
    {
        public string Username { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("date_joined")]
        public DateTime DateJoined { get; set; }

        public string Email { get; set; }
        public float Credits { get; set; }

        [JsonProperty("onetime_credits")]
        public float OnetimeCredits { get; set; }

        [JsonProperty("recurring_credits")]
        public float RecurringCredits { get; set; }

        [JsonProperty("recharge_date")]
        public DateTime RechargeDate { get; set; }

        [JsonProperty("recharge_recurring_credits")]
        public float RechargeRecurringCredits { get; set; }

        [JsonProperty("notification_email")]
        public bool NotificationEmail { get; set; }

        [JsonProperty("error_email")]
        public bool ErrorEmail { get; set; }

        [JsonProperty("warning_email")]
        public bool WarningEmail { get; set; }

        [JsonProperty("low_credits_email")]
        public bool LowCreditsEmail { get; set; }

        [JsonProperty("low_credits_threshold")]
        public int LowCreditsThreshold { get; set; }
    }
}