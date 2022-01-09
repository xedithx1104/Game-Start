using UnityEngine;
using UnityEngine.UI;

public class FunctionUI : MonoBehaviour
{
    #region ���

    [Header("����ɮ�")]
    public static Dialogue _dialogue;
    [Header("�ϥΪ���")]
    public GameObject _warning;             //���~ĵ�i�T��
    public GameObject _charaSettingUI;      //�H���]�w����
    public GameObject _dialogueSettingUI;   //��ܳ]�w����
    public Dropdown _eventSelect;           //�ƥ�����ﶵ
    public Dropdown _charaSelect;           //�H�������ﶵ
    public InputField _sentencID;           //��ܽs����J��
    public InputField _sentenceInput;       //��ܿ�J��
    public Toggle _backGround;
    public Toggle _sprite;
    public InputField _ImageID;
    public int select = 0;                  //�\���� 1.�s�W 2.���J 3.�s�� 4.�R�� 5.�x�s

    #endregion

    #region ��l��

    public void Initialized(Dialogue dialogue)
    {
        _dialogue = dialogue;
    }

    #endregion

    #region �}�ҤH���]�w����

    public void SetChara() 
    {
        if (!CheckWarning()) { return; }

        _charaSettingUI.SetActive(true);
        _dialogueSettingUI.SetActive(false);
    }

    #endregion

    #region ��ܥ\����

    public void SettingFunctionSelect(int newValue) 
    {
        select = newValue;

        if(!CheckWarning()) { return; }

        _charaSettingUI.SetActive(false);
        _dialogueSettingUI.SetActive(true);
        CheckInteractable();

    }


    public void SaveButton() 
    {
        select = 5;
        if (!CheckWarning()) { return; }

        FindObjectOfType<DialogueSetting>().SaveDialogue();
    }

    #endregion

    #region ��ܳ]�w�����]�m

    private void CheckInteractable() 
    {
        _eventSelect.interactable = true;
        _sentencID.interactable = true;
        _charaSelect.interactable = true;
        _sentenceInput.interactable = true;
        _backGround.interactable = true;
        _sprite.interactable = true;
        _ImageID.interactable = true;

        if(select == 1)
        {
            _sentencID.interactable = false;
        }
        if(select == 4) 
        {
            _eventSelect.interactable = false;
            _charaSelect.interactable = false;
            _sentenceInput.interactable = false;
            _backGround.interactable = false;
            _sprite.interactable = false;
            _ImageID.interactable = false;
        }
    }

    #endregion

    #region ĵ�i�������

    private bool CheckWarning() 
    {
        if (_dialogue == null)
        {
            _warning.SetActive(true);
            _warning.transform.Find("���D").GetComponent<Text>().text = "�п���ɮ�";

            return false;
        }

        else if (FindObjectOfType<DialogueSetting>().charas.Count <= 1 && select != 0) 
        {
            _warning.SetActive(true);
            _warning.transform.Find("���D").GetComponent<Text>().text = "�зs�W�H��";
            select = 0;

            return false;
        }
        else if (FindObjectOfType<DialogueSetting>().sentences.Count <= 0 && select == 5) 
        {
            _warning.SetActive(true);
            _warning.transform.Find("���D").GetComponent<Text>().text = "�зs�W���";
            select = 0;

            return false;
        }
        else
        {
            return true;
        }
    }

    #endregion
}
