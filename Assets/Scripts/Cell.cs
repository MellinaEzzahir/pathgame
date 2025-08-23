using UnityEngine;
using UnityEngine.EventSystems;

public class Cell : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerUpHandler
{
    public int row;
    public int col;
    public bool isConnector;
    public string connectorColour;

    public Sprite verticalLine;
    public Sprite horizonralLine;

    private PathManager pathManager;

    private void Start()
    {
        pathManager = FindAnyObjectByType<PathManager>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isConnector)
        {
            pathManager.StartPath(this, connectorColour);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        pathManager.AddCellToPath(this);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (isConnector)
        {
            pathManager.EndPath(this, connectorColour);
        }
        else
        {
            pathManager.EndPath(null, "");
        }
    }
}
