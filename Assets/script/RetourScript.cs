using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetourScript : MonoBehaviour
{
    [SerializeField]
    Transform myTarget;

    [SerializeField]
    MechantScript ennemi;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SplitMetalBall")
        {
            ennemi.target = myTarget;
        }
    }
}
