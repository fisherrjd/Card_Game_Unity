using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int cost;
    public int health;
    public string cardDesc;

    public Card(){

    }

    public Card(int id, string cardName, int cost, int health, string cardDesc){
        id = id;
        cardName = cardName;
        cost = cost;
        health = health;
        cardDesc = cardDesc;
    }

    
} 
