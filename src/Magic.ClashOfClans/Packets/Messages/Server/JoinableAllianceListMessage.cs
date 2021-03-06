using System.Collections.Generic;
using System.Threading.Tasks;
using Magic.Helpers;
using Magic.Logic;

namespace Magic.PacketProcessing.Messages.Server
{
    internal class JoinableAllianceListMessage : Message
    {
        internal System.Collections.Generic.List<Alliance> m_vAlliances;

        public JoinableAllianceListMessage(PacketProcessing.Client client) : base(client)
        {
            MessageType = 24304;
            m_vAlliances = new List<Alliance>();
        }

        public override void Encode()
        {
            var pack = new List<byte>();
            pack.AddInt32(m_vAlliances.Count);

            foreach(var alliance in m_vAlliances)
            {
                if (alliance != null)
                pack.AddRange(alliance.EncodeFullEntry());
            }

            Encrypt(pack.ToArray());
        }

        public void SetJoinableAlliances(List<Alliance> alliances)
        {
            m_vAlliances = alliances;
        }
    }
}
