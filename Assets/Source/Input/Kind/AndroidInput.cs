using System;
using UnityEngine;

public class AndroidInput : IInput
{
    public event Action OnSeatDown;
    public event Action OnGetUp;

    public Vector3 GetAxis()
    {
        return new Vector3();
    }

    public Vector2 GetHorizontalMouse()
    {
        return new Vector3();
    }

    public Vector2 GetVerticalMouse()
    {
        return new Vector3();
    }
}
