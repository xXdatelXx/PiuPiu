using UnityEngine;
using Zenject;

public class PlayerFactory : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private PlayerStat _stat;
    private IInput _input;

    [Inject]
    public void Construct(IInput input)
    {
        _input = input;
    }

    private void Start()
    {
        Create();
    }

    private void Create()
    {
        var player = Instantiate(_player, _spawnPoint.position, _spawnPoint.rotation);

        player.Movement.Init(_stat.Speed, _stat.Gravity);
        player.Armor.Init(new Health(_stat.Health));
        player.Init(_input);
    }
}
