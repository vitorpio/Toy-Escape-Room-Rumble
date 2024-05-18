using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFieldOfViewController : MonoBehaviour
{
    public bool playerOnFieldOfView = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOnFieldOfView = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOnFieldOfView = false;
        }
    }


}
