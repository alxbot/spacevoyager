using Godot;
using System;

public class KinematicBody2D : Godot.KinematicBody2D
{
	private float move_x = 0;
	private float move_y = 0;
	private int direction = 0;
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }


//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
	public override void _PhysicsProcess(float delta) { 
		move_y += 10; // Gravedad
		direction = Convert.ToInt32(Input.IsActionPressed("ui_right")) - Convert.ToInt32(Input.IsActionPressed("ui_left"));

		if (direction == 1) {
			move_x = 200;
		} else if (direction == -1) {
			move_x = -200;
		} else {
			move_x = 0;
		}

		MoveAndSlide(
			new Vector2(move_x, move_y), 
			new Vector2(0,1)
			);
	}
}
