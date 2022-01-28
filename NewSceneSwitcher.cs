using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.UI; using UnityEngine.SceneManagement;  public class NewSceneSwitcher : MonoBehaviour {      public void Awake()     {         DontDestroyOnLoad(this);     }      public void starter()     {         SceneManager.LoadScene(sceneBuildIndex: 4);     }      public void invokeSwitcher()
    {
        int index = Random.Range(1, 4);
        SceneManager.LoadScene(index);
    }      public void quitGame()     {         Debug.Log("Quitting game...");         Application.Quit();     } }