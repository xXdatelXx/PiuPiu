using UnityEngine;
using System;

public class PlayerMovement : IUpdateble
{
    private readonly CharacterController _controller;
    private readonly float _speed;
    private readonly float _gravity;

    public PlayerMovement(CharacterController controller, float speed, float gravity)
    {
        if (controller == null)
            throw new NullReferenceException(controller.ToString());
        if (speed < 0)
            throw new ArgumentOutOfRangeException(speed.ToString());
        if (speed < 0)
            throw new ArgumentOutOfRangeException(gravity.ToString());

        _controller = controller;
        _speed = speed;
        _gravity = gravity;
    }

    public void Move(Vector2 direction)
    {
        _controller.Move(direction * _speed * Time.deltaTime);
    }

    public void Update()
    {
        Gravitate();
    }

    private void Gravitate()
    {
        _controller.Move(new Vector2(0, -_gravity));
    }
}
