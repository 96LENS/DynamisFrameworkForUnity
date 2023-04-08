using UnityEngine;

namespace Dynamis
{
    namespace Utility
    {
        /// <summary>
        /// Hierarchyのコンポーネントとしてオブジェクトにアタッチするシングルトン
        /// </summary>
        public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
        {
            //=====================================================================================================================
            // 定数
            //=====================================================================================================================
            private static T _instance = null;
            private static bool _isInstantiated = false;

            //=====================================================================================================================
            // プロパティ
            //=====================================================================================================================
            /// <summary> インスタンス </summary>
            public T Instance => _instance;
            
            /// <summary> 生成済み判定 </summary>
            public bool IsInstantiated => _isInstantiated;

            //=====================================================================================================================
            // MonoBehavior関数
            //=====================================================================================================================

            /// <summary>
            /// 起動時初期化
            /// </summary>
            protected virtual void Awake()
            {
                _instance = this.GetComponent<T>();

                if(_instance != null)
                {
                    _isInstantiated = true;
                }

            }

            /// <summary>
            /// 放棄
            /// </summary>
            protected virtual void Destroy()
            {
                _instance = null;
                _isInstantiated = false;
            }

        }//class Singleton
    }//namespace Utility.Singleton
}//namespace Dynamis

