using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerMovement;
    public CharacterController player;
    public float speed = 1f;
    public float moveSpeed;
    public  Vector3 movement;
    private Animator anim;
    public  float jumpspeed = 10f;
    private bool jumping;

    private void Start()
    {
        player = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
  
    }

    private void Update()
    {

        // transform.Translate(0,0,1*speed*Time.deltaTime);
        // using update becuase we are not using rigidbody 

      //  movement = new Vector3(0,0,0);


        if (Input.GetKeyDown(KeyCode.Space) && player.isGrounded)
        {
            anim.SetTrigger("Jump");
            player.center = new Vector3(player.center.x, 1f, player.center.z);
            movement.y =+ 1*jumpspeed;
            Debug.Log("Jump is detected");
        }

        else

        {
            movement.y -= 9 * Time.deltaTime;
        }

        movement.z = 1 * moveSpeed * Time.deltaTime;

        movement.x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

      /*  if (player.isGrounded)
        {
            movement.y = 0;
            Debug.Log("Grounded");
        }
        else
        {
            movement.y -= 9 * Time.deltaTime;
        }*/
       

        player.Move(movement);
    }

/*    void ChangeCenter()
    {
        player.center = new Vector3(player.center.x, 80f, player.center.z);
    }

    void DefaultChan()
    {
        player.center = new Vector3(player.center.x, 55f, player.center.z);
    }*/

    void FixedUpdate()
    {
        /*  float LR = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
          Mathf.Clamp();
          transform.Translate(LR, 0, 1*speed);*/
       
        
   
    }
}
