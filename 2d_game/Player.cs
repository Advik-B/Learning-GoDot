using Godot;
using System;

public class Player : Area2D
{

	[Export]
	public int speed = 400;
	public Vector2 ScreenSize;
	public override void _Ready()
	{
		ScreenSize = GetViewportRect().Size;
	}
	public override void _Process(float delta)
	{
		var velocity = Vector2.Zero;
		if (Input.IsActionPressed("move_right"))
		{
			velocity.x += 1;
		}
		if (Input.IsActionPressed("move_left"))
		{
			velocity.x -= 1;
		}
		if (Input.IsActionPressed("move_up"))
		{
			velocity.y -= 1;
		}
		if (Input.IsActionPressed("move_down"))
		{
			velocity.y += 1;
		}
		var animated_sprite = GetNode<AnimatedSprite>("AnimatedSprite");
		if (velocity.Length() > 0)
		{
			velocity = velocity.Normalized() * speed;
			animated_sprite.Play();
		}
		else
		{
			animated_sprite.Stop();
		}
		

	}
	
	


}
