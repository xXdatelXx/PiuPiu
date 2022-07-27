using Zenject;
using UnityEngine;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private UpdateEnumerator _updateEnumerator;

    public override void InstallBindings()
    {
        Container.BindInstance(_updateEnumerator);
        Container.BindInstance(new RootInput().GetInput());
    }
}
