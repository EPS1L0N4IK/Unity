using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    // Update is called once per frame
    void Update()
    {
        // Здесь мы обновляем здоровье игрока
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;

        // Здесь мы будем обновлять текст с количеством монеток
        coinsCounterText.text = player.coins.ToString();
        
    }
}
