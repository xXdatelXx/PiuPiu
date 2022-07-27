using UnityEngine;

public class PlayerRotateView : MonoBehaviour
{
    [SerializeField, Range(0, 10)] private float _sensitivity;

    public void Rotate(Vector2 rotathion)
    {
        transform.Rotate(rotathion * _sensitivity);
    }
}
