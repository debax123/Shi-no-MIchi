using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsSounds : MonoBehaviour
{
    public AudioSource steps;
    public AudioClip steps1;
    public AudioClip steps2;
    public AudioClip jump;

    public void PlaySteps()
    {
        steps.clip = steps1;
        steps.Play();
    }
    public void PlaySteps2()
    {
        steps.clip = steps2;
        steps.Play();
    }
    public void PlayJump()
    {
        steps.clip = jump;
        steps.Play();
    }
}
