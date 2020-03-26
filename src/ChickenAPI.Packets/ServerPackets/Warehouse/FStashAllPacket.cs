﻿using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.ServerPackets.Inventory;

namespace ChickenAPI.Packets.ServerPackets.Warehouse
{
    [PacketHeader("f_stash_all")]
    public class FStashAllPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte WarehouseSize { get; set; }

        [PacketIndex(1)]
        public List<IvnSubPacket?>? IvnSubPackets { get; set; }
    }
}