using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 input;

    Vector3 moveDirection;
    [HideInInspector] public Rigidbody rb;
    public Transform orientation;

    public float moveSpeed = 7;

    //float moveAmount; for animation

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
        SpeedControl();
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        input = ctx.ReadValue<Vector2>();
    }

    void MovePlayer()
    {
        moveDirection = orientation.forward * input.y + orientation.right * input.x;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        if (input == Vector2.zero)
            rb.linearVelocity = Vector3.zero; //if there are NO Inputs, stop us so we don't slide.
    }

    void SpeedControl()
    { 

        Vector3 flatVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if (flatVelocity.magnitude > moveSpeed)
        {
            Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVelocity.x, rb.linearVelocity.y, limitedVelocity.z);
        }
    }
}
