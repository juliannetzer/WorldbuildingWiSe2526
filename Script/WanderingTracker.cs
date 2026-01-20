using UnityEngine;

public class WanderingTrackerWithRotation : MonoBehaviour
{
	public float maxSpeed = 5f; // Maximum movement speed
	public float trackDistance = 10f; // Distance to pick up track
	public float reachedDistance = 1f; // Distance at which the object counts as having reached the target
	public string trackedTag = "Target"; // Tag of objects to track
	public LayerMask detectionLayer; // Layer for tracking
	public float restTime = 10f; // Time to rest after reaching the target
	public float wanderCooldown = 15f; // Minimum time in wander state after reaching a target

	private Vector3 randomDirection; // Random movement direction
	private float randomSpeed; // Random speed
	private float changeDirectionTime = 2f; // Time to change direction
	private float timeSinceDirectionChange;

	private Rigidbody rb;
	private Transform target;
	private float restTimer;
	private float cooldownTimer;

	private enum State { Idle, Tracking, Resting }
	private State currentState = State.Idle;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		GenerateRandomMovement();
	}

	void Update()
	{
		switch (currentState)
		{
		case State.Idle:
			Wander();
			if (cooldownTimer <= 0) DetectObjects();
			break;

		case State.Tracking:
			MoveToTarget();
			break;

		case State.Resting:
			Rest();
			break;
		}

		// Decrease cooldown timer while in the Idle state
		if (currentState == State.Idle && cooldownTimer > 0)
		{
			cooldownTimer -= Time.deltaTime;
		}
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

	void DetectObjects()
	{
		Collider[] objectsInRange = Physics.OverlapSphere(transform.position, trackDistance, detectionLayer);
		foreach (var obj in objectsInRange)
		{
			if (obj.CompareTag(trackedTag))
			{
				target = obj.transform;
				currentState = State.Tracking;
				break;
			}
		}
	}

	void MoveToTarget()
	{
		if (target == null)
		{
			currentState = State.Idle;
			cooldownTimer = wanderCooldown;
			return;
		}

		Vector3 direction = (target.position - transform.position).normalized;
		Vector3 move = direction * maxSpeed * Time.deltaTime;
		MoveOnTerrain(move);

		// Rotate towards the movement direction
		RotateTowards(direction);

		float distance = Vector3.Distance(transform.position, target.position);
		if (distance <= reachedDistance)
		{
			currentState = State.Resting;
			restTimer = 0f;
		}
		else if (distance > trackDistance)
		{
			ClearTargetAndCooldown();
		}
	}

	void Rest()
	{
		restTimer += Time.deltaTime;
		if (restTimer >= restTime)
		{
			ClearTargetAndCooldown();
		}
	}

	void ClearTargetAndCooldown()
	{
		target = null; // Clear the target reference
		cooldownTimer = wanderCooldown; // Start the cooldown timer
		currentState = State.Idle; // Transition back to Idle state
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

	void OnDrawGizmos()
	{
		// Visualize the detection range
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(transform.position, trackDistance);

		// Visualize the reached distance
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, reachedDistance);
	}
}
