using System.Linq;
using UnityEngine;

public static class TransformExtensions
{

    public static void ClearChildren(this Transform transform)
    {
        foreach (var child in transform.GetComponentsInChildren<Transform>().Skip(1))
            if (child)
                if (Application.isPlaying)
                    Object.Destroy(child.gameObject);
                else
                    Object.DestroyImmediate(child.gameObject);
    }

}
