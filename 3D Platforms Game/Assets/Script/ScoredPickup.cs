using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class ScoredPickup : MonoBehaviour
{
    public int value;

    public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddScore(value);
            Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
