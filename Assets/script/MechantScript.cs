using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechantScript : MonoBehaviour
{
    [SerializeField]
    float vitesse = 4f;

    public Transform target;
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, vitesse * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerControl>().GameOver();
        }
    }
}
