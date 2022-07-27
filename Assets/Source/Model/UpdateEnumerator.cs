using System.Collections.Generic;
using UnityEngine;

public class UpdateEnumerator : MonoBehaviour
{
    private List<IUpdateble> _updates = new();

    public void Add(IUpdateble updateble)
    {
        _updates.Add(updateble);
    }

    public void Remove(IUpdateble updateble)
    {
        _updates.Remove(updateble);
    }

    private void Update()
    {
        _updates.ForEach(i => i.Update());
    }
}
