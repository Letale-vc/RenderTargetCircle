using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using System.Drawing;

namespace RenderTargetCircle;

public class RenderTargetCircleSettings : ISettings
{
    public ToggleNode TargetSelf { get; set; } = new();
    public TextNode TargetName { get; set; } = new();
    public ColorNode ColorCyrcle { get; set; } = new(Color.FromArgb(178, 130, 230, 100));
    public RangeNode<int> ThicknessLine { get; set; } = new(5, 1, 10);
    public ToggleNode SelfPresence { get; set; } = new();
    public RangeNode<int> RadiusLine { get; set; } = new(0, 1, 1000);

    public ToggleNode Enable { get; set; } = new(false);

    //Mandatory setting to allow enabling/disabling your plugin

    //Put all your settings here if you can.
    //There's a bunch of ready-made setting nodes,
    //nested menu support and even custom callbacks are supported.
    //If you want to override DrawSettings instead, you better have a very good reason.
}