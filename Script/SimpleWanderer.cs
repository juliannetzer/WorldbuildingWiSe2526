using UnityEngine;

public class SimpleWanderer : MonoBehaviour
{
    public float maxSpeed = 5f; // Maximum movement speed

    private Vector3 randomDirection; // Random movement direction
    private float randomSpeed; // Random speed
    private float changeDirectionTime = 2f; // Time to change direction
    private float timeSinceDirectionChange;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GenerateRandomMovement();
    }

    void Update()
    {
        Wander();
    }

    void Wander()
    {
        timeSinceDirectionChange += Time.deltaTime;
        if (timeSinceDirectionChange >= changeDirectionTime)
        {
            GenerateRandomMovement();
        }

        Vector3 move = randomDirection * randomSpeed * Time.deltaTime;
        MoveOnTerrain(move);

        // Rotate towards the movement direction
        RotateTowards(randomDirection);
    }

    void MoveOnTerrain(Vector3 move)
    {
        if (rb != null)
        {
            rb.MovePosition(transform.position + move);
        }
        else
        {
            transform.position += move;
        }
    }

    void RotateTowards(Vector3 direction)
    {
        if (direction.magnitude > 0.1f) // Ensure there's movement to rotate towards
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f); // Smooth rotation
        }
    }

    void GenerateRandomMovement()
    {
        randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
        randomSpeed = Random.Range(0.5f, maxSpeed);
        timeSinceDirectionChange = 0;
    }
}