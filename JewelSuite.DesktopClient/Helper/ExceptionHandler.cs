﻿using System;
using System.Windows;
using JewelSuite.DesktopClient.Extension;

namespace JewelSuite.DesktopClient.Helper
{
    /// <summary>
    /// Global exception handler method is created .When application is started ,this metod called. 
    /// </summary>
    public class ExceptionHandler
    {
        public static void GlobalUnhandledExceptionHandler(Exception exception, string source)
        {
            string message = exception.GetaAllMessages();
            string caption = $"Unhandled exception ({source})";

            MessageBox.Show(message, caption);
        }
    }
}
