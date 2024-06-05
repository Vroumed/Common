using System;

namespace Vroumed.Common.Packets
{
    public abstract class PacketBase
    {
        public DateTime Timestamp { get; init; }
        public string PacketType { get; init; }
    }
}
