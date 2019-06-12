﻿/*************************************************************************
 *  Copyright © 2018 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  LED.cs
 *  Description  :  Define LED component.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  3/9/2018
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.ElectronicComponent
{
    /// <summary>
    /// LED component.
    /// </summary>
    [AddComponentMenu("MGS/ElectronicComponent/LED")]
    [RequireComponent(typeof(Renderer))]
    public class LED : MonoLED
    {
        #region Field and Property
        /// <summary>
        /// Highlight material of LED.
        /// </summary>
        public Material highlightMat = null;

        /// <summary>
        /// Default material of LED.
        /// </summary>
        protected Material defaultMat = null;

        /// <summary>
        /// Renderer of LED.
        /// </summary>
        protected Renderer LEDRenderer = null;
        #endregion

        #region Public Method
        /// <summary>
        /// Initialize LED.
        /// </summary>
        public override void Initialize()
        {
            LEDRenderer = GetComponent<Renderer>();
            defaultMat = LEDRenderer.material;
        }

        /// <summary>
        /// Open LED.
        /// </summary>
        public override void Open()
        {
            if (isEnabled)
            {
                LEDRenderer.material = highlightMat;
            }
        }

        /// <summary>
        /// Close LED.
        /// </summary>
        public override void Close()
        {
            if (isEnabled)
            {
                LEDRenderer.material = defaultMat;
            }
        }
        #endregion
    }
}