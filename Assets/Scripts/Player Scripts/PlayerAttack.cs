using System.Collections;
 using System.Collections.Generic;
using UnityEngine;



public class PlayerAttack : MonoBehaviour {
    private Animator Punch1;
    private CharacterAnimation player_anim;
    private void Awake()
    {
        player_anim=GetComponentInChildren<CharacterAnimation>();
    }
    private void Update()
    {
        comboAttack();
    }
    void comboAttack(){
        if(Input.GetKeyDown(KeyCode.Z)){
            player_anim.Punch_1();
            Punch1.SetBool("Punch1",true);
        }
                if(Input.GetKeyDown(KeyCode.X)){
                    player_anim.Kick_1();

    }

    }
}
































