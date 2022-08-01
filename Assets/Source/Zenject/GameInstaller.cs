using Zenject;
using UnityEngine;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private UpdateEnumerator _updateEnumerator;
    [SerializeField] private InputKeys _keys;

    public override void InstallBindings()
    {
        var rootInput = new RootInput(_keys);

        _updateEnumerator.Add(rootInput);
        Container.BindInstance(rootInput.GetInput());
    }
}
