using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public abstract class ButtonBehaviour : MonoBehaviour
    {
        protected Button button;

        private void Awake()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(OnClick);
        }

        public abstract void OnClick();
    }
}