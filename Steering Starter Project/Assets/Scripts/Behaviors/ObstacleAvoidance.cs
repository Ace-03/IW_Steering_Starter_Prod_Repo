using UnityEngine;

public class ObstacleAvoidance : Seek
{
    float avoidDistance = 50f;

    float lookahead = 90f;

    protected override Vector3 getTargetPosition()
    {
        RaycastHit hit;
        if (Physics.Raycast(character.transform.position, character.linearVelocity, out hit, lookahead))
        {
            return hit.point + (hit.normal * avoidDistance);
        }
        else
        {
            return base.getTargetPosition();
        }

    }

}