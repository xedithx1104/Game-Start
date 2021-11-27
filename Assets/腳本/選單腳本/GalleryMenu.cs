using UnityEngine;
using UnityEngine.UI;

public class GalleryMenu : MonoBehaviour
{
    [Header("CG���")]
    public Transform _cGParent;
    [Header("��������")]
    public LoadScenes _loadScenes;
    [Header("CG�w��")]
    public GameObject _cGDisplay;
    public CGData _cGData;

    private Button[] _cGButton;
    private CGSlot[] _cGSlots;
    private Image _nowCG;
    

    private void Start()
    {
        _cGSlots = _cGParent.GetComponentsInChildren<CGSlot>();
        _cGButton = _cGParent.GetComponentsInChildren<Button>();
        _nowCG = _cGDisplay.GetComponent<Image>();
        
        Initialized();
    }

    private void Update()
    {
        DisplayChecked();
    }

    public void DisplayCG(CGSlot slot) 
    {
        Debug.Log("CG " + slot.ID + " is coming soon.");
        _cGDisplay.SetActive(true);
        _nowCG.sprite = slot._sprite.sprite;
    }

    public void BackToTitle() 
    {
        _loadScenes.LoadNewScene("�}�l�e��");
        _loadScenes._asyncload.allowSceneActivation = true;
    }

    private void Initialized()
    {
        foreach(CG cg in _cGData.CGs) 
        { 
            foreach(CGSlot slot in _cGSlots) 
            {
                if (System.Convert.ToInt32(slot.ID) == cg.id && cg.used) 
                {
                    slot._sprite.sprite = _cGData.CGs[cg.id].sprite;
                    slot._sprite.color = Color.white;
                    _cGButton[cg.id].enabled = true;
                }
            }
        }
    }

    private void DisplayChecked() 
    {
        if (FindObjectOfType<KeyManager>()._escapeState) { _cGDisplay.SetActive(false); }
    }
}
