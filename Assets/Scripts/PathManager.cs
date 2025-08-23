using UnityEngine;
using System.Collections.Generic;

public class PathManager : MonoBehaviour
{
    public List<Cell> currentPath = new List<Cell>();
    public string startColour = "";
    public bool isDrawing = false;

    private void Update()
    {
        DrawPath();
    }

    public void StartPath(Cell startConnector, string colour)
    {
        currentPath.Clear();
        currentPath.Add(startConnector);
        startColour = colour;
        isDrawing = true;
    }

    public void AddCellToPath(Cell newCell)
    {
        if (isDrawing)
        {
            Cell lastCell = currentPath[currentPath.Count - 1];

            //to do check if 
            bool isNextTo = true;

            if (isNextTo)
            {
                currentPath.Add(newCell);
                Debug.Log("added new cell: " + newCell.row + newCell.col);
            }
        }
    }

    public void EndPath(Cell endConnector, string colour)
    {
        isDrawing = false;

        if (colour == startColour)
        {
            Debug.Log("new path");
        }
        else
        {
            Debug.Log("wrong colour");
            currentPath.Clear();
        }
    }

    public void DrawPath()
    {
        
    }
}