using FrozenPhoenix.Utilities.UI;
using TMPro;
using UnityEngine;


namespace FrozenPhoenix.Samples.UI
{
    public class TypeWriterExample : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;
        [SerializeField] private string textToType;

        [SerializeField] private float typeWriteSpeedPerLetter;
        // [SerializeField] private string textToType;

        private Coroutine _coroutine;

        [ContextMenu("Write Text")]
        public void WriteText()
        {
            if (_coroutine != null)
                StopCoroutine(_coroutine);
            _coroutine = StartCoroutine(UIUtilities.TextTypeWriteEffect(text, textToType, typeWriteSpeedPerLetter));
        }

        [ContextMenu("Stop writing Text")]
        public void StopWritingText()
        {
            if (_coroutine != null)
                StopCoroutine(_coroutine);
        }
    }
}


