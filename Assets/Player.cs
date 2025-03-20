using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector2 movementInput;

    float speed = 10f;

    public InputActionReference move;

    void Start()
    {
        if (!rigidbody)
        {
            rigidbody = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        movementInput = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 velocity = new Vector3(movementInput.x, 0, movementInput.y) * speed;
        rigidbody.linearVelocity = velocity;
    }
}
