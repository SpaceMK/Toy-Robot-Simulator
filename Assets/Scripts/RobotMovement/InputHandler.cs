using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler: MonoBehaviour 
{
    [SerializeField] private ToyRobot toyRobot;
    [SerializeField] private TestCase testCase;

    private PlacementCoordinates placementCoordinates;
    private ICommand commandExucute;
    private int PlacementCoordinatesIndex=0;


    private void Start()
    {
        commandExucute = new CommandExecuter();
        RunTest();
    }

    private void RunTest()
     {
        for (int i = 0; i < testCase.TestCases.Capacity; i++)
        {
            CheckCommand(testCase.TestCases[i]);
        }
     }

    private void CheckCommand(Commands command)
    {
        switch (command)
        {
            case Commands.Place:
                placementCoordinates = testCase.ReturnPlacementCoordinates(PlacementCoordinatesIndex);
                PlaceCommand placeCommand = new PlaceCommand(toyRobot,placementCoordinates);
                commandExucute.ExcutePlace(placeCommand);
                PlacementCoordinatesIndex++;
                break;
            case Commands.Move:
                MoveCommand moveCommand = new MoveCommand(toyRobot);
                commandExucute.ExcuteMovement(moveCommand);
                break;
            case Commands.Left:
            case Commands.Right:
                RotateCommand rotateCommand = new RotateCommand(toyRobot,command);
                commandExucute.ExcuteRotate(rotateCommand);
                break;
            case Commands.Report:
                ReportCommand reportCommand = new ReportCommand(toyRobot);
                commandExucute.ExcuteReport(reportCommand);
                break;
        }
    }

}
