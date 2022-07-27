public class RootInput
{
    private AndroidInput _android = new();
    private ComputerInput _computer = new();

    public IInput GetInput()
    {
#if UNITY_EDITOR
        return _computer;
#elif !UNITY_EDITOR && UNITY_ANDROID
        return _android;
#endif
    }
}
