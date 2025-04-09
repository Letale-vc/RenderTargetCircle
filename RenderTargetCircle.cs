using System;
using System.Linq;
using ExileCore2;
using ExileCore2.PoEMemory.Components;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Enums;

namespace RenderTargetCircle;

public class RenderTargetCircle : BaseSettingsPlugin<RenderTargetCircleSettings>
{
    public override bool Initialise()
    {
        //Perform one-time initialization here

        //Maybe load you custom config (only do so if builtin settings are inadequate for the job)
        //var configPath = Path.Join(ConfigDirectory, "custom_config.txt");
        //if (File.Exists(configPath))
        //{
        //    var data = File.ReadAllText(configPath);
        //}

        return true;
    }

    public override void AreaChange(AreaInstance area)
    {
        //Perform once-per-zone processing here
        //For example, Radar builds the zone map texture here
    }

    public override void Tick()
    {
        //Perform non-render-related work here, e.g. position calculation.
        //var a = Math.Sqrt(7);
    }

    public override void Render()
    {
        var target = GameController?.EntityListWrapper?.ValidEntitiesByType[EntityType.Player]
            .FirstOrDefault(x => x.TryGetComponent<Player>(out var player)
                                 && player.PlayerName.Equals(Settings.TargetName.Value,
                                     StringComparison.CurrentCultureIgnoreCase));
        if (target == null) return;
        var radius = Settings.RadiusLine / 0.1f * 10;

        Graphics.DrawCircleInWorld(target.Pos, radius, Settings.ColorCyrcle, Settings.ThicknessLine, 20);
    }


    public override void EntityAdded(Entity entity)
    {
        //If you have a reason to process every entity only once,
        //this is a good place to do so.
        //You may want to use a queue and run the actual
        //processing (if any) inside the Tick method.
    }
}