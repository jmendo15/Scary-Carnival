using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class blockerTrigger : MonoBehaviour
{

    public GameObject blocker;

    void Start()
    {
        blocker.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            blocker.SetActive(true);
        }
    }
}
