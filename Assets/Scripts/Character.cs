using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public static Character instance;

    private static int planetCount = 0;

    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(instance);
        planetCount++;
    }
    public void AddtoOrbitButton()
    {
        SceneManager.LoadScene("Solar System");

        if (planetCount == 1)
        {
            instance.transform.position = new Vector3(15000, 0, 0);
        }

        if (planetCount == 2)
        {
            instance.transform.position = new Vector3(-15000, 0, 0);
        }

        if (planetCount == 3)
        {
            instance.transform.position = new Vector3(30000, 0, 0);
        }

        if (planetCount == 4)
        {
            instance.transform.position = new Vector3(-30000, 0, 0);
        }


        if (CustomizeModels.currentSize == 0)
        {
            instance.transform.localScale = new Vector3(1000, 1000, 1000);

        }

        else if (CustomizeModels.currentSize == 1)
        {
            instance.transform.localScale = new Vector3(1200, 1200, 1200);
        }

        else
        {
            instance.transform.localScale = new Vector3(1400, 1400, 1400);
        }
    }
}
