using System.Collections;

namespace Dynamis
{
    namespace Extension
    {
        /// <summary>
        /// ICollection拡張クラス
        /// </summary>
        public static class CollectionExtension
        {
            //=====================================================================================================================
            // 拡張関数
            //=====================================================================================================================
            /// <summary>
            /// コレクションがNullまたは要素数が「0」か
            /// </summary>
            /// <param name="self">コレクション</param>
            /// <returns></returns>
            public static bool IsNullOrEmpty(this ICollection self)
            {
                if(self == null)
                {
                    return true;
                }

                if(self.Count == 0)
                {
                    return true;
                }

                return false;
            }

        }//class CollectionExtension
    }//namespace Extension
}//namespace Dynamis

