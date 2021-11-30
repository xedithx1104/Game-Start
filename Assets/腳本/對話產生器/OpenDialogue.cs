using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class OpenDialogue : MonoBehaviour
{
    [Header("�ϥΪ���")]
    public Text _fileNameDisplay;
    [Header("�ɮצW��")]
    public string _fileName;
    public static Dialogue _dialogue;

    public void GetFileName(string fileName) 
    {
        _fileName = fileName;
        
        string path = Path.Combine("��ܸ��", _fileName);

        if(File.Exists(Path.Combine(Application.dataPath, "Resources", path + ".asset")))
        {
            _fileNameDisplay.text = _fileName;

            _dialogue = (Dialogue)Resources.Load(path, typeof(Dialogue));

            FindObjectOfType<FunctionUI>().Initialized(_dialogue);
            FindObjectOfType<DialogueSetting>().Initialized(_dialogue);
        }

        else 
        {
            FindObjectOfType<FunctionUI>()._warning.SetActive(true);
            FindObjectOfType<FunctionUI>()._warning.transform.Find("���D").GetComponent<Text>().text = "�䤣��ؼ��ɮ�";
        }

    }
}
