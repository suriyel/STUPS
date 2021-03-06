﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/3/2012
 * Time: 3:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSX
{
    using System;
    using System.Management.Automation;
    using SePSX.Commands;
    
    /// <summary>
    /// Description of SeInvokeNavigateBackCommand.
    /// </summary>
    internal class SeInvokeNavigateBackCommand : SeNavigationCommand
    {
        internal SeInvokeNavigateBackCommand(CommonCmdletBase cmdlet) : base(cmdlet)
        {
        }
        
        internal override void Execute()
        {
            SeHelper.NavigateBack(
                this.Cmdlet,
                ((InvokeSeNavigateBackCommand)this.Cmdlet).InputObject);
        }
    }
}
