using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SphereCollider))]
public class ProximityAnimationTrigger : MonoBehaviour
{
    [Tooltip("Radius within which the animation will be triggered")]
    public float triggerRadius = 5f;
    
    [Tooltip("Name of the animation to play when triggered")]
    public string triggerAnimationName;
    
    [Tooltip("Name of the default animation to return to")]
    public string defaultAnimationName;
    
    [Tooltip("Tag of the object that can trigger the animation")]
    public string targetTag = "Player";
    
    private Animator animator;
    private SphereCollider triggerCollider;
    private bool isInTriggerZone = false;
    private bool isPlayingTriggerAnimation = false;
    
    private void Awake()
    {
        // Get or add required components
        animator = GetComponent<Animator>();
        triggerCollider = GetComponent<SphereCollider>();
        
        // Configure the collider
        triggerCollider.isTrigger = true;
        triggerCollider.radius = triggerRadius;
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
        // Check if the entering object has the correct tag and we're not already triggered
        if (other.CompareTag(targetTag) && !isInTriggerZone && !isPlayingTriggerAnimation)
        {
            if (!string.IsNullOrEmpty(triggerAnimationName))
            {
                animator.Play(triggerAnimationName);
                isInTriggerZone = true;
                isPlayingTriggerAnimation = true;
                
                // Get the length of the trigger animation
                float triggerAnimationLength = GetAnimationLength(triggerAnimationName);
                
                // Automatically return to default animation after trigger animation finishes
                Invoke("ReturnToDefaultAnimation", triggerAnimationLength);
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        // Only respond to objects with the correct tag
        if (other.CompareTag(targetTag))
        {
            isInTriggerZone = false;
        }
    }
    
    private void ReturnToDefaultAnimation()
    {
        if (!string.IsNullOrEmpty(defaultAnimationName))
        {
            animator.Play(defaultAnimationName);
            isPlayingTriggerAnimation = false;
        }
    }
    
    private float GetAnimationLength(string animationName)
    {
        AnimationClip[] clips = animator.runtimeAnimatorController.animationClips;
        foreach (AnimationClip clip in clips)
        {
            if (clip.name == animationName)
            {
                return clip.length;
            }
        }
        return 1f; // Default to 1 second if animation not found
    }
}