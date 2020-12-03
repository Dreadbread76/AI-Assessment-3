using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
   
   
   
    public CompositeBehavior pounceStateBehavior;
    public CompositeBehavior pursuitStateBehavior;
    public CompositeBehavior docileStateBehavior;
    public CompositeBehavior fleeStateBehaviour;



    #region Variables
    public Animator stateAnim;

    private void Start()
    {
      

    }
   
    #endregion

}
