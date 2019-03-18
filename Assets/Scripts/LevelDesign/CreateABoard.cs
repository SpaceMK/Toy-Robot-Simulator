using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class CreateABoard : MonoBehaviour
{

    //This class is to showcase the use of the 

    [SerializeField] private GameObject boardSegment;
    [SerializeField] private IntergerObject boardXsize, boardYSize;

    private void Start()
    {
        CreateBoard();
    }

    private void CreateBoard()
    {
        for (int i = 0, y = 0; y < boardYSize.Value; y++)
        {
            for (int x = 0; x < boardXsize.Value; x++, i++)
            {
                Vector3 segmentPosition = new Vector3(x,y,0);
                GameObject tempSegment = Instantiate(boardSegment,segmentPosition,boardSegment.transform.rotation) as GameObject;
                tempSegment.transform.SetParent(transform);
                StringBuilder segmentName = new StringBuilder();
                segmentName.Append(x.ToString())
                    .Append("x")
                    .Append(y.ToString());
                tempSegment.name = segmentName.ToString();
            }
        }
    }
}

