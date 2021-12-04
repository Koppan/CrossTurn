using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_arm_sound : MonoBehaviour
{
    [SerializeField]
    private AudioClip triggerSound;

    private AudioSource audioSource;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void OnTriggerEnter(Collider col)
    {
        if (audioSource != null)
            audioSource.PlayOneShot(triggerSound, 0.7f);
    }
}
