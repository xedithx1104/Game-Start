using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("��ܸ�ƽs��")]
    public string _dialogueID;

    public void TriggerDialogue() 
    {
        FindObjectOfType<DialogueManager>().StartDialogue(_dialogueID);
    }
}
