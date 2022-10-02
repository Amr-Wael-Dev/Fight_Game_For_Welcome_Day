using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator_move : MonoBehaviour
{
      private Animator Anim;
void Awake() {
    Anim = GetComponent<Animator>();
    }

public void Walk (bool move)
{
    Anim.SetBool(AnimationTags.MOVEMENT,move);

}
public void Puch_1(){
    Anim.SetTrigger(AnimationTags.PUNCH_1_TRIGGER);
}
public void Puch_(){
    Anim.SetTrigger(AnimationTags.PUNCH_2_TRIGGER);
}

public void Puch_3(){
    Anim.SetTrigger(AnimationTags.PUNCH_3_TRIGGER);
}
public void kick_1(){
    Anim.SetTrigger(AnimationTags.KICK_1_TRIGGER);
}
public void kick_2(){
    Anim.SetTrigger(AnimationTags.KICK_2_TRIGGER);
}
}
