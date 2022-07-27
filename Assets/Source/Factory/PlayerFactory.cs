using UnityEngine;
using Zenject;

public class PlayerFactory : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private PlayerStat _stat;
    private UpdateEnumerator _updateEnumerator;
    private IInput _input;

    [Inject]
    private void Construct(UpdateEnumerator updateEnumerator, IInput input)
    {
        _updateEnumerator = updateEnumerator;
        _input = input;
    }

    private void Start()
    {
        Create();
    }

    private void Create()
    {
        var player = Instantiate(_player, _spawnPoint.position, _spawnPoint.rotation);
        var movement =
            new PlayerMovement(player.GetComponent<CharacterController>(), _stat.Speed, _stat.Gravity);

        _updateEnumerator.Add(movement);
        player.Init(movement, _input);
    }
}
