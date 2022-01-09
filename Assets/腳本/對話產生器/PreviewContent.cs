using UnityEngine;
using UnityEngine.UI;

public class PreviewContent : MonoBehaviour
{
    #region ���

    [Header("�奻���")]
    public Text _text;
    [Header("�奻��T")]
    public Sentence _content;

    #endregion

    #region ���e��J

    public void SetContent(Sentence sentence)
    {
        _content = new Sentence(sentence.type, sentence.id, sentence.chara, sentence.isRead, sentence.dialogue);

        PreviewText();
    }

    public void SetSimpleContent(Sentence sentence)
    {
        _content = new Sentence(sentence.type, sentence.id, sentence.chara, sentence.isRead, sentence.dialogue);

        PreviewSimpleText();
    }

    #endregion

    #region �奻�榡�إߤζ�R

    public void PreviewText()
    {
        string name;
        char[] dialogueType = { 'N', 'D', 'B' };

        if (_content.chara == 0) { name = "�ǥ�"; }
        else { name = FindObjectOfType<ScrollList>().charas[_content.chara].name; }

        string preview = _content.id + " " + dialogueType[_content.type] + " " + name + "\n" + _content.dialogue;

        _text.text =  preview;
    }

    public void PreviewSimpleText() 
    {
        string name;
     
        if (_content.chara == 0) { name = "�ǥ�"; }
        else { name = FindObjectOfType<ScrollList>().charas[_content.chara].name; }

        string preview = name + "\n" + _content.dialogue;

        _text.text = preview;
    }

    #endregion
}