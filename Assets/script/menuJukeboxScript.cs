using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuJukeboxScript : MonoBehaviour
{
    [SerializeField]
    JukeboxScript choix;

    public AudioSource audio;

    private void Awake()
    {
        GameObject.Find("Jukebox03").GetComponent<JukeboxScript>();
        audio = GetComponent<AudioSource>();
    }

    public void partir()
    {
        GameObject.Find("Canvas").GetComponent<ScriptTimer>().timerPause = false;
        GetComponent<Canvas>().enabled = false;
        GameObject.Find("Canvas").GetComponent<ScriptTimer>().MettrePause();
    }

    public void premierBouton()
    {
        GameObject.Find("Jukebox03").GetComponent<AudioSource>().enabled = true;
    }

    public void deuxiemeBouton()
    {
        GameObject.Find("Jukebox03").GetComponent<AudioSource>().enabled = true;
    }

    public void troisiemeBouton()
    {
        GameObject.Find("Jukebox03").GetComponent<AudioSource>().enabled = true;
    }

    public void quatriemeBouton()
    {
        GameObject.Find("Jukebox03").GetComponent<AudioSource>().enabled = true;
    }

    public void cinquiemeBouton()
    {
        GameObject.Find("Jukebox03").GetComponent<AudioSource>().enabled = true;
    }

    public void eteindre()
    {
        GameObject.Find("Jukebox03").GetComponent<AudioSource>().enabled = false;
    }
}
