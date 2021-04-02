using System.Collections;
using System.Collections.Generic;
using ManyTools.Variables;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    #region Private Fields

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
        UpdateFill();
    }

    #region Public Methods

    public void UpdateFill()
    {
        _healthBarFill.fillAmount = _health / _maxHealth;
    }

    #endregion
}
