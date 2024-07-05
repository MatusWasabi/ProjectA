using UnityEngine;

public abstract class Card : MonoBehaviour
{
    [SerializeField] protected string cardName;
    [SerializeField] public CombinationData combinationData;

    public bool Combine(GameObject component)
    {
        Card componentCard = component.GetComponent<Card>();
        string componentName = componentCard.cardName.ToLower();
        if (componentCard.combinationData == null || combinationData == null) { return false; }

        foreach (TupleData tupleData in combinationData.data)
        {
            if (tupleData.component.ToLower() == componentName)
            {
                GameObject newCard = Instantiate(tupleData.product, gameObject.transform.parent);
                newCard.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
                Destroy(component);
                Destroy(gameObject);
                return true;
            }
        }

        return false;
    }
}
