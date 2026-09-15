using UnityEngine;

public class RocketBarrage : MonoBehaviour
{
    public GameObject rocketPrefab;
    public float fireInterval = 3f;
    public int rocketCount = 4;

    private float timer;

    void Update()
    {
        // Time interval
        timer += Time.deltaTime;

        if (timer >= fireInterval)
        {
            FireBarrage();
            timer = 0f;
        }
    }

    void FireBarrage()
    {
        // calculate spacing
        float spacing = 360f / rocketCount;
        float offset = spacing / 2f;

        for (int i = 0; i < rocketCount; i++)
        {
            // calculate angle
            float angle = spacing * i + offset;

            // spawns rocket
            GameObject rocket = Instantiate(
                rocketPrefab,
                transform.position,
                Quaternion.identity
            );

            Rocket rocketScript = rocket.GetComponent<Rocket>();

            if (rocketScript != null)
            {
                rocketScript.SetAngle(angle);
            }
        }
    }

    public void AddRocket()
    {
        // up to eight ONLY
        if (rocketCount < 8)
        {
            rocketCount++;
        }
    }
}