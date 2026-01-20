using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(SphereCollider))]
public class ProximitySoundTrigger : MonoBehaviour
{
    [Tooltip("Radius within which the sound will be triggered")]
    public float triggerRadius = 5f;
    
    private AudioSource audioSource;
    private SphereCollider triggerCollider;
    private bool hasPlayed = false;

    private void Awake()
    {
        // Get or add required components
        audioSource = GetComponent<AudioSource>();
        triggerCollider = GetComponent<SphereCollider>();
        
        // Configure the collider
        triggerCollider.isTrigger = true;
        triggerCollider.radius = triggerRadius;
        
        // Configure the audio source to not play on awake
        audioSource.playOnAwake = false;
    }

    private void OnValidate()
    {
        // Update collider radius when changed in inspector
        if (triggerCollider != null)
        {
            triggerCollider.radius = triggerRadius;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Play sound if it hasn't played yet
        if (!hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Reset the played flag when object exits the trigger
        hasPlayed = false;
    }
}