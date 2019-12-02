using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingItem : MonoBehaviour
{
    [SerializeField]
    private GameObject itemPrefab;
    [SerializeField]
    private Transform parent;

    public void AddItem()
    {
        Instantiate(itemPrefab, parent);
    }
}
