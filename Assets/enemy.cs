using System.Collections;

using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public float maxspeed = 2;
    private Animator playeranim;
    public float currentspeed;
    public float stoppingDistance = 0.9f;
    private PlayerMovement player;
    private healthenm playerH;
    private Animator animator;
    private NavMeshAgent agent;
    private bool hit;

    private bool startMove = false;
    private void Awake()
    {
        playerH=GetComponent<healthenm>();
        player = FindObjectOfType<PlayerMovement>();
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        playeranim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }
    private IEnumerator Start()
    {
        yield return (new WaitForSeconds(1));
        startMove = true;
    }
    private void Update()
    {

        if (!startMove)
            return;
        if (Vector3.Distance(transform.position, player.transform.position) >= stoppingDistance)
        {
            //Debug.Log("Distanse is " + Vector3.Distance(transform.position, player.transform.position));
            //Debug.Log("Stopping Distanse is " +stoppingDistance);

            agent.SetDestination(player.transform.position);
            animator.SetBool("walk", true);
            animator.SetBool("kick", false);
            
        }
        else
        {
            Debug.Log("Stopped");
            //agent.SetDestination(transform.position);
            animator.SetBool("walk", false);
            if(!animator.GetBool("hit1"))
                animator.SetBool("kick", true);

        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.CompareTag("Enemy Body")&&
        (playeranim.GetCurrentAnimatorStateInfo(0).IsName("puch1")||playeranim.GetCurrentAnimatorStateInfo(0).IsName("puch2")||
        playeranim.GetCurrentAnimatorStateInfo(0).IsName("kick1")||playeranim.GetCurrentAnimatorStateInfo(0).IsName("kick2")))
        {
            playerH.decreasehelth(5);
            animator.SetBool("hit1",true);
            animator.SetBool("walk", false);
            Invoke("Hit",1);
        }

    }
    private void Hit(){
        

        animator.SetBool("hit1",false);
    }
}