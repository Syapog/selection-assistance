using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour
{
    public GameObject Player;

   
    public int S;

    
    public void NAZAD()
    {
       
        S = Random.Range(2, 4);
       
        Player.transform.Translate(0, 0, -S);
    }

    public void VPERED()
    {
        
        S = Random.Range(2, 4);
       
        Player.transform.Translate(0, 0, S);
    }

}
