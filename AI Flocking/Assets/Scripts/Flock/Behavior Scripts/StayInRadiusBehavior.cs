﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Flock/Behavior/Stay In Radius")]
public class StayInRadiusBehavior : FlockBehavior
{
    public Vector2 center;
    public float radius = 15f;
    public float returnPercent = 0.9f;

    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, List<Transform> areaContext, Flock flock)
    {
        if (agent != null)
        {

        }
        
        Vector2 centerOffset = center - (Vector2)agent.transform.position;

        float t = centerOffset.magnitude / radius;
        if(t < returnPercent)
        {
            return Vector2.zero;
        }
        return centerOffset * t * t;
    }
}
