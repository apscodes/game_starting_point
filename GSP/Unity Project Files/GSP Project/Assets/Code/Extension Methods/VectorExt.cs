//*! @apscodes

using UnityEngine;

public static class VectorExt
{

    #region Vector3
    /// <summary>
    /// Asign a value to 1 or more axis
    /// </summary>
    /// <param name="original"> Vector3 position that called this. </param>
    /// <param name="x"> Component that will be changed. </param>
    /// <param name="y"> Component that will be changed. </param>
    /// <param name="z"> Component that will be changed. </param>
    /// <returns> New Vector3 Position value </returns>
    public static Vector3 With(this Vector3 original, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
    }


    /// <summary>
    /// Normalized direction to the destination from the source.
    /// </summary>
    /// <param name="source"> Starting point </param>
    /// <param name="destination"> End point </param>
    /// <returns> Normalized direction </returns>
    public static Vector3 DirectionTo(this Vector3 source, Vector3 destination)
    {
        return Vector3.Normalize(destination - source);
    }


    /// <summary>
    /// New Vector3 set by 1 value
    /// </summary>
    /// <param name="vector"> This Vector3 </param>
    /// <param name="newXYZ"> Value to set for each XYZ </param>
    /// <returns></returns>
    public static Vector3 Set(this Vector3 vector, float newXYZ)
    {
        return new Vector3(newXYZ, newXYZ, newXYZ);
    }


    /// <summary>
    /// Swap the Y and Z component values.
    /// </summary>
    /// <param name="vector"> This Vector </param>
    public static void SwapYZ(this Vector3 vector)
    {
        float tVecY = vector.y;
        vector.y = vector.z;
        vector.z = tVecY;
    }


    //public static Vector3 NearestPointOnAxis(this Vector3 vector, Vector3 point, bool isNormalized = false)
    //{
    //    if (!isNormalized)
    //        vector.Normalize();
    //
    //    float dot = Vector3.Dot(point, vector);
    //
    //    return vector * dot;
    //}


    #endregion

    #region Vector2
    /// <summary>
    /// Asign a value to 1 or more axis
    /// </summary>
    /// <param name="original"> Vector3 position that called this. </param>
    /// <param name="x"> Component that will be changed. </param>
    /// <param name="y"> Component that will be changed. </param>
    /// <param name="z"> Component that will be changed. </param>
    /// <returns> New Vector3 Position value </returns>
    public static Vector2 With(this Vector2 original, float? x = null, float? y = null)
    {
        return new Vector2(x ?? original.x, y ?? original.y);
    }


    /// <summary>
    /// Normalized direction to the destination from the source.
    /// </summary>
    /// <param name="source"> Starting point </param>
    /// <param name="destination"> End point </param>
    /// <returns> Normalized direction </returns>
    public static Vector2 DirectionTo(this Vector2 source, Vector2 destination)
    {
        return Vector3.Normalize(destination - source);
    }


    /// <summary>
    /// New Vector3 set by 1 value
    /// </summary>
    /// <param name="vector"> This Vector3 </param>
    /// <param name="newXY"> Value to set for each XY </param>
    /// <returns></returns>
    public static Vector2 Set(this Vector2 vector, float newXY)
    {
        return new Vector2(newXY, newXY);
    }
    #endregion
}

