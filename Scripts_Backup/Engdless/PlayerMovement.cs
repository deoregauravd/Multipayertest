using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    // Player Physics
    public Transform playerMovement;
    public CharacterController player;
    public float speed = 1f;
    public float moveSpeed;
    public  Vector3 movement;
   

    // Player GUI
    public static int health;
    public int startHealth = 3;
    public float distanceCover;
   


    // Player Animation
    private Animator anim;
    public  float jumpspeed = 1f;
    public Transform scenetwoPos;

    // Scenes in Game
    public GameObject sceneOne;
    public GameObject sceneTwo;
    public GameObject sceneThree;
    public Transform[] hurdlePos;
   // public static GameObject hurdle;
    private enum MovementState { jump , right, left, slide, run };

    public static PlayerMovement instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    private void Start()
    {
        player = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

        health = startHealth;
    }

    private void Update()
    {
        UpdateAnimatorAnimation();
        DistanceCovered();
    }

    private void UpdateAnimatorAnimation()
    {
        MovementState state;

        if (Input.GetKeyDown(KeyCode.Space) && player.isGrounded)
        {
            state = MovementState.jump;
            player.center = new Vector3(player.center.x, 1f, player.center.z);
            movement.y = +1 * jumpspeed;
            //Debug.Log("Jump is detected");
        }
        else if (player.velocity.z > 1)
        {
            movement.y -= 6 * Time.deltaTime;
            //Debug.Log("Centerchage");
            state = MovementState.run;
        }
        else
        {
            movement.y -= 7 * Time.deltaTime;  //Adding Gravity to scene.
            state = MovementState.run;
        }
        if (player.velocity.x > 0.1f)
        {
            state = MovementState.right;
           // Debug.Log("Right");
        }
        else if (player.velocity.x < 0) //(-0.1f))
        {
            state = MovementState.left;
            //Debug.Log("left");
        }
     
        anim.SetInteger("state", (int)state);

        movement.z = 1 * moveSpeed * Time.deltaTime;

        movement.x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        player.Move(movement);

        player.center = new Vector3(player.center.x, 8f, player.center.z);
      
        UpdateRoad();

    }

    public void UpdateRoad()
    {
        if (playerMovement.position.z > 15 && playerMovement.position.z < 55 )
        {
            //GameObject scenetwo = GameObject.FindGameObjectWithTag("sceneTwo");
            sceneTwo.transform.position = new Vector3(0, 0, 55);
            sceneTwo.SetActive(true);
            Debug.Log("scene TwoActivation");
            HurdleGenration();

        }
        else if (sceneTwo.activeInHierarchy && playerMovement.position.z > 65)
        {
            sceneThree.transform.position = new Vector3(0, 0, 110);
            sceneThree.SetActive(true);
            sceneOne.SetActive(false);
            Debug.Log("scene one deactivation");  
        }

        else if (sceneThree.activeInHierarchy && playerMovement.position.z > 110)
        {
            sceneOne.transform.position = new Vector3(0,0,165);
            sceneOne.SetActive(true);
            sceneTwo.SetActive(false);
            Debug.Log("scene one Reactivation");
        }

        void HurdleGenration()
        {

            GameObject hurdle = ObjectPool.SharedInstance.GetPooledObject();
            for (int i = 0; i < ObjectPool.SharedInstance.pooledObjects.Count; i++)
            {
                if (hurdle != null) // if you dont use this codition its going to return null value from object pooling and it will cause null reference
                {
                    Vector3 position = hurdlePos[i].position;
                    ObjectPool.SharedInstance.pooledObjects[i].transform.position = position; //new Vector3(0, 5, (i * 30));
                    hurdle.gameObject.SetActive(true);
                }
                
            }
          
        }
       
    }
    public void DistanceCovered()
    {
        distanceCover = playerMovement.position.z;

      //  Debug.Log(distanceCover + "distacecover");
    }
}


// code used priviously 


/*  if (player.isGrounded)
      {
          movement.y = 0;
          Debug.Log("Grounded");
      }
      else
      {
          movement.y -= 9 * Time.deltaTime;
      }*/

/*  float LR = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
         Mathf.Clamp();
         transform.Translate(LR, 0, 1*speed);*/ // fixed update


/*    void ChangeCenter()
    {
        player.center = new Vector3(player.center.x, 80f, player.center.z);
    }

    void DefaultChan()
    {
        player.center = new Vector3(player.center.x, 55f, player.center.z);
    }


  /*  if (hurdle != null)
              {
                  hurdle.transform.position = new Vector3(0, 0, 55);
                  hurdle.transform.position = new Vector3(0, 0, 110);
                  hurdle.gameObject.SetActive(true);
              }*/



/*public void UpdateRoad()
{
   if (playerMovement.position.z > 10)
    {
        Debug.Log("moment of z is dectected");
        ObjectPool.SharedInstance.GetPooledObject();
        transform.position = new Vector3(0, 0, 55);
        ObjectPool.SharedInstance.GetPooledObject().SetActive(true);

    }
}*/


/* foreach (GameObject hurdle in  ObjectPool.SharedInstance.pooledObjects)
 {
    // hurdle.transform.position = new Vector3(0, 0, 55);
     //hurdle.transform.position = new Vector3(0, 0, 110);
     hurdle.gameObject.SetActive(true);
 }

*/