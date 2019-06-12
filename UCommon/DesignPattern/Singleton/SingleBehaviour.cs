/*************************************************************************
 *  Copyright © 2019 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SingleBehaviour.cs
 *  Description  :  MonoBehaviour with a single instance.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  4/20/2019
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.UCommon.DesignPattern
{
    /// <summary>
    /// MonoBehaviour with a single instance.
    /// </summary>
    [AddComponentMenu("MGS/Common/DesignPattern/SingleBehaviour")]
    public sealed class SingleBehaviour : SingleMonoBehaviour<SingleBehaviour>
    {
        #region Protected Method
        /// <summary>
        /// SingleBehaviour awake.
        /// </summary>
        protected override void SingleAwake()
        {
            base.SingleAwake();
            DontDestroyOnLoad(this);
        }
        #endregion
    }
}