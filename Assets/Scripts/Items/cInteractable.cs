using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cInteractable : MonoBehaviour {

	public enum Interact_Type {NPC, ITEM, PUZZLE};
	[SerializeField]
	Interact_Type m_itemType;

	public string m_Name;


}
