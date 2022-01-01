using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    [Header("�ƥ󴣥�")]
    public GameObject _hint;
    public Text _text;
    [Header("�ؼЪ���")]
    public GameObject _target;
    [Header("���~")]
    public Item _item;

    private void OnTriggerStay(Collider collider)
    {
        _hint.SetActive(true);
        _text.text = "�B��";

        if (FindObjectOfType<KeyManager>()._eventState)
        {
            bool _wasPickedUp = Inventory.instance.Add(_item);

            if (_wasPickedUp)
            {
                _hint.SetActive(false);
                GameObject.Find("�ƥ�޲z").GetComponent<EventManager>().ItemPickUp(_target);
            }
        }

    }

    private void OnTriggerExit(Collider collider)
    {
        _hint.SetActive(false);
    }
}
