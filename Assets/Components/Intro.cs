using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(Input.GetKeyUp("space"))
        {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    
}