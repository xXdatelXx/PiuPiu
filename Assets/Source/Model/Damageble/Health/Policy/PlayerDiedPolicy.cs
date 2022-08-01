public class PlayerDiedPolicy : IDiePolicy
{
    public bool Died(int health)
    {
        return health <= 0;
    }
}
