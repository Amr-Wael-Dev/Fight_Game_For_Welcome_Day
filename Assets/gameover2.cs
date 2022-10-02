using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameover2 : MonoBehaviour
{
   public Text score;
   SCORE SCore;
   private int cscore;
   public void increaseScore1()
   {
    cscore++;
    score.text="Your Score Is"+cscore.ToString();
   }
}