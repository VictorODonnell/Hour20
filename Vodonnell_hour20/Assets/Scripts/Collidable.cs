using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timePenalty = -1.5f; // Use a negative value to represent the time loss

    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.AdjustTime(timePenalty); // Apply the time penalty
            Destroy(gameObject);
        }
    }
}
