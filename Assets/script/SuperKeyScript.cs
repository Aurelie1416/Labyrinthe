using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperKeyScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("porteExit").GetComponent<PorteScript>().Open = true;
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            Destroy(transform.parent.gameObject, 3f);
        }
    }
}