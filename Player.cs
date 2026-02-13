using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coins = 0;
    private int health = 10;
    // Start is called before the first frame update
    public void CollectCoins()
    {
        coins++;
        print($"Количество монеток: {coins}");
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print($"Здоровья игрока: {health}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
            
            
        }
    

    }
}
