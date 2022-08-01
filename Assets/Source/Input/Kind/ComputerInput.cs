using System;
using UnityEngine;

public class ComputerInput : IInput
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";
    private const string MouseX = "Mouse X";
    private const string MouseY = "Mouse Y";
    private readonly InputKeys _keys;
    public event Action OnSeatDown;
    public event Action OnGetUp;

    public ComputerInput(InputKeys keys)
    {
        _keys = keys;
    }

    public Vector3 GetAxis()
    {
        return new Vector3(-Input.GetAxis(Vertical), 0, Input.GetAxis(Horizontal));
    }

    public Vector2 GetHorizontalMouse()
    {
        return new Vector2(0, Input.GetAxis(MouseX));
    }

    public Vector2 GetVerticalMouse()
    {
        return new Vector2(-Input.GetAxis(MouseY), 0);
    }

    public void Update()
    {
        if (Input.GetKeyDown(_keys.SeatDown))
            OnSeatDown?.Invoke();
        if (Input.GetKeyUp(_keys.SeatDown))
            OnGetUp?.Invoke();
    }
}
