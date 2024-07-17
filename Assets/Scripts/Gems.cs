using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public bool isWrongGem;
    public AudioClip wrongGemClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement pc = other.GetComponent<PlayerMovement>();
            if (pc != null)
            {
                if (isWrongGem)
                {
                    AudioSource playerAudioSource = other.GetComponent<AudioSource>();
                    if (playerAudioSource != null && wrongGemClip != null)
                    {
                        playerAudioSource.PlayOneShot(wrongGemClip);
                    }
                }

                else
                {
                    pc.score += 1;
                }

                Destroy(gameObject);
            }
        }
    }
}
