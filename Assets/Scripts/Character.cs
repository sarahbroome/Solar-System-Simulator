using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public static Character instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }
    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Solar System");
            instance.transform.position = new Vector3(10000, 0, 0);
            instance.transform.localScale = new Vector3(600, 600, 600); 

        }
    }
}
