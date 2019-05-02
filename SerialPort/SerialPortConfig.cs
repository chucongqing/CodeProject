﻿/*************************************************************************
 *  Copyright © 2017-2018 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SerialPortConfig.cs
 *  Description  :  Config of serialport parameters.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  4/5/2017
 *  Description  :  Initial development version.
 *  
 *  Author       :  Mogoson
 *  Version      :  0.1.1
 *  Date         :  3/2/2018
 *  Description  :  Optimize.
 *************************************************************************/

using System;
using System.IO.Ports;

namespace MGS.IO.Ports
{
    /// <summary>
    /// Config of SerialPort.
    /// </summary>
    [Serializable]
    public class SerialPortConfig
    {
        #region Field and Property
        public string portName = "COM1";
        public int baudRate = 9600;
        public Parity parity = Parity.None;
        public int dataBits = 8;
        public StopBits stopBits = StopBits.One;

        public int readBufferSize = 1024;
        public int readTimeout = 500;
        public byte readHead = 254;
        public byte readTail = 255;
        public int readCount = 10;
        public int readCycle = 250;

        public int writeBufferSize = 1024;
        public int writeTimeout = 500;
        public byte writeHead = 254;
        public byte writeTail = 255;
        public int writeCount = 10;
        public int writeCycle = 250;
        #endregion

        #region Public Method
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SerialPortConfig() { }

        /// <summary>
        /// Constructor of SerialPortConfig.
        /// </summary>
        public SerialPortConfig(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            this.portName = portName;
            this.baudRate = baudRate;
            this.parity = parity;
            this.dataBits = dataBits;
            this.stopBits = stopBits;
        }
        #endregion
    }
}