using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public void Switch()
    {
        SceneManager.LoadScene(1);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Hallo");
    }

}
