using UnityEngine;

[RequireComponent(typeof(PlayerRotateView))]
public class VerticalRotateView : MonoBehaviour
{
    [SerializeField, Range(-90, 0)] private float _minX;
    [SerializeField, Range(90, 0)] private float _maxX;
    private PlayerRotateView _decorated;

    private void Awake()
    {
        _decorated = GetComponent<PlayerRotateView>();
    }

    public void Rotate(Vector2 rotathion)
    {
        _decorated.Rotate(rotathion);

        Clamp();
    }

    private void Clamp()
    {
        float x = transform.localEulerAngles.x;
        x = x > 180 ? x - 360 : x;
        x = Mathf.Clamp(x, _minX, _maxX);

        transform.localEulerAngles = new Vector2(x, transform.localEulerAngles.y);
    }
}
