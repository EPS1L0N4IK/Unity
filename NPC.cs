using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //здоровье NPC
    public int health = 2;

    //уровень NPC
    public int level = 3;

    //скорость NPC
    public float speed = 1.2f;

    
    // Start is called before the first frame update
    void Start()
    {
        print($"Здоровье: {health + level}");


    }

    // Update is called once per frame
    void Update()
    {
        //Создаем переменную с типом данных Vector3 и сохраняем в нее позицию NPC
        Vector3 newPosition = transform.position;

        //Меняем позицию NPC по оси Z, согласно скорости NPC и временем между кадрами

        newPosition.z += speed * Time.deltaTime;
        
        //Меняем позицию NPC на новое значение рассчитанное выше

        transform.position = newPosition;
    }
}
