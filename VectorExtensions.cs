using UnityEngine;

public static class VectorExtensions
{

    public enum Rounding
    {
        Floor, Ceiling
    }

    #region To Vector2

    public static Vector2 ToVector((float x, float y) v)
    {
        return new Vector2(v.x, v.y);
    }

    public static Vector2Int ToVector((int x, int y) v)
    {
        return new Vector2Int(v.x, v.y);
    }

    public static Vector2 ToVector2(this Vector2Int v)
    {
        return new Vector2(v.x, v.y);
    }

    public static Vector2Int ToInt(this Vector2 v, Rounding? rounding = null)
    {
        if (rounding == Rounding.Floor)
            return new Vector2Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y));
        else if (rounding == Rounding.Ceiling)
            return new Vector2Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y));
        else
            return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
    }

    #endregion
    #region To Vector3

    public static Vector3 ToVector((float x, float y, float z) v)
    {
        return new Vector3(v.x, v.y, v.z);
    }

    public static Vector3 ToVector3(this Vector2 v, float z = 0)
    {
        return new Vector3(v.x, v.y, z);
    }

    public static Vector3Int ToVector((int x, int y, int z) v)
    {
        return new Vector3Int(v.x, v.y, v.z);
    }

    public static Vector3 ToVector3(this Vector3Int v)
    {
        return new Vector3(v.x, v.y, v.z);
    }

    public static Vector3 ToVector3(this Vector2Int v, float z = 0)
    {
        return new Vector3(v.x, v.y, z);
    }

    public static Vector3Int ToVector3(this Vector2Int v, int z)
    {
        return new Vector3Int(v.x, v.y, z);
    }

    public static Vector3Int ToInt(this Vector3 v, Rounding? rounding = null)
    {
        if (rounding == Rounding.Floor)
            return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
        else if (rounding == Rounding.Ceiling)
            return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
        else
            return new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));
    }

    #endregion

}
