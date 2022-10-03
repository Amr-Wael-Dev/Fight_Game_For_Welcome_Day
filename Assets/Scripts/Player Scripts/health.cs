using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{
    [HideInInspector]
    public float Health;
    public float Max_health = 130f;

    private Animator ANIM;
    public Slider Helth_Slider;
    void Start()
    {
        ANIM=GetComponent<Animator>();
        Health=Max_health;
    }
    public void decreasehelth(int amountofhealth)
    {
        Health-=amountofhealth;
        Helth_Slider.value=Health;
        if(Health<=0)
        {        
            ANIM.SetBool("Death", true);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    
}
