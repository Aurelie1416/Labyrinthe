using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptUI : MonoBehaviour
{
   public void QuitterJeu()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }

    public void Jouer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Continue()
    {
        int levelLoad = PlayerPrefs.GetInt("DernierNiveau");

        if (levelLoad > 1)
        {
            SceneManager.LoadScene(levelLoad);
        }
        else
        {
            SceneManager.LoadScene("level 1");
        }
    }
}
