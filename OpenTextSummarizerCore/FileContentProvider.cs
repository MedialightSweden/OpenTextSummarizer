﻿using System;
using OpenTextSummarizerCore.Interfaces;

namespace OpenTextSummarizerCore
{
    public class FileContentProvider : IContentProvider
    {
        public string FilePath { get; set; }

        public string Content { get;  }

        public FileContentProvider(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            if (!System.IO.File.Exists(filePath))
            {
                throw new System.IO.FileNotFoundException(string.Empty, filePath);
            }

            FilePath = FilePath;
            Content = System.IO.File.ReadAllText(filePath);
        }
    }
}