using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    [SerializeField] private SoPlayerData _playerData;
    
    private void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        _textMeshProUGUI.text = $"Health: {_playerData.GetHealth().ToString()}";
    }
    
    
    
    
}
