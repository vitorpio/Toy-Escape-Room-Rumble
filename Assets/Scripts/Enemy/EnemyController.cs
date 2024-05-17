using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Transform transform;

    public HealthController healthController;


    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }


    void FixedUpdate()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && !healthController.isTakingDamage)
        {
            Transform playerTransform = other.gameObject.GetComponent<Transform>();

            Vector3 chaseForce = (playerTransform.position - transform.position) * 50 * Time.deltaTime;

            rigidbody.velocity = chaseForce;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            rigidbody.velocity = Vector3.zero;
        }
    }
}
