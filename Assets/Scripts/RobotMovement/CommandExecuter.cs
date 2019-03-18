using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandExecuter : ICommand
{
   
    public void ExcuteMovement(MoveCommand moveCommand)
    {
        moveCommand.ExcuteMoveCommand();
    }

    public void ExcutePlace(PlaceCommand placeCommand)
    {
        placeCommand.PlaceToyRobot();
    }

    public void ExcuteReport(ReportCommand reportCommand)
    { 
        reportCommand.ExcuteReport();
    }

    public void ExcuteRotate(RotateCommand rotateCommand)
    {
        rotateCommand.ExcuteRotate();
    }
}

public enum Commands
{
    Place,
    Move,
    Left,
    Right,
    Report
}
