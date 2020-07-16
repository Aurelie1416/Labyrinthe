using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bienvenu : MonoBehaviour
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
            myText.text = "Tu es coincé dans une base qui va bientôt exploser. La seule façon de t'en sortir est de trouver la clé qui te permettra de sortir de cet endroit.";
            yield return new WaitForSeconds(3f);
            monAnimation.enabled = false;
            yield return new WaitForSeconds(4f);
            monAnimation.enabled = true;
            yield return new WaitForSeconds(3f);
            myText.text = "Utilise les touche directionnelle pour te déplacer et utilise CTRL pour sprinter.";
            yield return new WaitForSeconds(3f);
            monAnimation.enabled = false;
            yield return new WaitForSeconds(3f);
            monAnimation.enabled = true;
            yield return new WaitForSeconds(3f);
            myText.text = "Sauras-tu trouver la sortir du Labyrinthe ?";
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
