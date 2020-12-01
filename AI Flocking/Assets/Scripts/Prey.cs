using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Flock/Behaviour/Prey Behaviour")]
public abstract class Prey : Life
{
    public Animator stateAnim;
    public HideBehaviour Hide;
    public enum PreyInstincts
    {

        Wander,
        EvadeAndHide,

    }
    ;
    public PreyInstincts preyStates;
    IEnumerator PreyState()
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
            SheepHide();
            if (Hide.enemies == null)
            {
                preyStates = PreyInstincts.Wander;

            }

            yield return 0;
        }
      

    }
    public void SheepWander()
    {
        Debug.Log("Wander Enter");
        animalBehavior.Flocks[6].weight = 0;
        stateAnim.SetBool("flee", false);
    }
  
    public void SheepHide()
    {
        Debug.Log("Hide Enter");
        animalBehavior.Flocks[6].weight = 2;
        stateAnim.SetBool("hide", true);
    }
}
