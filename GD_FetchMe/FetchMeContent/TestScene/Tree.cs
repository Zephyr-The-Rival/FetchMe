using Godot;
using System;
[Tool]
public partial class Tree : Node2D
{
	private Vector2 oldPosition;
	public override void _Process(double delta)
	{
		if (Engine.IsEditorHint())
		{
			if (Position != oldPosition)
			{
				ZIndex = Convert.ToInt32(this.Position.Y);
				GD.Print("New Z Index: " + this.ZIndex);	
			}

			oldPosition = Position;
		}
		
		
	}
	

	public override void _Ready()
	{
		base._Ready();
		
	}
}
