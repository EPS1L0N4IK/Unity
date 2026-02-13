using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Player hero = other.GetComponent<Player>();
        hero.CollectCoins();
        Destroy(gameObject);
    }   

    // Update is called once per frame   
}