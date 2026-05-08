using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAlertZone : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource alarmAudio;

    void Start()
    {
        alarmAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!alarmAudio.isPlaying)
            {
                alarmAudio.Play();
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            alarmAudio.Stop();
        }
    }
}