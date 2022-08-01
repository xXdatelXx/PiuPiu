public class RootInput : IUpdateble
{
    private readonly AndroidInput _android;
    private readonly ComputerInput _computer;

    public RootInput(InputKeys keys)
    {
        _android = new();
        _computer = new(keys);
    }

    public IInput GetInput()
    {
#if UNITY_EDITOR
        return _computer;
#elif !UNITY_EDITOR && UNITY_ANDROID
        return _android;
#endif
    }

    public void Update(float deltaTime)
    {
#if UNITY_EDITOR
        _computer.Update();
#endif
    }
}
