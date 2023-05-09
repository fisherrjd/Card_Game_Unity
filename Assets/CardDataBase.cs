using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

    public static List<Card> cardList = new List<Card>();

    void Awake (){
        cardList.Add (new Card(0,"None", 0, 0, "none", "null card"));
        cardList.Add (new Card(1,"Pitcher", 2, 100,"pitcher", "throws ball"));
        cardList.Add (new Card(2,"Catcher", 2, 100,"catcher", "catches ball"));
        cardList.Add (new Card(3,"First_Base", 2, 100,"first basemen", "plays first base"));
        cardList.Add (new Card(4,"Second_Base", 2, 100,"second basemen", "plays second base"));
    }

}
