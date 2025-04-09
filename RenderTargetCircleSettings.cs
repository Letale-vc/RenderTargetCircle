using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;

namespace RenderTargetCircle;

public class RenderTargetCircleSettings : ISettings
{
    public TextNode TargetName { get; set; } = new();
    public ColorNode ColorCyrcle { get; set; } = new();
    public RangeNode<int> ThicknessLine { get; set; } = new(1, 1, 5);
    public RangeNode<float> RadiusLine { get; set; } = new(0, 1, 50);

    public ToggleNode Enable { get; set; } = new(false);

    //Mandatory setting to allow enabling/disabling your plugin

    //Put all your settings here if you can.
    //There's a bunch of ready-made setting nodes,
    //nested menu support and even custom callbacks are supported.
    //If you want to override DrawSettings instead, you better have a very good reason.
}