using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeColor : MonoBehaviour
{
    public Color[] colors;
    public Material planetMatsmall;
    public Material planetMatmedium;
    public Material planetMatlarge;

    public void ChangePlanetColor (int colorIndex)
    {
        if (CustomizeModels.currentSize == 0)
        {
            planetMatsmall.color = colors[colorIndex];
        }

        if (CustomizeModels.currentSize == 1)
        {
            planetMatmedium.color = colors[colorIndex];
        }

        if (CustomizeModels.currentSize == 2)
        {
            planetMatlarge.color = colors[colorIndex];
        }

    }
}
