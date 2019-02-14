//*! @apscodes
using UnityEngine;

public static class ColorExt
{
    /// <summary>
    /// Get the Hex Code of the colour
    /// </summary>
    /// <param name="color"> Colour object that calls this. </param>
    /// <returns> Hex code value </returns>
    public static string ToHexCode(this Color color)
    {
        return "#" + ColorUtility.ToHtmlStringRGBA(color);
    }

}

