using UnityEngine;
using UnityEngine.EventSystems;

public class UIDraggable : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    private Vector3 startPosition;
    private RaycastHit2D ray;
    private bool combinable = false;
    private GameObject player;

    private void Awake()
    {
        canvasGroup = gameObject.AddComponent<CanvasGroup>();
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        rectTransform = GetComponent<RectTransform>();
        combinable = GetComponent<Card>().combinationData ? true : false;
        player = GameObject.Find("Player");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        startPosition = rectTransform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.position = eventData.position;
        ray = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(eventData.position), Vector2.zero);

        // if (ray.collider != null)
        // {
        //     // Card glowing
        // }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        GameObject dropOn = eventData.pointerCurrentRaycast.gameObject;

        if (ray.collider == null && dropOn == null)
        {
            rectTransform.position = startPosition;
        }
        else if (ray.collider)
        {
            var drop = ray.collider.gameObject.GetComponent<Droppable>();
            if (drop) { drop.Drop(player, gameObject); }
        }
        else if (combinable && dropOn)
        {
            Card component = dropOn.GetComponent<Card>();
            if (component)
            {
                if (!component.Combine(gameObject))
                {
                    rectTransform.position = startPosition;
                }
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }
}
