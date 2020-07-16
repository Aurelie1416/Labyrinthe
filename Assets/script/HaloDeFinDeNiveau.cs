using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HaloDeFinDeNiveau : MonoBehaviour
{
    [SerializeField]
    int niveauACharger;

    [SerializeField]
    bool index = true;

    private void Start()
    {
        if (index)
        {
            niveauACharger = SceneManager.GetActiveScene().buildIndex + 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerPrefs.SetInt("DernierNiveau", niveauACharger);
            SceneManager.LoadScene(niveauACharger);
        }
    }
}
