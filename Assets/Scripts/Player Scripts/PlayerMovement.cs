using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    private Animator Anim;
    private health healthP;
    private Rigidbody rb;
    private string axes;
    private string[] hitKeys2 = { "z", "x", "c" };
    private string[] hitKeys1 = { "j", "k", "l" };
    private string[] currentHitKeys;
    public GameObject[] hitColliders;
    [Range(1,2)]
    public int playerIndex;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        healthP = GetComponent<health>();
        rb = GetComponent<Rigidbody>();

        if (playerIndex == 1) {
            axes = "Horizontal";

            currentHitKeys = hitKeys1;
        } else {
            axes = "Horizontal2";

            currentHitKeys = hitKeys2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthP.Health <= 0) {
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            GetComponent<CapsuleCollider>().isTrigger = true;
            return;
        }

        float hor = Input.GetAxisRaw(axes);

        if (hor > 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            rb.velocity = new Vector3(-moveSpeed, 0, 0);
            Anim.SetBool("walk", true);
        }
        else if (hor < 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            rb.velocity = new Vector3(moveSpeed, 0, 0);
            Anim.SetBool("walk", true);
        } else {
            rb.velocity = Vector3.zero;
            Anim.SetBool("walk", false);
        }
        if (Input.GetKeyDown(currentHitKeys[0]))
        {
            Anim.SetTrigger("Punch1");
        }
        else if (Input.GetKeyDown(currentHitKeys[1]))
        {
            Anim.SetTrigger("Punch2");
        }
        // else if (Input.GetKeyDown(currentHitKeys[0]))
        // {
        //     Anim.SetTrigger("Kick1");
        // }
        else if (Input.GetKeyDown(currentHitKeys[2]))
        {
            Anim.SetTrigger("Kick2");
        }
    }

    private void FixedUpdate () {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("attack"))
    //     {
    //         healthP.decreasehelth(1);

    //     }
    // }

    public void Punch1Trigger (int damage) {
        hitColliders[0].SetActive(true);
        hitColliders[0].GetComponent<HitCollider>().damage = 20;
    }
    public void Punch1TriggerDisable () {
        hitColliders[0].SetActive(false);
    }

    public void Punch2Trigger (int damage) {
        hitColliders[0].SetActive(true);
        hitColliders[0].GetComponent<HitCollider>().damage = 40;
    }
    public void Punch2TriggerDisable () {
        hitColliders[0].SetActive(false);
    }
}
