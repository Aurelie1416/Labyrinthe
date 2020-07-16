using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPremierNiveau : MonoBehaviour

{
    [SerializeField]
    AudioClip bruitage;

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
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
