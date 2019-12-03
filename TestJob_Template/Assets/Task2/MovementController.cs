using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovementController : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private float rangeDistanceMin = -80f;
    [SerializeField]
    private float rangeDistanceMax = 0f;

    [SerializeField]
    private float currentPos;

    private bool isMove = false;
    public bool SetIsMove() { return isMove; }

    public void OnDrag(PointerEventData eventData)
    {
        isMove = true;

        if (Mathf.Abs(eventData.delta.y) >= Mathf.Abs(eventData.delta.x))
        {
            transform.parent.parent.localPosition += new Vector3(0f, eventData.delta.y, 0f);
        }
        else
        {
            Vector2 currentPosition = transform.localPosition;
            Vector2 newPosition = eventData.delta + currentPosition;

            float clampPos = Mathf.Clamp(newPosition.x, rangeDistanceMin, rangeDistanceMax);

            currentPos = clampPos;
            transform.localPosition = new Vector3(clampPos, transform.localPosition.y);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isMove = false;
        float averengePosition = (rangeDistanceMax + rangeDistanceMin) / 2;

        if (averengePosition > currentPos)
            transform.localPosition = new Vector3(rangeDistanceMin, transform.localPosition.y);
        else
            transform.localPosition = new Vector3(rangeDistanceMax, transform.localPosition.y);
    }
}
