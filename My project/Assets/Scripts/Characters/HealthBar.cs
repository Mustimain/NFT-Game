using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Character character;


    // Start is called before the first frame update
    void Start()
    {
        character.health = 100;
        slider.maxValue = character.health;

    }

    // Update is called once per frame
    void Update()
    {
        if (character.health <= -1)
        {
            character.health = 100;
        }

        
        slider.value = character.health;
    }
}
