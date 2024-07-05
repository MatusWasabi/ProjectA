using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPositionSetter : MonoBehaviour
{
    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        IMapData imapData = other.gameObject.GetComponent<IMapData>();
        imapData.SetMapPosition(transform.position);
    }
}
