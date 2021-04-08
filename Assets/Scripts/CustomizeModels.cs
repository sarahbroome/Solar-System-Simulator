using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeModels : MonoBehaviour
{
    public GameObject[] sizes;
    public static int currentSize;

    void Update()
    {
        for (int i = 0; i < sizes.Length; i++)
        {
            if (i == currentSize)
            {
                sizes[i].SetActive(true);
            }
            else
            {
                sizes[i].SetActive(false);
            }
        }
    }

    public void SwitchSizes ()
    {
        if (currentSize == sizes.Length - 1)
        {
            currentSize = 0;
        }

        else
        {
            currentSize++;
        }

    }
}
