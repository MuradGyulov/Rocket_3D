using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float RocketForce;
    [SerializeField] private float RocketRotationSpeed;
    [Space(20)]
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private GameObject sparksObject;
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private Transform thisTransform;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private ParticleSystem[] jetFlame = new ParticleSystem[6];

    private void FixedUpdate()
    {
        RocketRotate();
        RocketFlight();
    }

    private void RocketFlight()
    {
        float force = playerInput.jumpInput;
        rigidBody.AddRelativeForce(Vector3.up * force * RocketForce, ForceMode.Acceleration);

        if (force > 0)
        {
            if (!audioSource.isPlaying) { audioSource.Play(); }
            foreach (ParticleSystem ps in jetFlame) { ps.Play(); }
        }
        else
        {
            foreach (ParticleSystem ps in jetFlame) { ps.Stop(); }
            audioSource.Stop();
        }
    }

    private void RocketRotate()
    {
        float rotate = -playerInput.horizontalInput;
        transform.Rotate(0, 0, rotate * RocketRotationSpeed);
        if(rotate > 0) { rigidBody.angularVelocity = Vector3.zero; }

        thisTransform.eulerAngles = new Vector3(0.0f, 0.0f, thisTransform.eulerAngles.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Untagged")
        {
            ContactPoint contact = collision.contacts[0];
            GameObject spark = Instantiate(sparksObject);
            Vector3 pos = contact.point;
            spark.transform.position = pos;
        }
    }
}
