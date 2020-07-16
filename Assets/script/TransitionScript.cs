using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
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
            myText.text = "Mais tu n'es pas au bout de tes  peines !";
            yield return new WaitForSeconds(6f);
            myText.text = "De dangereux aliens de la planète Balls ont envahi les lieux et tentent de te piéger.";
            yield return new WaitForSeconds(3f);
            monAnimation.enabled = false;
            yield return new WaitForSeconds(2f);
            monAnimation.enabled = true;
            yield return new WaitForSeconds(3f);
            myText.text = "Surtout ne les laisse pas te toucher !";
            yield return new WaitForSeconds(6f);
            myText.text = "Bon courage !";
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
