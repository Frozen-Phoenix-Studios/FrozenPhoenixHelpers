using UnityEngine;

namespace FrozenPhoenix.Utilities
{
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        [SerializeField] private bool destroyOnLoad;

        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.LogError($"{typeof(T)} is null");
                }

                return _instance;
            }
        }

        protected void Awake()
        {
            if (_instance != null)
                Destroy(gameObject);
            else
                _instance = this as T;
            SetDestroyOnLoadProperty();

            Init();

        }

        protected virtual void Init()
        {
        }


        private void SetDestroyOnLoadProperty()
        {
            if (destroyOnLoad)
                return;
            
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
        }
    }
}