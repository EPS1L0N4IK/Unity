using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //скорость движения врага
    public float speed;
    
    //цель к которой движется враг
    public Transform target;

    //очки урона от атаки врагом игрока
    public int playerDamage = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //каждый кадр меняет позицию NPC на новую
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //каждый кадр разворачивает NPC лицом к цели

        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Мы получаем компонент player у игрока
        Player player = other.GetComponent<Player>();
        
        player.TakeDamage(playerDamage);
    }
}
