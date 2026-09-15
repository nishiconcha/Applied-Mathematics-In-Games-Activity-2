using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float pickupRange = 0.7f;

    void Update()
    {
        // Find the player
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // Check distance from player
            float distance = Vector2.Distance(transform.position, player.transform.position);

            // Pickup
            if (distance <= pickupRange)
            {
                RocketBarrage barrage = player.GetComponent<RocketBarrage>();

                if (barrage != null)
                {
                    // add rocket and destory powerup
                    barrage.AddRocket();
                    Destroy(gameObject);
                }
            }
        }
    }
}