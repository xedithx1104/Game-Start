using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class OpenDialogue : MonoBehaviour
{
    [Header("�ϥΪ���")]
    public Text _fileNameDisplay;
    [Header("�ɮצW��")]
    public string _fileName;

    public void GetFileName(string fileName) 
    {
        _fileName = fileName;
        _fileNameDisplay.text = _fileName;

        string path = Path.Combine("��ܸ��", _fileName);
        FindObjectOfType<FunctionUI>().Initialized(path);
        FindObjectOfType<DialogueSetting>().Initialized(path);
    }
}
