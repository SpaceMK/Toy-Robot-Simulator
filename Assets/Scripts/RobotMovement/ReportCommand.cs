using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ReportCommand
{
    private ToyRobot toyRobot;


    public ReportCommand(ToyRobot toy)
    {
        toyRobot = toy;
    }

    public void ExcuteReport()
    {
        StringBuilder output = new StringBuilder();
        output.Append("Output : ")
              .Append(toyRobot.transform.position.x.ToString())
              .Append(",")
              .Append(toyRobot.transform.position.y.ToString())
              .Append(",").Append(toyRobot.ToyRobotOrientation.ToString());
        Debug.Log(output.ToString());
    }

	
}
