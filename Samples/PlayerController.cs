using System.Collections;
using System.Collections.Generic;
using Ninito.ScriptableArchitecture.Variables;
using UnityEngine;

namespace Ninito.ScriptableArchitecture
{
    public class PlayerController : MonoBehaviour
    {
        #region Private Fields
        [SerializeField]
        private IntReference health;
        [SerializeField]
        private FloatReference speed;
        #endregion

        #region Unity Callbacks
        
        // Update is called once per frame
        private void Update()
        {
            MovePlayer();
        }
        
        #endregion

        #region Public Methods
        
        public void TakeDamage(int damage)
        {
            health.Value -= damage;
        }
        
        #endregion
        
        #region Private Methods
        
        private void MovePlayer()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(speed * horizontalInput * Time.deltaTime, 0f, 0f);
        }
        
        #endregion
    }
}
