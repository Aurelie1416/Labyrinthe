using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{

    [SerializeField]
    private float vitesse = 4f, rotation = 80f, speed;

    [SerializeField]
    GameObject gameover;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 2 * vitesse;
        }
        else
        {
            speed = vitesse;
        }

        transform.Rotate(Vector3.up * rotation * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }

    public void GameOver()
    {
        gameover.SetActive(true);
        StartCoroutine(ChargementMenu());
    }

    IEnumerator ChargementMenu()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("menu");
    }
}
