using UnityEngine;
using UnityEngine.UI;

public class SlotWithName : InventorySlot
{
    [Header("���~�W�����")]
    public Text _text;

    public override void AddItem(Item item)
    {
        base.AddItem(item);

        _text.text = item._name;
    }
}
