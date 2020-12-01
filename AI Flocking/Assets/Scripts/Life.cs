using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public CompositeBehavior animalBehavior;

    #region Variables
    public bool alive;
    public Animator stateAnim;

    private void Start()
    {
        alive = true;
    }
    private void Update()
    {
        if(alive == false)
        {
            
        }
    }

    #endregion

}
