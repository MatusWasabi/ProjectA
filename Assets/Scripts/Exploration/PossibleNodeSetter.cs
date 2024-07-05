using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossibleNodeSetter : MonoBehaviour
{
    [SerializeField] private List<GameObject> possibleNodes;
    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        IMapData imapData = other.gameObject.GetComponent<IMapData>();
        List<Vector2> possibleNodeLocations = new List<Vector2>();
        foreach (var node in possibleNodes)
        {
            Vector2 location = node.transform.position;
            possibleNodeLocations.Add(location);
        }
        imapData.SetPossibleNodes(possibleNodeLocations);
    }
}
