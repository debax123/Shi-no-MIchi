using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysics : MonoBehaviour
{
    public Animator playerAnimator;
    public CharacterController controller;
    public float pushForce = 2.0f;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (controller.isGrounded)
        {
            Rigidbody body = hit.collider.attachedRigidbody;

            //checking whether rigidbody is either non-existant or kinematic
            if (body == null || body.isKinematic)
                return;

            if (hit.moveDirection.y < -.3f)
                return;

            //set up push direction for object
            Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

            //apply push force to object
            body.velocity = pushForce * pushDirection;
        }
    }

}
