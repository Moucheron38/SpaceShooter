using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private string SceneToLoad;
    

    public void ChangeScene()

    {

    SceneManager.LoadScene(SceneToLoad);
    }
}
