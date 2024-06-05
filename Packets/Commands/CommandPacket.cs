namespace Vroumed.Common.Packets.Commands
{
    public sealed class CommandPacket : PacketBase
    {
        public CommandType CommandType { get; init; }
        public byte[] Data { get; init; }
    }
}
