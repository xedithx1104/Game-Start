using UnityEngine;
using UnityEngine.UI;

public class NPCTrigger : MonoBehaviour
{
    public DialogueTrigger _dialogueTrigger;
    public string _dialogueID;
    public GameObject _hint;
    public Text _text;

    private void Start()
    {
        _dialogueTrigger.GetComponent<DialogueTrigger>();
    }

    private void OnTriggerStay(Collider collider)
    {
        if (!FindObjectOfType<DialogueManager>()._dialogueMode) { _hint.SetActive(true); }
        _text.text = "���";

        if (FindObjectOfType<KeyManager>()._eventState){

            _dialogueTrigger._dialogueID = _dialogueID;
            _dialogueTrigger.TriggerDialogue();
            _hint.SetActive(false);

        }

    }

    private void OnTriggerExit(Collider collider)
    {
        _hint.SetActive(false);
    }
}
