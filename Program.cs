// Copyright (c) 2010 Ravi Bhavnani
// License: Code Project Open License
// http://www.codeproject.com/info/cpol10.aspx

using Marjani.Net.GoogleTranslator;
using System;
using System.Windows.Forms;

namespace RavSoft.GoogleTranslator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GoogleTranslatorFrm());
        }
    }
}
