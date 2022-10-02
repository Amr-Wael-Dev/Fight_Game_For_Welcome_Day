using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteranimation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
     private void Awake()
    {
        anim= GetComponent<Animator>();
    }
    public void Walk(bool movement){
        anim.SetBool(AnimationTags.MOVEMENT,movement);
    }
    public void Puch1(){
        anim.SetTrigger(AnimationTags.PUNCH_1_TRIGGER);
    }
     public void Puch2(){
        anim.SetTrigger(AnimationTags.PUNCH_2_TRIGGER);
    }

  public void Kick1(){
        anim.SetTrigger(AnimationTags.KICK_1_TRIGGER);
    }
    
  public void Kick2(){
        anim.SetTrigger(AnimationTags.KICK_2_TRIGGER);
    }
}