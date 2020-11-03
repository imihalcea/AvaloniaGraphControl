using Avalonia.Media;

namespace AvaloniaGraphControlSample
{
  class State
  {
    public State(string name, IBrush color) { Name = name; Color = color; }
    public string Name { get; private set; }
    public IBrush Color { get; private set; }
  }
}
