using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

    public static List<Card> cardList = new List<Card>();

    void Awake (){
        cardList.Add (new Card(0,"None", 0, 0, "null card"));
        cardList.Add (new Card(1,"Pitcher", 2, 100, "throws ball"));
        cardList.Add (new Card(2,"Catcher", 2, 100, "catches ball"));
        cardList.Add (new Card(3,"First_Base", 2, 100, "plays first base"));
        cardList.Add (new Card(4,"Second_Base", 2, 100, "plays second base"));
    }

}
