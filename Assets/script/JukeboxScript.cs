using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JukeboxScript : MonoBehaviour
{
    private AudioSource audio;

    public bool premierChoix, deuxiemeChoix, troisiemeChoix, quatriemeChoix, cinquiemeChoix = false;

    [SerializeField]
    AudioClip premiereChanson, deuxiemeChanson, troisiemeChanson, quatriemeChanson, derniereChanson;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("menuJukebox").GetComponent<Canvas>().enabled = true;
            GameObject.Find("Canvas").GetComponent<ScriptTimer>().timerPause = true;
        }
    }
}
