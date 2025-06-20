﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTT_WinForms.DB.Objects
{
    public class Connection : BaseObject
    {
        public string? Host { get; set; }

        public int Port { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public List<Subscription> Subscriptions { get; set; } = new();
    }
}