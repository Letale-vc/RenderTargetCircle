using ExileCore2;
using ExileCore2.PoEMemory.Components;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Enums;
using System;
using System.Linq;

namespace RenderTargetCircle;

public class RenderTargetCircle : BaseSettingsPlugin<RenderTargetCircleSettings>
{
    public override void Render()
    {
        Entity target = null;
        if (Settings.TargetSelf)
        {
            target = GameController?.Player;
        }
        else
        {
            target = GameController?.EntityListWrapper?.ValidEntitiesByType[EntityType.Player]
             .FirstOrDefault(x => x.TryGetComponent<Player>(out var player)
                                  && player.PlayerName.Equals(Settings.TargetName.Value,
                                      StringComparison.CurrentCultureIgnoreCase));
        }
        if (target == null) return;
        float radius = 0f;
        const float PER_NUMBER = 11f;
        if (Settings.SelfPresence)
        {
            var stats = target.GetComponent<Stats>().StatDictionary;
            if (stats.TryGetValue(GameStat.PresenceRadius, out var presence))
            {
                radius = (float)presence * PER_NUMBER;
            }
            else
            {
                LogError("Unable to find target presence");
            }
        }
        else { radius = Settings.RadiusLine * PER_NUMBER; }
        Graphics.DrawCircleInWorld(target.Pos, radius, Settings.ColorCircle, Settings.ThicknessLine, 20);
    }
}