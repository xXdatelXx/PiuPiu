using System;
using UnityEngine;

[Serializable]
public struct Speed
{
    [SerializeField, Range(0, 10)] private float _speed;
    [SerializeField, Range(0, 10)] private float _seatSpeed;
    public float Value { get; private set; }

    public Speed(float speed, float seatSpeed)
    {
        if (speed <= 0)
            throw new ArgumentOutOfRangeException("speed must be > 0");
        if (seatSpeed <= 0)
            throw new ArgumentOutOfRangeException("seatSpeed must be > 0");

        _speed = speed;
        _seatSpeed = seatSpeed;
        Value = speed;
    }

    public void SeatDown()
    {
        Value = _seatSpeed;
    }

    public void GetUp()
    {
        Value = _speed;
    }

    public Speed Construct()
    {
        return new Speed(_speed, _seatSpeed);
    }
}
