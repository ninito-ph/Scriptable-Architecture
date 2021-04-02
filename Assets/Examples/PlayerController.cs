using System.Collections;
using System.Collections.Generic;
using ManyTools.Variables;
using UnityEngine;

namespace ManyTools
{
    public class PlayerController : MonoBehaviour
    {
        #region Private Fields
        [SerializeField]
        private IntReference _health;
        [SerializeField]
        private FloatReference _speed;
        #endregion

        #region MonoBehaviour Implementation
        // Update is called once per frame
        void Update()
        {
            MovePlayer();
        }
        #endregion

        #region Public Methods
        public void TakeDamage(int damage)
        {
            _health.Value -= damage;
        }
        #endregion
        
        #region Private Methods
        private void MovePlayer()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(_speed * horizontalInput * Time.deltaTime, 0f, 0f);
        }
        #endregion
    }
}
