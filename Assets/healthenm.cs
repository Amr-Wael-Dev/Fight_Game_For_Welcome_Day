using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthenm : MonoBehaviour
{
    public int Health;
    private const int Max_health=20;
    private Animator ANIM;
    void Start()
    {
        ANIM=GetComponent<Animator>();
        Health=Max_health;
    }
    public void decreasehelth(int amountofhealth)
    {
        Health-=amountofhealth;
        if(Health<=0)
        {

FindObjectOfType<SCORE>().increaseScore();

        }
    }
   private void OnTriggerEnter(Collider other) {
    if(Health<=0)
{
    Destroy(gameObject);
}
   }
   }