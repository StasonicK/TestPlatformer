﻿using System.Collections;
using UnityEngine;

namespace CodeBase.UI
{
    public class LoadingCurtain : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _curtain;

        private const int MinimumAlpha = 0;
        private const int MaximumAlpha = 1;
        private const float StepAlpha = 0.03f;

        public void Show()
        {
            gameObject.SetActive(true);
            _curtain.alpha = MaximumAlpha;
        }

        public void Hide() =>
            StartCoroutine(FadeOut());

        private IEnumerator FadeOut()
        {
            while (_curtain.alpha > MinimumAlpha)
            {
                _curtain.alpha -= StepAlpha;
                yield return new WaitForSeconds(StepAlpha);
            }

            gameObject.SetActive(false);
        }
    }
}