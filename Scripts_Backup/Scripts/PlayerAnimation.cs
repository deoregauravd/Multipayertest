using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator anim;
    public enum MovementState {idleState, walkState, pickWeaponState}
    //public Button pickWeaponButton;
    //public Button walkButton;

 


   void start()
   {
       anim = GetComponent< Animator >();
   }

   void update()
   {   
     IdleState();
     PickWeaponState();
     WalkState();
   }
   
   public void IdleState()
   {
      MovementState state;
      state = MovementState.idleState;
      anim.SetInteger("state",(int)state);
   }
   
    public void PickWeaponState()
   {
      MovementState state;
      state = MovementState.pickWeaponState;
      anim.SetInteger("state",(int)state);
   }

   public void WalkState()
   {
     MovementState state;
     state = MovementState.walkState;
     anim.SetInteger("state",(int)state);
   } 
}
 /* private void UpdateAnimatorAnimation()
   {
      MovementState state;

      if( Input.GetButtonDown("Horizontal") )
      {
        state = MovementState.pickWeaponState;
      }
      else if( Input.GetButtonDown("Vertical"))
      {
        state = MovementState.walkState;
      }
      else
      {
        state = MovementState.walkState;
      }
      anim.SetInteger("state",(int)state); /*
  


   public void PickWeaponState()
   {
      MovementState state;
      state = MovementState.pickWeaponState;
      anim.SetIntegerr("state",(int)state);
   }

   public void WalkState()
   {
     MovementState state;
     state = MovementState.pickWeaponState;
     anim.SetIntegerr("state",(int)state);
   }



}*/
