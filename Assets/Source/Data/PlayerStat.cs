using UnityEngine;
using System;

[CreateAssetMenu(menuName = "PlayerStat", fileName = "Player")]
public class PlayerStat : ScriptableObject
{
    [field: SerializeField] public Speed Speed { get; private set; }
    [field: SerializeField, Range(0, 10)] public float Gravity { get; private set; }
    [field: SerializeField, Range(0, 10)] public int Health { get; private set; }
}

