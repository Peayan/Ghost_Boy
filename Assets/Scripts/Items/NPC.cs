using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : cInteractable {

	private cDialogueText mDialogue;

	////////////////////////////////////////

	void Awake()
	{
		m_itemType = Interact_Type.NPC;
	}

	////////////////////////////////////////

	void Start()
	{
		mDialogue = GetComponent<cDialogueText> ();
	}

	////////////////////////////////////////

	public void Talk()
	{
		//Access the dialogeManager and pass through npc's unique conversation
		if(mDialogue != null)
			Main.DialogueManager.StartDialogue(mDialogue.m_activeDialogue);
	}

	////////////////////////////////////////

	public void Shop()
	{
		//Open the shop UI with NPCs specific items
	}

	////////////////////////////////////////
}
