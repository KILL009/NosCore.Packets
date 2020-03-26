﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.Benchmark.SaltyEmu
{
    public class PacketPropertyContainer
    {
        public PacketIndexAttribute? PacketIndex { get; set; }
        public PropertyInfo? PropertyInfo { get; set; }
        public IEnumerable<ValidationAttribute?>? Validations { get; set; }
    }
}