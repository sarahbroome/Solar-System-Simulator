using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeColor : MonoBehaviour
{
    public Color[] colors;
    public Material planetMat;

    public void ChangePlanetColor (int colorIndex)
    {
        planetMat.color = colors[colorIndex];
    }
}
