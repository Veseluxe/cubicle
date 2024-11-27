using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoretext;

    // Update is called once per frame
    void Update()
    { 
        scoretext.text=player.position.z.ToString("0 ") ;
        
    }
}
