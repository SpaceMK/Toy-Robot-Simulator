using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Test Case")]
public class TestCase : ScriptableObject
{
    public List<Commands> TestCases = new List<Commands>();
    public List<PlacementCoordinates> PlacementCoordinate = new List<PlacementCoordinates>();
   


    public PlacementCoordinates ReturnPlacementCoordinates(int index)
    {
        try
        {
            return PlacementCoordinate[index];
        }
        catch
        {
            Debug.Log("No placement coordinates given! Resorting to default");
            return new PlacementCoordinates();
        }
        
    }
}

