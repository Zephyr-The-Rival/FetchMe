using Godot;
using System;

public partial class TestCharacter : CharacterBody2D
{
	[Export] public float WalkSpeed = 100;

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);
		
		Vector2 velocity = Vector2.Zero;
		
		if (Input.IsActionPressed("Right"))
			velocity.X += 1;
		if (Input.IsActionPressed("Left"))
			velocity.X -= 1;
		if (Input.IsActionPressed("Down"))
			velocity.Y += 1;
		if (Input.IsActionPressed("Up"))
			velocity.Y -= 1;
		
		Velocity = velocity.Normalized() * WalkSpeed;
		MoveAndSlide();
	}
	
	public override void _Process(double delta)
	{
		base._Process(delta);

		ZIndex = Convert.ToInt32(this.Position.Y);
		
		
	}
}
