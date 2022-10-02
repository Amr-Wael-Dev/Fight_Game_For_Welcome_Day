using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float moveSpeed = 5;
    private float roty;
    private Animator Anim;
    private health healthP;
    private float virticalvalue;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        healthP = GetComponent<health>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
            Anim.SetBool("walk", true);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
            Anim.SetBool("walk", true);

        }
        else
        {
            Anim.SetBool("walk", false);

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Anim.SetBool("puch1", true);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Anim.SetBool("puch2", true);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            Anim.SetBool("kick1", true);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            Anim.SetBool("kick2", true);
        }
        else
        {
            Anim.SetBool("puch1", false);
            Anim.SetBool("puch2", false);
            Anim.SetBool("kick1", false);
            Anim.SetBool("kick2", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("attack"))
        {
            healthP.decreasehelth(1);

        }
    }
}
