using UnityEngine;
using UnityEngine.UI;

namespace YooPita.RetroFx.RenerTextureFx
{
    [RequireComponent(typeof(Button))]
    public class ChangeTvPreset : MonoBehaviour
    {
        [SerializeField] private RetroTvEffectPreset _preset;
        [SerializeField] private Tv _tv;
        [SerializeField] private bool _clickOnAwake;

        public void Change()
        {
            _tv.ChangePreset(_preset);
        }

        private void Awake()
        {
            if (_clickOnAwake)
            {
                var button = GetComponent<Button>();
                button.onClick.Invoke();
                button.Select();
            }
        }
    }
}