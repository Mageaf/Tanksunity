using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickEffect;
    public AddEffects manager;
    public static bool destroyed = false;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && !destroyed)
        {
             PickUp(other);
        }

    }
    void PickUp(Collider player)
    {
        Instantiate(pickEffect, transform.position, transform.rotation);
        StartCoroutine(manager.Shrink(player));
        Destroy(gameObject);
        destroyed = true;
    }
}
