using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        Destroy(gameObject, 3);
        
    }

    void onTriggerEnter(Collider other)
    {
        Enemy opponent = other.GetComponent<Enemy>();
        Destroy(opponent.gameObject);
        Destroy(gameObject);
    }
}
