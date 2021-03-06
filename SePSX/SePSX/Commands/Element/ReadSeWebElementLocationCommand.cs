﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 7/19/2012
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSX.Commands
{
    using System;
    using System.Management.Automation;
    using OpenQA.Selenium;
    
    /// <summary>
    /// Description of ReadSeWebElementLocationCommand.
    /// </summary>
    [Cmdlet(VerbsCommunications.Read, "SeWebElementLocation")]
    [OutputType(typeof(object))]
    public class ReadSeWebElementLocationCommand : WebElementCmdletBase
    {
        public ReadSeWebElementLocationCommand()
        {
        }
        
        protected override void ProcessRecord()
        {
            this.checkInputWebElementOnly(this.InputObject);
            
            SeReadWebElementLocationCommand command =
                new SeReadWebElementLocationCommand(this);
            command.Execute();
            //SeHelper.GetWebElementLocation(this, ((IWebElement[])this.InputObject));
        }
    }
}
