﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Linq;
using System.Management.Automation;
using Microsoft.WindowsAzure.Commands.ServiceManagement.Common;
using Microsoft.WindowsAzure.Commands.ServiceManagement.Model;

namespace Microsoft.WindowsAzure.Commands.ServiceManagement.IaaS.Disks
{
    [Cmdlet(VerbsCommon.Get, ProfileNouns.DataDisk), OutputType(typeof(DataVirtualHardDisk))]
    public class GetAzureDataDisk : VirtualMachineConfigurationCmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, HelpMessage = "Data Disk LUN")]
        [ValidateNotNullOrEmpty]
        public int? Lun
        {
            get;
            set;
        }

        internal void ExecuteCommand()
        {
            var role = VM.GetInstance();

            if (Lun == null)
            {
                WriteObject(role.DataVirtualHardDisks, true);
            }
            else
            {
                var disk = role.DataVirtualHardDisks.SingleOrDefault(dd => dd.Lun == Lun);
                WriteObject(disk, true);
            }
        }

        protected override void ProcessRecord()
        {
            ExecuteCommand();
        }
    }
}