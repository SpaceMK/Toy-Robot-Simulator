using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCommand
{
    private ToyRobot toyRobot;
    private Commands commands;


   public RotateCommand(ToyRobot toy,Commands com)
    {
        toyRobot = toy;
        commands = com;
    }

    public void ExcuteRotate()
    {
        float rotationAmount = commands == Commands.Right ? -90 : 90;
        toyRobot.gameObject.transform.rotation =  Quaternion.Euler(toyRobot.transform.rotation.eulerAngles.x,toyRobot.transform.rotation.eulerAngles.y, toyRobot.transform.rotation.eulerAngles.z + rotationAmount);
        UpdateOrientation();

    }

    private void UpdateOrientation()
    {
        switch ((int)toyRobot.transform.rotation.eulerAngles.z)
        {
            case 0:
                toyRobot.ToyRobotOrientation = Orientations.North;
                break;
            case 90:
                toyRobot.ToyRobotOrientation = Orientations.West;
                break;
            case 180:
                toyRobot.ToyRobotOrientation = Orientations.South;
                break;
            case 270:
                toyRobot.ToyRobotOrientation = Orientations.East;
                break;
        }
    }
}

public enum Orientations
{
    North,
    South,
    East,
    West
}


