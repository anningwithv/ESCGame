





using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFrame
{
    public delegate void OnDownloadFinished(string fileName, int download, int totalFileLenght);
    public delegate void OnDownloadError(string errorMsg);
    public delegate void OnDownloadProgress(int download, int totalFileLenght);
    public delegate void OnDownloadBegin(int totalLength);
    public delegate bool OnDownloadValidCheck(byte[] rawData);

    public interface IHttpDownloader
    {
        bool AddDownloadTask(string uri, string localPath, int fileSize, OnDownloadProgress onProgress, OnDownloadError onError, OnDownloadFinished onFinshed, OnDownloadBegin onBegin, OnDownloadValidCheck checker, bool logError);
    }
}
