using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Transform transform;
    private EnemyFieldOfViewController enemyFieldOfViewController;

    public HealthController healthController;
    public float chaseForce = 50.0f;
    public float chaseRotation = 3.0f;


    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
        enemyFieldOfViewController = GetComponentInChildren<EnemyFieldOfViewController>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && !healthController.isTakingDamage)
        {
            Transform playerTransform = other.gameObject.GetComponent<Transform>();

            if (enemyFieldOfViewController.playerOnFieldOfView)
            {
                rigidbody.velocity = (playerTransform.position - transform.position) * chaseForce * Time.deltaTime;
            }
            else
            {
                Quaternion targetRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
                targetRotation.x = 0;
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, chaseRotation * Time.deltaTime);
            }
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
