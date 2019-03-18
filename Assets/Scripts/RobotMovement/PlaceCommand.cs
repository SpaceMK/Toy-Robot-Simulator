using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCommand
{
    ToyRobot toyRobot;
    int xCoordinate, yCooridinate;
    Orientations startingOrientation;

    public PlaceCommand(ToyRobot toy,PlacementCoordinates placementVar)
    {
        toyRobot = toy;
        xCoordinate = placementVar.XPlacement;
        yCooridinate = placementVar.YPlacement;
        startingOrientation = placementVar.orientations;
    }

    public void PlaceToyRobot()
    {
        if (xCoordinate >= toyRobot.MinXMovement.Value && xCoordinate < toyRobot.MaxXMovement.Value)
        {
            if (yCooridinate >= toyRobot.MinYMovement.Value && yCooridinate<toyRobot.MaxYMovement.Value)
            {
                toyRobot.CanMove = true;
                toyRobot.transform.position = new Vector3(xCoordinate, yCooridinate, toyRobot.transform.position.z);
                toyRobot.ToyRobotOrientation = startingOrientation;
            }
        }
        else
        {
            toyRobot.CanMove = false;
        }
        SetRobotFaceing();
    }

    public void SetRobotFaceing()
    {
        switch (startingOrientation)
        {
            case Orientations.North:
                toyRobot.gameObject.transform.rotation = Quaternion.Euler(toyRobot.transform.rotation.eulerAngles.x, toyRobot.transform.rotation.eulerAngles.y, 0);
                break;
            case Orientations.South:
                toyRobot.gameObject.transform.rotation = Quaternion.Euler(toyRobot.transform.rotation.eulerAngles.x, toyRobot.transform.rotation.eulerAngles.y, 180);
                break;
            case Orientations.West:
                toyRobot.gameObject.transform.rotation = Quaternion.Euler(toyRobot.transform.rotation.eulerAngles.x, toyRobot.transform.rotation.eulerAngles.y, 90);
                break;
            case Orientations.East:
                toyRobot.gameObject.transform.rotation = Quaternion.Euler(toyRobot.transform.rotation.eulerAngles.x, toyRobot.transform.rotation.eulerAngles.y,-90);
                break;
        }

    }
}


[System.Serializable]
public struct PlacementCoordinates
{
    public int XPlacement , YPlacement;
    public Orientations orientations;
}


