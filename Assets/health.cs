using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{private TextMesh scoretext;
public GameObject score;
    public Slider Helth_Slider;
    public float Health;
    private const float Max_health=130f;
    private Animator ANIM;
    void Start()
    {
          PlayerPrefs.SetString("Your Score Is","0");
        ANIM=GetComponent<Animator>();
        Health=Max_health;
    }
    public void decreasehelth(int amountofhealth)
    {
        Health-=amountofhealth;
        Helth_Slider.value=Health;
        if(Health<=0)
        {
            
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    
}
