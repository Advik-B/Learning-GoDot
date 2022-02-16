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
	


}
