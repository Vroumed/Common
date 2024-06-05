using System;


namespace Vroumed.Common.Packets.Telemetry
{
    public sealed class TelemetryPacket : PacketBase
    {
        public TelemetryType TelemetryType { get; init; }
        public byte[] Data { get; init; }
    }
}
