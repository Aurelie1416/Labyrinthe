using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalScript : MonoBehaviour
{
    public Text myText = null;

    [SerializeField]
    Animator monAnimation;

    void Start()
    {
        StartCoroutine(Pause());

        IEnumerator Pause()
        {
            monAnimation.enabled = true;
            yield return new WaitForSeconds(6f);
            myText.text = "Tu as réussi à t'échapper du Labyrinthe !";
            yield return new WaitForSeconds(3f);
            monAnimation.enabled = false;
            yield return new WaitForSeconds(3f);
            myText.text = "...";
            yield return new WaitForSeconds(3f);
            myText.text = "... Vous devez vraiment vous ennuyer si vous avez terminé ce jeu...";
            yield return new WaitForSeconds(5f);
            myText.text = "... \r\n N'est-ce pas ? \r\n ^^";
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("menu");
        }
    }
}
