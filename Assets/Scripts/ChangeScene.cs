using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombreEscena;
    public void ChangeToScene(int sceneToChangeTo)
    {
       SceneManager.LoadScene(nombreEscena);
    }
}
