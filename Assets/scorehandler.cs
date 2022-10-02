using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorehandler : MonoBehaviour
{
    public GameObject score;
   
    private Text currentscore;

    // Start is called before the first frame update
    void Start()
    {
        currentscore=score.GetComponent<Text>();
      
        currentscore.text="Your Score Is"+PlayerPrefs.GetString("Your Score Is");
    }

    
}
