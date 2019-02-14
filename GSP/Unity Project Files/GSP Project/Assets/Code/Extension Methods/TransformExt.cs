//*! @apscodes

using UnityEngine;

public static class TransformExt
{
    #region DirectionTo
    /// <summary>
    /// Normalized direction to the destination from the source.
    /// Using Vector3Ext, via the TransformExt
    /// </summary>
    /// <param name="source"> Starting point </param>
    /// <param name="destination"> End point </param>
    /// <returns> Normalized direction </returns>
    public static Vector3 DirectionTo(this Transform source, Transform destination)
    {
        return source.position.DirectionTo(destination.position);
    }

    /// <summary>
    /// Normalized direction to the destination from the source.
    /// Using Vector3Ext, via the TransformExt
    /// </summary>
    /// <param name="source"> Starting point </param>
    /// <param name="destination"> End point </param>
    /// <returns> Normalized direction </returns>
    public static Vector3 DirectionTo(this Transform source, Vector3 destination)
    {
        return source.position.DirectionTo(destination);
    }
    #endregion

    #region LookAtClamp
    /// <summary>
    /// LookAt clamped by X axis.
    /// </summary>
    /// <param name="transform"> Starting point </param>
    /// <param name="target"> End Point </param>
    public static void LookAtX(this Transform transform, Transform target)
    {
        Vector3 lookDirection = transform.DirectionTo(target);
        lookDirection.x = 0;
        transform.rotation = Quaternion.LookRotation(lookDirection);
    }

    /// <summary>
    /// LookAt clamped by Y axis.
    /// </summary>
    /// <param name="transform"> Starting point </param>
    /// <param name="target"> End Point </param>
    public static void LookAtY(this Transform transform, Transform target)
    {
        Vector3 lookDirection = transform.DirectionTo(target);
        lookDirection.y = 0;
        transform.rotation = Quaternion.LookRotation(lookDirection);
    }

    /// <summary>
    /// LookAt clamped by Z axis.
    /// </summary>
    /// <param name="transform"> Starting point </param>
    /// <param name="target"> End Point </param>
    public static void LookAtZ(this Transform transform, Transform target)
    {
        Vector3 lookDirection = transform.DirectionTo(target);
        lookDirection.z = 0;
        transform.rotation = Quaternion.LookRotation(lookDirection);
    }
    #endregion


    /// <summary>
    /// Reset the Transform Matrix
    /// </summary>
    /// <param name="transform"> This transform </param>
    public static void ResetTransform(this Transform transform)
    {
        transform.position = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        transform.localScale = new Vector3(1, 1, 1);
    }
}
