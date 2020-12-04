using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Flock/Behaviour/Prey Behaviour")]
public class Prey : Life
{
    public CompositeBehavior animalBehavior;
    public Flock flock;
    public HideBehaviour Hide;
    public enum PreyInstincts
    {

        Wander,
        EvadeAndHide,

    }
    ;
    public PreyInstincts preyStates;

    public void Start()
    {
        StartCoroutine(PreyState());
    }
    public void Update()
    {
        flock.behavior = animalBehavior;
    }
    public IEnumerator PreyState()
    {


        while (preyStates == PreyInstincts.Wander)
        {
            SheepWander();
            if (Hide.enemies != null)
            {
                preyStates = PreyInstincts.EvadeAndHide;

            }

            yield return 0;
        }
        while (preyStates == PreyInstincts.EvadeAndHide)
        {
            SheepFleeAndHide();
            if (Hide.enemies == null)
            {
                preyStates = PreyInstincts.Wander;

            }

            yield return 0;
        }
      

    }
    //Wandering
    public void SheepWander()
    {
        Debug.Log("Wander Enter");
        animalBehavior = docileStateBehavior;
        stateAnim.SetBool("flee", false);
    }
  //Fleeing and Hiding
    public void SheepFleeAndHide()
    {
        Debug.Log("Hide Enter");
        animalBehavior = fleeStateBehaviour;
        stateAnim.SetBool("flee", true);
    }
}
