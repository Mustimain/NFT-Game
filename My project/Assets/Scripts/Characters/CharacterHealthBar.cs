using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBar : MonoBehaviour
{
    public Slider slider;
    public Character character;

    void Start()
    {
        character.health = 100;
        slider.maxValue = character.health;

    }

    void Update()
    {
        if (character.health <= -1)
        {
            character.health = 100;
        }

        slider.value = character.health;
    }
}
