using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFunction : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame()
    {
        Debug.Log("Exit!");
        Application.Quit();
    }
}
