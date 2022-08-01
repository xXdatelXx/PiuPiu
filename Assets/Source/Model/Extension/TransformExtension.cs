using UnityEngine;

public static class TransformExtension
{
    public static float ClampXEuler(this Transform transform, float min, float max)
    {
        float x = transform.localEulerAngles.x;
        x = x > 180 ? x - 360 : x;
        x = Mathf.Clamp(x, min, max);

        return x;
    }
}
