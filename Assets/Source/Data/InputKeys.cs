using UnityEngine;

[CreateAssetMenu(menuName = "Inputkeys", fileName = "Keys")]
public class InputKeys : ScriptableObject
{
    [field: SerializeField] public KeyCode SeatDown { get; private set; }
}
