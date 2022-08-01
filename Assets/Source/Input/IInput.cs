using UnityEngine;
using System;

public interface IInput
{
    Vector3 GetAxis();
    Vector2 GetHorizontalMouse();
    Vector2 GetVerticalMouse();
    event Action OnSeatDown;
    event Action OnGetUp;
}
