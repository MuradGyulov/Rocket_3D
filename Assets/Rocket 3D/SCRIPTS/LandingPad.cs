using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingPad : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    private bool IsCollided = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rocket" && !IsCollided)
        {
            audioSource.Play();
        }
    }
}
