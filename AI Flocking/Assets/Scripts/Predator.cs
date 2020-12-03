using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Flock/Behaviour/Predator Behaviour")]

public class Predator : Life
{

    public Flock flock;

    public CompositeBehavior animalBehavior;

    public PursuitBehavior pursue;
    public PounceBehaviour pounce;

    #region Variables
    public float pursueMultiplier = 2f;
    public float pounceMultiplier = 5f;
    

    [System.Serializable]
   
    
    #endregion
    

    public enum predatorInstincts
    {
        Patrol,
        Pursue,
        Attack,

    }
    ;

    public predatorInstincts predator;

    public void Start()
    {
        StartCoroutine(PredatorStates());
    }
    public void Update()
    {
        flock.behavior = animalBehavior;
    }
    // Update is called once per frame
    public IEnumerator PredatorStates()
   {
        while(predator == predatorInstincts.Patrol)
        {
            Patrol();
            if (pursue.enemies != null)
            {
                predator = predatorInstincts.Pursue;
            }

            yield return 0;
        }
      
        while (predator == predatorInstincts.Pursue)
        {
            Pursue();
            if (pursue.enemies == null)
            {
                predator = predatorInstincts.Patrol;
            }
           

            yield return 0;
        }

    }

    public void Patrol()
    {
        Debug.Log("Patrol Enter");
        animalBehavior = docileStateBehavior;
        
        stateAnim.SetBool("pursue", false);
    }
   
    public void Pursue()
    {
        Debug.Log("Pursue Enter");
        animalBehavior = pounceStateBehavior;
        stateAnim.SetBool("pursue", true);
    }
    
    
    
    
}
