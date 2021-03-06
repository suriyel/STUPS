﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 11/29/2012
 * Time: 5:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSX.Commands
{
    using System;
    using System.Management.Automation;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    
    /// <summary>
    /// Description of NewSeFirefoxProfileCommand.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "SeFirefoxProfile")]
    [OutputType(typeof(OpenQA.Selenium.Firefox.FirefoxProfile))]
    public class NewSeFirefoxProfileCommand : FirefoxProfileCmdletBase
    {
        public NewSeFirefoxProfileCommand()
        {
        }
        
        #region Parameters
        [Parameter(Mandatory = false)]
        public string ProfileDirectoryPath { get; set; }
        
        [Parameter(Mandatory = false)]
        public SwitchParameter DeleteSource { get; set; }
        #endregion Parameters
        
        protected override void BeginProcessing()
        {
            this.CheckCmdletParameters();
            
            SeNewFirefoxProfileCommand command =
                new SeNewFirefoxProfileCommand(this);
            command.Execute();
        }
    }
}
