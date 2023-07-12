using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollManager : MonoBehaviour
{
    public Animator animator;
    public Rigidbody bodyRigidbody;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ragdoll(new Vector3(0,0,1), 10000f);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetRagdoll();
        }

    }

private void Ragdoll(Vector3 _direction, float _force)
    {
        animator.enabled = false;
        bodyRigidbody.AddForce(_direction * _force);
    }
    private void ResetRagdoll()
    {
        animator.enabled = true;
    }

}
