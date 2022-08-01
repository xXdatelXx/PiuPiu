using UnityEngine;

[RequireComponent(typeof(PlayerRotateView))]
public class VerticalRotateView : MonoBehaviour
{
    [SerializeField, Range(-90, 0)] private float _minX;
    [SerializeField, Range(90, 0)] private float _maxX;
    private PlayerRotateView _decorated;
    private Vector2 _clampRotation;

    private void Awake()
    {
        _decorated = GetComponent<PlayerRotateView>();
        _clampRotation = new Vector2(0, transform.localEulerAngles.y);
    }

    public void Rotate(Vector2 rotation)
    {
        _decorated.Rotate(rotation);
        Clamp();
    }

    private void Clamp()
    {
        _clampRotation.x = transform.ClampXEuler(_minX, _maxX);
        transform.localEulerAngles = _clampRotation;
    }
}
