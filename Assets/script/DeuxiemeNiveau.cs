using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeuxiemeNiveau : MonoBehaviour
{
    [SerializeField]
    AudioClip bruitage, bruitageBis;

    private AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Start()
    {
        StartCoroutine(Pause());

        IEnumerator Pause()
        {
            yield return new WaitForSeconds(0.5f);
            audio.PlayOneShot(bruitage);
            yield return new WaitForSeconds(1f);
            audio.PlayOneShot(bruitageBis);
            yield return new WaitForSeconds(3.5f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
