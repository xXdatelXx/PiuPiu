using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;
    private Speed _speed;
    private Vector2 _gravity;

    public void Init(Speed speed)
    {
        // ускорение свободного падения на Земле == 9.81
        Init(speed, 9.81f);
    }

    public void Init(Speed speed, float gravity)
    {
        if (gravity < 0)
            throw new ArgumentOutOfRangeException("gravity must be > 0");

        _controller = GetComponent<CharacterController>();
        _speed = speed.Construct();
        _gravity = new Vector2(0, -gravity);
    }

    public void Move(Vector3 direction)
    {
        _controller.Move(direction * _speed.Value * Time.deltaTime);
    }

    public void SeatDown()
    {
        _speed.SeatDown();
    }

    public void GetUp()
    {
        _speed.GetUp();
    }

    private void Update()
    {
        Gravitate();
    }

    private void Gravitate()
    {
        _controller.Move(_gravity * Time.deltaTime);
    }
}
