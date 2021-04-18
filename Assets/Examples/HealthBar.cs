using System.Collections;
using System.Collections.Generic;
using ManyTools.Variables;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    #region Private Fields

    [SerializeField] private Text _healthText;
    [SerializeField] private Image _healthBarFill;
    [SerializeField] private IntReference _health;

    private int _maxHealth;
    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        _maxHealth = _health;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
    }

    #region Public Methods

    public void UpdateHealth()
    {
        _health.Value = Mathf.Clamp(_health, 0, _maxHealth);
        
        _healthText.text = $"{_health.Value} / {_maxHealth}";
        _healthBarFill.fillAmount = _health.Value / (float)_maxHealth;
    }

    #endregion
}
