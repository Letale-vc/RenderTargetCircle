using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using System.Drawing;

namespace RenderTargetCircle;

public class RenderTargetCircleSettings : ISettings
{
    public ToggleNode TargetSelf { get; set; } = new();
    public TextNode TargetName { get; set; } = new();
    public ColorNode ColorCircle { get; set; } = new(Color.FromArgb(178, 130, 230, 100));
    public RangeNode<int> ThicknessLine { get; set; } = new(5, 1, 10);
    public ToggleNode SelfPresence { get; set; } = new();
    public RangeNode<int> RadiusLine { get; set; } = new(0, 1, 1000);
    public ToggleNode Enable { get; set; } = new(false);

}