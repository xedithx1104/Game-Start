using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueReview : MonoBehaviour
{
    [Header("�ϥΪ���")]
    public GameObject _previewText;
    public Scrollbar _scrollbar;
    [Header("�w�����e")]
    public List<GameObject> _previewTexts;

    public List<Chara> charas;
}
