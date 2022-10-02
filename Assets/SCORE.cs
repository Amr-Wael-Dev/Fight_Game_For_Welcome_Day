using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SCORE : MonoBehaviour
{
   public Text score;
   public Text highscore;
   private int cscore;
   private int highscore1;
   public void increaseScore()
   {
    cscore++;
    score.text=cscore.ToString();
    if (highscore1>cscore)
    {
      PlayerPrefs.SetInt("HighScore",highscore1);
    }
   }
}
