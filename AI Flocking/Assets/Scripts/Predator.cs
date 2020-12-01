using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Flock/Behaviour/Predator Behaviour")]

public abstract class Predator : Life
{
    

    #region Variables
    public float pursueMultiplier = 2f;
    public float pounceMultiplier = 5f;
    

    [System.Serializable]
   
    
    #endregion
    

    public enum predatorInstincts
    {
        Patrol,
        Seek,
        Pursue,
        Attack,

    }
    ;

    public predatorInstincts predator;
    

    // Update is called once per frame
   IEnumerator PredatorStates()
   {
        while(predator == predatorInstincts.Patrol)
        {
            Patrol();

            yield return 0;
        }

   }

    public void Patrol()
    {
        Debug.Log("Patrol Enter");
        animalBehavior.Flocks[6].weight = 0;
        stateAnim.SetBool("pursue", false);
    }
    public void Seek()
    {
        Debug.Log("Patrol Enter");
        stateAnim.SetBool("pursue", false);
    }
    public void Pursue()
    {
        Debug.Log("Patrol Enter");
        animalBehavior.Flocks[6].weight = 10;
        stateAnim.SetBool("pursue", true);
    }
    public void Attack()
    {
        
        Debug.Log("Attacking");
        stateAnim.SetBool("pursue", true);
    }
    
    
    
}
