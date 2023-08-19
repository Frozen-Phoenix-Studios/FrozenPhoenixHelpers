using System.Linq;
using UnityEngine;

namespace FrozenPhoenixStudios.Utilities
{
    public class LoopingElementShuffler<T> where T : class
    {
        private T[] _elements;
        private T[] _shuffledElements;
        private int _currentIndex;

        public LoopingElementShuffler(T[] elements)
        {
            _elements = elements;
            ShuffleElements();
        }

        private void ShuffleElements()
        {
            T lastElement = (_currentIndex > 0 && _currentIndex == _shuffledElements.Length)
                ? _shuffledElements[_currentIndex - 1]
                : null;

            _shuffledElements = _elements.OrderBy(t => Random.value).ToArray();

            if (_shuffledElements.Length > 1 && _shuffledElements[0] == lastElement)
            {
                _shuffledElements[0] = _shuffledElements[1];
                _shuffledElements[1] = lastElement;
            }
        }

        public T GrabNextElement()
        {
            if (_currentIndex >= _shuffledElements.Length)
            {
                ShuffleElements();
                _currentIndex = 0;
            }

            return _shuffledElements[_currentIndex++];
        }
    }
}