using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void ExcuteMovement(MoveCommand moveCommand);
    void ExcutePlace(PlaceCommand placeCommand);
    void ExcuteRotate(RotateCommand rotateCommand);
    void ExcuteReport(ReportCommand reportCommand);
}
