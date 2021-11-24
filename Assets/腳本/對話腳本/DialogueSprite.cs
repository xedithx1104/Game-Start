using System.Collections.Generic;
using UnityEngine;

public class DialogueSprite : MonoBehaviour
{
    public Transform _spriteParent;

    private CharaSprite[] _inputCharaSprites;
    private CharaSprite[] _outputCharaSprites;

    void Awake()
    {
        _inputCharaSprites = _spriteParent.GetComponentsInChildren<CharaSprite>();
    }

    public void SetCharaSprite(List<Chara> charas) {

        _outputCharaSprites = new CharaSprite[charas.Count - 1];

        int count = 0;
        foreach (Chara chara in charas) 
        {
            if (chara.name.Equals("")) { continue; }

            foreach(CharaSprite charaSprite in _inputCharaSprites)
            {
                if (charaSprite.name.Equals(chara.name)) {
                    Debug.Log(chara.name + " " + chara.posiX + " " + charaSprite.name);
                    _outputCharaSprites[count] = charaSprite;
                    _outputCharaSprites[count].Move(chara.posiX);
                    Debug.Log(_outputCharaSprites[count].name);
                    count++;
                }
            }
        }
    
    }

    public void DispalySprites(int _isSpeakChara) 
    {
        for(int i = 0; i < _outputCharaSprites.Length; i++) 
        {
            if (i == (_isSpeakChara - 1)) { 
                _outputCharaSprites[i]._isSpeak = true;
                _outputCharaSprites[i].IsSpeak();
            }
            else { 
                _outputCharaSprites[i]._isSpeak = false;
                _outputCharaSprites[i].NonSpeak();
            }
        }
    }
}
