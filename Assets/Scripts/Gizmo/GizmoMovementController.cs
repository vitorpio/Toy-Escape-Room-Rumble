using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoMovementController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private GizmoActions gizmoActions;
    private Vector3 movementInput;

    public float movementSpeed;


    void Awake()
    {
        gizmoActions = new GizmoActions();
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        gizmoActions.GizmoMap.Enable();
    }

    void OnDisable()
    {
        gizmoActions.GizmoMap.Disable();
    }

    void Start()
    {

    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        // Keyboard movement
        movementInput = gizmoActions.GizmoMap.Movement.ReadValue<Vector3>();

        // Gravity
        var gravity = new Vector3(0, rigidbody.velocity.y + Physics.gravity.y * Time.deltaTime, 0);

        rigidbody.velocity = (movementInput * movementSpeed) + gravity;
    }

}
