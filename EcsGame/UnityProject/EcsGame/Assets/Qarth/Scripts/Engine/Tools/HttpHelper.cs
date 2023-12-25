using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#if UNITY_2018 || UNITY_2019
using UnityEngine.Networking;
#endif

namespace GameFrame
{
#if UNITY_2018 || UNITY_2019
    public class BypassCertificate : CertificateHandler
    {
        protected override bool ValidateCertificate(byte[] certificateData)
        {
            //Simply return true no matter what
            return true;
        }
    }
#endif
}