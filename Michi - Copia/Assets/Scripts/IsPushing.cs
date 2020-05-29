using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPushing : MonoBehaviour
{
    public AudioSource push;
    public Animator playerAnimator;

    private void Awake()
    {
        push.Stop();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            push.Play();
            playerAnimator.SetBool("isPushing", true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerAnimator.SetBool("isPushing", false);
            if(push.isPlaying)
            {
                push.Stop();
            }
        }
    }
}
