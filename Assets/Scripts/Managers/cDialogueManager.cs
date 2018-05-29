using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cDialogueManager : MonoBehaviour {

	public Queue<string> mSentences;

	public Text m_NPCName;
	public Text m_BodyText;

	public Animator mAnim;

	//////////////////////////////////////////

	void Awake()
	{
		Main.DialogueManager = this;
	}

	//////////////////////////////////////////

	void Start () 
	{
		mSentences = new Queue<string> ();
		mAnim = mAnim.GetComponent<Animator> ();
	}

	//////////////////////////////////////////

	public void StartDialogue(cDialogue dialogue)
	{
		//Store NPC name
		if (dialogue.m_Name == "")
			dialogue.m_Name = "...";
		
		m_NPCName.text = dialogue.m_Name;

		//Empty left over strings from previous dialogues
		mSentences.Clear ();

		//Play transition in Animation
		mAnim.SetBool("ShowDialoguePopup", true);

		//Process sentences to show
		foreach (string sentence in dialogue.m_Sentences)
		{
			mSentences.Enqueue (sentence);
		}

		ShowNextSentence ();
	}

	//////////////////////////////////////////

	public void ShowNextSentence()
	{
		//End conversation is no more text to show
		if (mSentences.Count == 0)
		{
			EndConversation ();
		} 
		else //Move onto next line of text
		{
			m_BodyText.text = mSentences.Dequeue ();
		}
	}

	public void EndConversation()
	{
		mAnim.SetBool ("ShowDialoguePopup", false);
	}

	//////////////////////////////////////////

}
