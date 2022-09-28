using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void Switch()
    {
        Application.LoadLevel("Scene2");
    }

    public void GoBack()
    {
        Application.LoadLevel("StartScene");
    }

}
