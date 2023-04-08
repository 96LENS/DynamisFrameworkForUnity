using UnityEngine;

namespace Dynamis
{
    namespace Extension
    {
        /// <summary>
        /// Componentクラスの拡張クラス
        /// </summary>
        public static class ComponentExtension
        {
            //=====================================================================================================================
            // 拡張関数
            //=====================================================================================================================

            /// <summary>
            /// コンポーネントを削除します
            /// </summary>
            /// <param name="self"></param>
            /// <typeparam name="T"></typeparam>
            public static void RemoveComponent<T>(this T self) where T : Component
            {
                GameObject.Destroy(self.GetComponent<T>());
            }

        }//class ComponentExtension
    }//namespace Extension
}//namespace Dynamis

