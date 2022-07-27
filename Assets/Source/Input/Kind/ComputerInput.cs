using UnityEngine;

public class ComputerInput : IInput
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";
    private const string MouseX = "Mouse X";
    private const string MouseY = "Mouse Y";

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
}
