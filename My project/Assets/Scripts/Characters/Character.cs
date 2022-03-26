using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character",fileName = "New Character")]
public class Character : ScriptableObject
{
    public string id;
    public string characterName;
    public int attack;
    public int defense;
    public int health;
    public int score;

}
