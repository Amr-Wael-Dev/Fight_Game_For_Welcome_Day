using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCollider : MonoBehaviour
{
    public PlayerMovement myPlayer;
    public int damage;

    public void OnTriggerEnter(Collider other) {
        if (myPlayer.playerIndex == 1) {
            if (other.gameObject.tag == "P2") { 
                other.gameObject.GetComponent<health>().decreasehelth(damage);
                other.gameObject.GetComponent<Animator>().SetTrigger("Hit");
                this.gameObject.SetActive(false);
            }
        } else {
            if (other.gameObject.tag == "P1") {
                other.gameObject.GetComponent<health>().decreasehelth(damage);
                other.gameObject.GetComponent<Animator>().SetTrigger("Hit");
                this.gameObject.SetActive(false);
            }
        }
    }
}
