using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed = 8f;
    public float lifeTime = 3f;

    private float angle;

    public void SetAngle(float newAngle)
    {
        angle = newAngle;

        // Convert angle to radians
        float radians = angle * Mathf.Deg2Rad;

        // Direction of the rocket
        Vector2 direction = new Vector2(
            Mathf.Cos(radians),
            Mathf.Sin(radians)
        );

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        StartCoroutine(MoveRocket(direction));
    }

    private System.Collections.IEnumerator MoveRocket(Vector2 direction)
    {
        float timer = 0f;

        // Move until lifetime ends
        while (timer < lifeTime)
        {
            transform.position += (Vector3)direction * speed * Time.deltaTime;

            timer += Time.deltaTime;

            yield return null;
        }

        Destroy(gameObject);
    }
}