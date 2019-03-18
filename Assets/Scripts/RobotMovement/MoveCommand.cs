using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand 
{
    private ToyRobot toyRobot;

    public MoveCommand(ToyRobot toy)
    {
        toyRobot = toy;
    }

    public void ExcuteMoveCommand()
    {

        if (toyRobot.CanMove)
        {
            if (CheckMovementXAxis() &&  CheckMovementYAxis())
            {
                toyRobot.transform.Translate(Vector3.up);
            }
        }
    }

    private bool CheckMovementXAxis()
    {

        int xAxis = 0;
        if (toyRobot.ToyRobotOrientation == Orientations.West) { xAxis = -1; }
        else if (toyRobot.ToyRobotOrientation == Orientations.East) { xAxis = 1; }
        
        if ((int)toyRobot.transform.position.x + xAxis >= toyRobot.MinXMovement.Value && (int)toyRobot.transform.position.x + xAxis < toyRobot.MaxXMovement.Value)
        {
            return true;
        }
        else
            return false;
    }

    private bool CheckMovementYAxis()
    {
        int yAxis = 0;
        if (toyRobot.ToyRobotOrientation == Orientations.North) { yAxis = 1; }
        else if(toyRobot.ToyRobotOrientation == Orientations.South) { yAxis = -1; }

        if ((int)toyRobot.transform.position.y + yAxis >= toyRobot.MinYMovement.Value && (int)toyRobot.transform.position.y + yAxis < toyRobot.MaxYMovement.Value)
        {
            return true;
        }
        else
            return false;

    }
}
