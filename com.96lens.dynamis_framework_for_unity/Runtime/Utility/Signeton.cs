using System;

namespace Dynamis
{
    namespace Utility.Singleton
    {
        /// <summary>
        /// 通常クラスのシングルトン
        /// </summary>
        public abstract class Singleton<T> where T : class
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
            // Public関数
            //=====================================================================================================================

            /// <summary>
            /// インスタンス生成
            /// </summary>
            public static void CreateInstance()
            {
                if(_isInstantiated)
                {
                    return;
                }

                var type = typeof(T);
                var obj = Activator.CreateInstance(type, true);
                _instance = obj as T;
                _isInstantiated = true;
            }

            /// <summary>
            /// インスタンス放棄
            /// </summary>
            public virtual void Destroy()
            {
                _instance = null;
                _isInstantiated = false;
            }

        }//class Singleton
    }//namespace Utility.Singleton
}//namespace Dynamis

