using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int power;
    public int health;
    public string position;
    public string cardDesc;
    public string position;

    public Card(){

    }

    public Card(int id, string cardName, int cost, int health, string position, string cardDesc){
        id = id;
        cardName = cardName;
        power = power;
        health = health;
        position = position
        cardDesc = cardDesc;
    }

    
} 
