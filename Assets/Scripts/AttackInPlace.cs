using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInPlace : MonoBehaviour
{
    public Animator animator;
    public ThirdPersonCharacterController characterControllerScript; // Reference to the ThirdPersonCharacterController
    private bool isAttacking = false; // Track if the character is attacking

    void Start()
    {
        if (characterControllerScript == null)
            characterControllerScript = GetComponent<ThirdPersonCharacterController>(); // Get the ThirdPersonCharacterController component
    }

    void Update()
    {
        // Trigger attack when the attack button (Fire1) is pressed
        if (Input.GetButtonDown("Fire1") && !isAttacking)
        {
            StartCoroutine(AttackCoroutine());
        }
    }

    // Coroutine to handle attack animation and lock movement during attack
    private IEnumerator AttackCoroutine()
    {
        isAttacking = true;

        // Disable movement while the character is attacking
        characterControllerScript.enabled = false;  // Disable the character movement logic

        // Trigger the attack animation
        animator.SetTrigger("isAttacking");

        // Wait for the attack animation to finish (assuming it lasts for 1 second)
        yield return new WaitForSeconds(1f); // Adjust this duration to match the attack animation length

        // Re-enable movement after the attack
        characterControllerScript.enabled = true;

        isAttacking = false;
    }
}
