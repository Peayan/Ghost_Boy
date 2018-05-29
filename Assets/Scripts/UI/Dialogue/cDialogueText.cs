using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cDialogueText : MonoBehaviour {

	public cDialogue m_activeDialogue;

	public void TriggerDialogue()
	{
		Main.DialogueManager.StartDialogue (m_activeDialogue);
	}
}
