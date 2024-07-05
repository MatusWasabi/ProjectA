using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour, IMapData
{
    [SerializeField] private SoPlayerData soPlayerData;

    public Vector2 GetMapPosition()
    {
        return soPlayerData.GetMapPosition();
    }

    public void SetMapPosition(Vector2 position)
    {
        soPlayerData.SetMapPosition(position);
    }

    public Vector2 GetTargetPosition()
    {
        return soPlayerData.GetTargetPosition();
    }

    public List<Vector2> GetPossibleNodes()
    {
        return soPlayerData.GetPossibleNodes();
    }

    public void SetPossibleNodes(List<Vector2> possibleNodes)
    {
        soPlayerData.SetPossibleNodes(possibleNodes);
    }
}
