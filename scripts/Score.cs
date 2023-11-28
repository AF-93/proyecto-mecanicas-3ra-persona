using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    
 
    void Update()
    {        
        int carrotsCount = GameObject.FindGameObjectsWithTag("Carrot").Length;
        textUI.text = "Carrots: " + carrotsCount;
        if(carrotsCount == 0){
            textUI.text = "You Ate'em All!!";
        }
    }
}
