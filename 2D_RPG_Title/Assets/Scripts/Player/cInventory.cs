using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cInventory : MonoBehaviour {

    public List<cInteractable> m_Inventory = new List<cInteractable>();
    public List<Image> m_InventoryIcons = new List<Image>();
    private cInteractable m_EmptySlot;

    private int m_MaxInventorySize = 28;
    private int m_NextAvailableSpot = 0;

    ////////////////////////////////////////////////

    private void Start()
    {
        for (int i = 0; i < m_Inventory.Count; i++)
        {
            m_Inventory.Add(m_EmptySlot);
            m_InventoryIcons.Add(m_EmptySlot.m_Sprite);
        }        
    }

    ////////////////////////////////////////////////

    public void AddItem(cInteractable item)
    {
        if(m_Inventory.Count < m_MaxInventorySize)
        {
            m_Inventory[m_NextAvailableSpot] = item;
            ++m_NextAvailableSpot;
        }
    }

    ////////////////////////////////////////////////

    public void RemoveItem(cInteractable item)
    {
        
    }

    ////////////////////////////////////////////////

    ////////////////////////////////////////////////


}
