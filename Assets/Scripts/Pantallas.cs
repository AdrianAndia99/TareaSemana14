using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pantallas : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space") == true)
        {
            SceneManager.LoadScene("PantallaJuego");
        }
    }
}
