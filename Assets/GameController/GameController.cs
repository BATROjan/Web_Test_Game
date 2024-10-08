using DG.Tweening;
using Panel;
using UI;

namespace GameController
{
    public class GameController
    {
        private readonly ButtonAnimationController _animationController;
        private readonly UIRoot _uiRoot;
        private readonly PanelController _panelController;

        private Button _startButton;
        private PanelView _panelView;
        
        public GameController(
            ButtonAnimationController animationController,
            UIRoot uiRoot,
            PanelController panelController)
        {
            _animationController = animationController;
            _uiRoot = uiRoot;
            _panelController = panelController;
            _startButton = _uiRoot.StartButton;

            _startButton.OnClick += CreatePanel;
        }

        private void CreatePanel()
        {
            if (!_panelView)
            {
               _animationController.FadeAnimation(_startButton.Image);
                _panelView = _panelController.Spawn();
            }
        }
    }
}