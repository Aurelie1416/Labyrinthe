using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteScript : MonoBehaviour
{
    public bool Open = false;

    [SerializeField]
    AudioClip sonOuverture, sonOpen, sonErreur;

    [SerializeField]
    Animator monAnimation;

    [SerializeField]
    GameObject finDeNiveau;

    private AudioSource audio;

    private void Awake() 
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Open)
        {
            audio.PlayOneShot(sonOuverture);
            GameObject.Find("Point Light Green").GetComponent<Light>().enabled = true;
            GameObject.Find("Point Light Red").GetComponent<Light>().enabled = false;
            finDeNiveau.SetActive(true);
            StartCoroutine(Pause());

            IEnumerator Pause()
            {
                yield return new WaitForSeconds(1f);
                monAnimation.enabled = true;
                audio.PlayOneShot(sonOpen);
                yield return new WaitForSeconds(1.5f);
                audio.mute = true;
            }
        }
        else
        {
            audio.PlayOneShot(sonErreur);
        }
    }
}
