using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public AudioSource wrongGem;
    public bool isWrongGem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement pc = other.GetComponent<PlayerMovement>();
            if (pc != null)
            {
                if (isWrongGem)
                {
                    if (wrongGem != null && wrongGem.clip != null)
                    {
                        wrongGem.Play();
                    }
                }
                else
                {
                    pc.score += 1;
                    Destroy(gameObject);
                }

                Destroy(gameObject);
            }
        }
    }
}
