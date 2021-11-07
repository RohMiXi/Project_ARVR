using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class StarPath : MonoBehaviour
{
   public PathCreator PathCreator;
   float distanceTravelled;
   public float speed = 5;

   void Update()
   {
      distanceTravelled += speed * Time.deltaTime;
      transform.position = PathCreator.path.GetPointAtDistance(distanceTravelled);
      transform.rotation = PathCreator.path.GetRotationAtDistance(distanceTravelled);
   }
}
