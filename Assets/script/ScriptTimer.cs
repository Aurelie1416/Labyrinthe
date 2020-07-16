using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptTimer : MonoBehaviour
{
    public bool timerPause = false;

    [SerializeField]
    private int StartMontre = 60;

    [SerializeField]
    Text TexteMontre;

    [SerializeField]
    Animator horloge, timer;

    private AudioSource audio;

    private Animator anim;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        TexteMontre.text = "Compte à rebours : " + StartMontre;
        MettrePause();
    }

    public void MettrePause()
    {
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        while (!timerPause && StartMontre > 0)
        {
            yield return new WaitForSeconds(1f);
            StartMontre--;
            TexteMontre.text = "Compte à rebours : " + StartMontre;

            if (StartMontre < 11)
            {
                audio.Play();
                timer.enabled = true;
            }

            if (StartMontre == 0)
            {
                audio.mute = true;
                GameObject.Find("Player").GetComponent<PlayerControl>().GameOver();
            }    
        }
    }
}
