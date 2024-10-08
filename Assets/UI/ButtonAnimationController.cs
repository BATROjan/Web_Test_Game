using DG.Tweening;
using UnityEngine.UI;

namespace UI
{
    public class ButtonAnimationController
    {
        private float _blinkDuration = 1;
        private float _blinkInterval = 0.2f;
        
        private bool value;
        
        public ButtonAnimationController()
        {
            
        }

        public void FadeAnimation(Image image)
        {
            DOTween.Sequence()
                .Append(image.DOFade(0f, _blinkDuration)) 
                .Append(image.DOFade(1f, _blinkDuration)) 
                .SetLoops(-1, LoopType.Yoyo) 
                .SetDelay(_blinkInterval);
        }
    }
}