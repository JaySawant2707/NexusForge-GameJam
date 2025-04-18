using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float xClamp = 5;
    [SerializeField] float yClamp = 5;

    Vector3 movement;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 currentPosition = rb.position;
        Vector3 moveDirection = new Vector3(movement.x, movement.y, 0f);
        Vector3 newPos = currentPosition + moveDirection * (moveSpeed * Time.fixedDeltaTime);
        newPos.x = Mathf.Clamp(newPos.x, -xClamp, xClamp);
        newPos.y = Mathf.Clamp(newPos.y, -yClamp, yClamp);
        rb.MovePosition(newPos);
    }
}
