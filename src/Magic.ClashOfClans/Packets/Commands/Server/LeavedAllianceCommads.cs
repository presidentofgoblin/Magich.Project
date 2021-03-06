using System;
using System.Collections.Generic;
using Magic.Helpers;
using Magic.Logic;
using Magic.PacketProcessing;

namespace Magic.PacketProcessing.Commands.Server
{
    internal class LeavedAllianceCommand : Command
    {
        private Alliance m_vAlliance;
        private int m_vReason;

        public LeavedAllianceCommand()
        {
        }

        public override byte[] Encode()
        {
            List<byte> data = new List<byte>();
            data.AddInt64(m_vAlliance.AllianceId);
            data.AddInt32(m_vReason);
            data.AddInt32(-1);
            return data.ToArray();
        }

        public void SetAlliance(Alliance alliance)
        {
            m_vAlliance = alliance;
        }

        public void SetReason(int reason)
        {
            m_vReason = reason;
        }
    }
}
