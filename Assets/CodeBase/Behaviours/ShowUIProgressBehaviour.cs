using Atomic.Elements;
using Atomic.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Behaviours
{
    public class ShowUIProgressBehaviour : IEntityInit, IEntityUpdate
    {
        private TMP_Text _progressText;
        private Image _progressBarImage;
        private ReactiveVariable<int> _seconds;
        private float _tempTimer;
        private bool _isRunning;
        
        public void Init(IEntity entity)
        {
            _progressBarImage = entity.GetProgressBarImage();
            _progressText = entity.GetProgressText();
            _seconds = entity.GetSecondsForWaiting();
            _tempTimer = _seconds.Value;

            StopUIProgress();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (_isRunning &&  _tempTimer > 0)
            {
                _tempTimer -= deltaTime;
                
                SetProgress();
                
                if (_tempTimer <= 0)
                    _isRunning = false;
            }
        }

        public void StartUIProgress()
        {
            ShowUI();
            _isRunning = true;
        }

        public void StopUIProgress()
        {
            HideUI();
            ResetProgress();
        }
        
        private void SetProgress()
        {
            var progress = _tempTimer / _seconds.Value;
            
            _progressBarImage.fillAmount = Mathf.Clamp01(progress);
            _progressText.text = ((int)_tempTimer).ToString();
        }

        private void ResetProgress()
        {
            _isRunning = false;
            _tempTimer = _seconds.Value;
        }
        
        private void ShowUI()
        {
            _progressBarImage.enabled = true;
            _progressText.enabled = true;
        }

        private void HideUI()
        {
            _progressBarImage.enabled = false;
            _progressText.enabled = false;
        }
    }
}