using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;


    // WASD controls
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 move = Vector3.zero;

        if (horizontal != 0)
        {
            move.x = horizontal;
        }
        else if (vertical != 0)
        {
            move.y = vertical;
        }

        transform.position += move * moveSpeed * Time.deltaTime;
    }
}