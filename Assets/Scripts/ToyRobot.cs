using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyRobot : MonoBehaviour
{
   public bool CanMove { get; set; }
   public Orientations ToyRobotOrientation { get; set; }
   public IntergerObject MaxXMovement, MinXMovement, MaxYMovement, MinYMovement;

} 
