using UnityEngine;

[CreateAssetMenu(menuName = "PlayerStat", fileName = "Player")]
public class PlayerStat : ScriptableObject
{
    [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }
    [field: SerializeField, Range(0, 10)] public float Gravity { get; private set; }
}
