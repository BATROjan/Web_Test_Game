using UnityEngine;

namespace UI
{
    public class UIRoot : MonoBehaviour
    {
        public Button StartButton => startButton;
        [SerializeField] Button startButton;
    }
}