using System.IO;
using Magic.Helpers;
using Magic.Logic;

namespace Magic.PacketProcessing.Commands.Client
{
    internal class CancelHeroUpgradeCommand : Command
    {
        internal int m_vBuildingId;

        public CancelHeroUpgradeCommand(PacketReader br)
        {
            m_vBuildingId = br.ReadInt32();
            br.ReadInt32();
        }

        public override void Execute(Level level)
        {
            GameObject gameObjectById = level.GameObjectManager.GetGameObjectByID(m_vBuildingId);
            if (gameObjectById == null || gameObjectById.ClassId != 0)
              return;
            HeroBaseComponent heroBaseComponent = ((ConstructionItem)gameObjectById).GetHeroBaseComponent(false);
            if (heroBaseComponent == null)
              return;
            heroBaseComponent.CancelUpgrade();
        }
    }
}
