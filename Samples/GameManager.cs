using Ninito.ScriptableArchitecture.Variables;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Private Fields

    [SerializeField] private Text _scoreText;
    [SerializeField] private FloatReference _score;

    #endregion

    #region MonoBehaviour Implementation

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score.Value += 10f;
        }
    }

    #endregion

    #region Public Methods

    public void UpdateScoreDisplay()
    {
        _scoreText.text = "Score: " + _score;
    }

    #endregion
}